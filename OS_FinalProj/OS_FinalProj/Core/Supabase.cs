using Newtonsoft.Json;
using Supabase;
using Supabase.Gotrue;
using Supabase.Gotrue.Exceptions;
using Supabase.Postgrest;
using Supabase.Postgrest.Models;
using Supabase.Postgrest.Exceptions;
using Supabase.Storage;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client = Supabase.Client;

namespace OS_FinalProj.Core
{
    public class SupabaseClient
    {
        private readonly string _supabaseUrl = "https://ejlnfxqllcylpuurmgpv.supabase.co";
        private readonly string _supabaseApiKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImVqbG5meHFsbGN5bHB1dXJtZ3B2Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTExMTk5MDIsImV4cCI6MjA2NjY5NTkwMn0.WAWUFV16HuVpLpYm0w7zsb1XY2Hf-qCLGE9bBPQ10dU";
        
        private readonly Client _client;

        // Add this property
        public Client Client => _client;

        public SupabaseClient()
        {
            var options = new SupabaseOptions
            {
                AutoConnectRealtime = true,
                AutoRefreshToken = true
            };

            _client = new Client(_supabaseUrl, _supabaseApiKey, options);
        }

        public async Task InitializeAsync()
        {
            await _client.InitializeAsync();
            Console.WriteLine("Supabase client initialized");
        }

        // Sign-up function - updated to return both session and user
        public async Task<(Session session, User user)> SignUpAsync(string email, string password)
        {
            try
            {
                Console.WriteLine("Attempting to sign up with email: " + email);
                var session = await _client.Auth.SignUp(email, password);

                if (session?.User == null)
                {
                    MessageBox.Show("Sign-up failed: User session is null.");
                    Console.WriteLine("Sign-up failed: User session is null.");
                    return (null, null);
                }

                Console.WriteLine($"Session created: {session.User?.Email}");
                return (session, session.User);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sign-up error: {ex.Message}");
                Console.WriteLine($"Sign-up error: {ex.Message}");
                return (null, null);
            }
        }

        // Profile creation function - updated to accept user ID directly
        public async Task<bool> CreateUserProfileAsync(string userId, string email, string username, string firstName, string lastName)
        {
            try
            {
                Console.WriteLine($"Creating profile for user ID: {userId}");

                var profile = new Profile
                {
                    Id = Guid.Parse(userId), // Convert string to Guid
                    Email = email,
                    Username = username,
                    FirstName = firstName,
                    LastName = lastName,
                    Role = "customer",
                    ContactNumber = null,
                    CreatedAt = DateTime.UtcNow
                };

                var response = await _client.From<Profile>().Insert(profile);

                if (response.ResponseMessage?.IsSuccessStatusCode != true)
                {
                    string errorMessage = response.ResponseMessage != null
                        ? await response.ResponseMessage.Content.ReadAsStringAsync()
                        : "Insert operation failed with no response message";

                    MessageBox.Show($"Profile creation failed: {errorMessage}");
                    Console.WriteLine($"Profile creation failed: {errorMessage}");
                    return false;
                }

                Console.WriteLine("Profile created successfully");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Profile creation error: {ex.Message}");
                Console.WriteLine($"Profile creation error: {ex.Message}");
                return false;
            }
        }

        public async Task<(bool success, string message)> SignInAsync(string usernameOrEmail, string password)
        {
            try
            {
                Console.WriteLine($"Attempting to sign in with: {usernameOrEmail}");
                var session = await _client.Auth.SignIn(usernameOrEmail, password);

                if (session?.User != null)
                {
                    if (session.User.ConfirmedAt == null)
                    {
                        return (false, "Please verify your email before logging in.");
                    }

                    Console.WriteLine($"Login successful for: {session.User.Email}");

                    // Use getUID to get the UID from the profiles table for the logged-in email
                    var uid = await GetUID(session.User.Email);
                    if (uid != null)
                    {
                        // Check if a basket exists for this UID
                        var basket = await GetUserBasket(uid);
                        if (basket == null)
                        {
                            await CreateNewBasket(uid);
                            Debug.WriteLine($"Created basket for user {uid} on first login.");
                        }
                    }

                    return (true, "Login successful");
                }

                return (false, "Invalid username/email or password");
            }
            catch (GotrueException ex)
            {
                Console.WriteLine($"Auth error: {ex.Message}");
                return (false, ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Login error: {ex.Message}");
                return (false, "An error occurred during login");
            }
        }

        public User GetCurrentUser()
        {
            return _client.Auth.CurrentUser;
        }

        // Add these methods to your SupabaseClient class
        public async Task<Profile> GetProfileByEmail(string email)
        {
            try
            {
                return await _client.From<Profile>()
                    .Where(x => x.Email == email)
                    .Single();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Email profile query error: {ex}");
                return null;
            }
        }

        public async Task<string?> GetUID(string email)
        {
            try
            {
                var profile = await _client.From<Profile>()
                    .Where(x => x.Email == email)
                    .Single();
                return profile?.Id.ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error retrieving UID from profiles: {ex.Message}");
                return null;
            }
        }

        public async Task EnsureProfileExists(string userId, string email)
        {
            try
            {
                var newProfile = new Profile
                {
                    Id = Guid.Parse(userId),
                    Email = email,
                    Username = email.Split('@')[0],
                    Role = "customer",
                    CreatedAt = DateTime.UtcNow
                };

                await _client.From<Profile>().Insert(newProfile);
                Debug.WriteLine("Created new profile successfully");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Profile creation failed: {ex}");
            }
        }

        public async Task<Profile> GetUserProfile(string userId)
        {
            try
            {
                if (Guid.TryParse(userId, out var guidId))
                {
                    return await _client.From<Profile>()
                        .Where(x => x.Id == guidId)
                        .Single();
                }
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error getting profile: {ex}");
                return null;
            }
        }
        public async Task<bool> CreateUserProfile(Profile profile)
        {
            try
            {
                var response = await _client
                    .From<Profile>()
                    .Insert(profile);

                if (response.ResponseMessage?.IsSuccessStatusCode != true)
                {
                    string errorContent = response.ResponseMessage != null
                        ? await response.ResponseMessage.Content.ReadAsStringAsync()
                        : "No response content";

                    Debug.WriteLine($"Supabase Error: {errorContent}");
                    MessageBox.Show($"Profile creation failed: {errorContent}");
                    return false;
                }

                return true;
            }
            catch (PostgrestException ex)
            {
                Debug.WriteLine($"Postgrest Exception: {ex.Message}");
                Debug.WriteLine($"Details: {ex.Response?.Content}");
                MessageBox.Show($"Database error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"General Exception: {ex}");
                MessageBox.Show($"Error creating profile: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> UpdateUserProfile(Profile profile)
        {
            try
            {
                var result = await _client.From<Profile>()
                    .Upsert(profile);

                if (result.ResponseMessage?.IsSuccessStatusCode != true)
                {
                    string errorMessage = result.ResponseMessage != null
                        ? await result.ResponseMessage.Content.ReadAsStringAsync()
                        : "Update operation failed with no response message";

                    MessageBox.Show($"Error updating profile: {errorMessage}");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating profile: {ex.Message}");
                return false;
            }
        }

        private async Task<Basket> GetUserBasket(string userId)
        {
            try
            {
                // Fetch the basket from the "baskets" table
                var response = await _client
                    .From<Basket>()
                    .Where(x => x.UserId == userId)  // Using lambda expression instead of .Eq()
                    .Single();  // Retrieve a single record

                return response;  // Return the Basket object directly
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error retrieving user's basket: {ex.Message}");
                return null;  // Return null if an error occurs
            }
        }

        private async Task<Basket?> CreateNewBasket(string userId)
        {
            Debug.WriteLine("CreateNewBasket called");
            try
            {
                var newBasket = new Basket
                {
                    UserId = userId, // Use the userId passed as parameter!
                    Status = "open",
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                };

                var response = await _client
                    .From<Basket>()
                    .Insert(newBasket);

                return response?.Model;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error creating new basket: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> UpdateUserBasket(string userId, Guid serviceId, int quantity = 1)
        {
            try
            {
                // 1. Get the user's active basket
                var basket = await GetUserBasket(userId);
                if (basket == null)
                {
                    basket = await CreateNewBasket(userId);
                    if (basket == null)
                        return false;
                }

                // 2. Add the service to the basket_items table
                var basketItem = new BasketItem
                {
                    Id = Guid.NewGuid(),
                    BasketId = basket.Id,
                    ServiceId = serviceId,
                    Quantity = quantity
                };

                var response = await _client
                    .From<BasketItem>()
                    .Insert(basketItem);

                // 3. Update the basket's UpdatedAt timestamp
                basket.UpdatedAt = DateTimeOffset.UtcNow;
                await _client.From<Basket>().Upsert(basket);

                return response?.Model != null;

                Debug.WriteLine(response?.Model != null ? "Basket created!" : "Basket creation failed!");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error updating user's basket: {ex.Message}");
                return false;
            }
        }

        // Retrieves the basket UID from the baskets table for a given userId
        public async Task<string?> GetBasketUID(string userId)
        {
            try
            {
                var basket = await _client.From<Basket>()
                    .Where(x => x.UserId == userId)
                    .Single();
                return basket?.Id.ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error retrieving basket UID: {ex.Message}");
                return null;
            }
        }

        public async Task<BasketItem?> CreateNewBasketItems(Guid basketId, Guid serviceId, int quantity = 1)
        {
            try
            {
                var newBasketItem = new BasketItem
                {
                    Id = Guid.NewGuid(),
                    BasketId = basketId,
                    ServiceId = serviceId,
                    Quantity = quantity
                };

                var response = await _client
                    .From<BasketItem>()
                    .Insert(newBasketItem);

                return response?.Model;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error creating new basket item: {ex.Message}");
                return null;
            }
        }
    }
}