using Newtonsoft.Json;
using Supabase;
using Supabase.Gotrue;
using Supabase.Gotrue.Exceptions;
using System;
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

        private Client _supabase;

        public SupabaseClient()
        {
            var options = new SupabaseOptions
            {
                AutoConnectRealtime = true,
                AutoRefreshToken = true
            };

            _supabase = new Client(_supabaseUrl, _supabaseApiKey, options);
        }

        public async Task InitializeAsync()
        {
            await _supabase.InitializeAsync();
            Console.WriteLine("Supabase client initialized");
        }

        // Sign-up function - updated to return both session and user
        public async Task<(Session session, User user)> SignUpAsync(string email, string password)
        {
            try
            {
                Console.WriteLine("Attempting to sign up with email: " + email);

                var session = await _supabase.Auth.SignUp(email, password);

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
                    Id = Guid.Parse(userId),
                    Email = email,
                    Username = username,
                    FirstName = firstName,
                    LastName = lastName,
                    Role = "customer",
                    Phone = null,
                    CreatedAt = DateTime.UtcNow
                };

                var response = await _supabase.From<Profile>().Insert(profile);

                if (response.Models == null || !response.Models.Any())
                {
                    string errorMessage = response.ResponseMessage?.IsSuccessStatusCode == false
                        ? await response.ResponseMessage.Content.ReadAsStringAsync()
                        : "No models returned from insert";

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
        // Sign-in function 
        public async Task<(bool success, string message)> SignInAsync(string usernameOrEmail, string password)
        {
            try
            {
                Console.WriteLine($"Attempting to sign in with: {usernameOrEmail}");

                var session = await _supabase.Auth.SignIn(usernameOrEmail, password);

                if (session?.User != null)
                {
                    // Check if email is verified if required
                    if (session.User.ConfirmedAt == null)
                    {
                        return (false, "Please verify your email before logging in.");
                    }

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

        
    }
}