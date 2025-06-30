using Supabase;
using Supabase.Gotrue;
using Supabase.Gotrue.Exceptions;
using Supabase.Postgrest;
using Supabase.Postgrest.Models;
using Supabase.Postgrest.Exceptions;
using Supabase.Postgrest.Interfaces;
using Supabase.Storage;
using System;
using System.Diagnostics;
using Supabase.Postgrest;
using Client = Supabase.Client;
using static OS_FinalProj.Core.BasketItems;


namespace OS_FinalProj.Core
{
    public class SupabaseClient
    {
        private readonly string _supabaseUrl = "https://ejlnfxqllcylpuurmgpv.supabase.co";

        private readonly string _supabaseApiKey =
            "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImVqbG5meHFsbGN5bHB1dXJtZ3B2Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTExMTk5MDIsImV4cCI6MjA2NjY5NTkwMn0.WAWUFV16HuVpLpYm0w7zsb1XY2Hf-qCLGE9bBPQ10dU";

        private readonly Client _client;

        // Add this property
        public Client Client => _client;

        // Add this to your SupabaseClient class
        public IPostgrestTable<Vehicle> VehicleTable => _client.From<Vehicle>();

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
        public async Task<bool> CreateUserProfileAsync(string userId, string email, string username, string firstName,
            string lastName, string contactNumber)
        {
            try
            {
                var profile = new Profile
                {
                    Id = Guid.Parse(userId),
                    Email = email,
                    Username = username,
                    FirstName = firstName, // Include first name
                    LastName = lastName, // Include last name
                    ContactNumber = contactNumber, // Add contact number
                    Role = "customer",
                    CreatedAt = DateTime.UtcNow
                };

                var response = await _client.From<Profile>().Insert(profile);

                if (response.ResponseMessage?.IsSuccessStatusCode != true)
                {
                    string errorMessage = response.ResponseMessage != null
                        ? await response.ResponseMessage.Content.ReadAsStringAsync()
                        : "Insert operation failed with no response message";

                    MessageBox.Show($"Profile creation failed: {errorMessage}");
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

                    // Ensure profile exists after successful login
                    await EnsureProfileExists(session.User.Id, session.User.Email);

                    Console.WriteLine($"Login successful for: {session.User.Email}");
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



        public async Task EnsureProfileExists(string userId, string email)
        {
            try
            {
                // First try to get the profile by ID (using the fixed GetUserProfile)
                var existingProfile = await GetUserProfile(userId);
                if (existingProfile != null)
                {
                    Debug.WriteLine("Profile exists by ID");
                    return;
                }

                // If not found by ID, try by email
                if (!string.IsNullOrEmpty(email))
                {
                    var profileByEmail = await GetProfileByEmail(email);
                    if (profileByEmail != null)
                    {
                        Debug.WriteLine("Profile exists by email");

                        // Update the existing profile with the correct user ID if needed
                        if (profileByEmail.Id.ToString() != userId)
                        {
                            profileByEmail.Id = Guid.Parse(userId);
                            await UpdateUserProfile(profileByEmail);
                        }

                        return;
                    }
                }

                // No profile found, so just return
                Debug.WriteLine("No profile found for the user. Using the logged-in profile.");
            }
            catch (PostgrestException ex)
            {
                Debug.WriteLine($"Postgrest Exception in EnsureProfileExists: {ex.Message}");
                if (ex.Response != null)
                {
                    var content = await ex.Response.Content.ReadAsStringAsync();
                    Debug.WriteLine($"Response content: {content}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"General Exception in EnsureProfileExists: {ex}");
            }
        }


        public async Task<Profile> GetProfileByEmail(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email)) return null;

                var result = await _client.From<Profile>()
                    .Filter("email", Supabase.Postgrest.Constants.Operator.Equals, email)
                    .Single();

                return result;
            }
            catch (PostgrestException ex) when (ex.Response?.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in GetProfileByEmail: {ex}");
                return null;
            }
        }

        public async Task<Profile> GetUserProfile(string userId)
        {
            try
            {
                if (string.IsNullOrEmpty(userId)) return null;

                // Convert the string userId to Guid first
                if (!Guid.TryParse(userId, out var guidId))
                    return null;

                // Use the string representation of the Guid for filtering
                var result = await _client.From<Profile>()
                    .Filter("id", Supabase.Postgrest.Constants.Operator.Equals, userId)
                    .Single();

                return result;
            }
            catch (PostgrestException ex) when (ex.Response?.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in GetUserProfile: {ex}");
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


        public async Task<List<Vehicle>> GetUserVehicles(string ownerId)
        {
            try
            {
                // Retrieve vehicles for the current user by ownerId
                var vehicles = await _client.From<Vehicle>()
                    .Filter("owner_id", Supabase.Postgrest.Constants.Operator.Equals, ownerId)
                    .Get();

                return vehicles.Models ?? new List<Vehicle>();
            }
            catch (PostgrestException ex)
            {
                Debug.WriteLine($"Postgrest Exception in GetUserVehicles: {ex.Message}");
                return new List<Vehicle>();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"General Exception in GetUserVehicles: {ex}");
                return new List<Vehicle>();
            }
        }


        public async Task<bool> AddVehicle(string plateNumber, string make, string model, int year, string ownerId)
        {
            try
            {
                // First ensure the profile exists
                await EnsureProfileExists(ownerId, _client.Auth.CurrentUser?.Email);

                // Verify the profile was actually created by querying with the string ID
                var profile = await _client.From<Profile>()
                    .Filter("id", Supabase.Postgrest.Constants.Operator.Equals, ownerId)
                    .Single();

                if (profile == null)
                {
                    Debug.WriteLine("Profile verification failed");
                    return false;
                }

                var vehicle = new Vehicle
                {
                    PlateNumber = plateNumber,
                    Make = make,
                    Model = model,
                    Year = year,
                    OwnerId = ownerId,
                    CreatedAt = DateTime.UtcNow
                };

                var response = await _client.From<Vehicle>().Insert(vehicle);
                return response.Models?.Count > 0;
            }
            catch (PostgrestException ex)
            {
                Debug.WriteLine($"Postgrest Exception in AddVehicle: {ex.Message}");
                if (ex.Response != null)
                {
                    var content = await ex.Response.Content.ReadAsStringAsync();
                    Debug.WriteLine($"Response content: {content}");
                }
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unexpected error in AddVehicle: {ex}");
                return false; // Add this missing return statement
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
            try
            {
                var newBasket = new Basket
                {
                    UserId = userId,
                    Status = "active",  // Default status
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                };

                // Insert a new basket into the "baskets" table
                var response = await _client
                    .From<Basket>()  // Use strongly-typed Basket model
                    .Insert(newBasket);  // Insert the new basket

                // Extract the model from the response
                return response?.Model;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error creating new basket: {ex.Message}");
                return null;  // Return null if an error occurs
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
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error updating user's basket: {ex.Message}");
                return false;
            }
        }
    }
}
