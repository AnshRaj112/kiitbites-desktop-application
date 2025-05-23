using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Microsoft.Maui.Controls;

namespace kiitbites_desktop_application
{
    public partial class LoginPage : ContentPage
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public LoginPage()
        {
            InitializeComponent(); // This must match the x:Class in XAML
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string backendUrl = Environment.GetEnvironmentVariable("BACKEND_URL") ?? "http://localhost:5001";
            var credentials = new
            {
                identifier = EmailPhoneEntry.Text,
                password = PasswordEntry.Text
            };

            string jsonBody = JsonConvert.SerializeObject(credentials);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            try
            {
                var response = await _httpClient.PostAsync($"{backendUrl}/api/auth/login", content);

                if (response.IsSuccessStatusCode)
                {
                    await DisplayAlert("Success", "Login successful!", "OK");
                }
                else
                {
                    await DisplayAlert("Error", "Invalid credentials!", "OK");
                }
            }
            catch (HttpRequestException ex)
            {
                await DisplayAlert("Network Error", $"An error occurred while trying to log in: {ex.Message}", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"An unexpected error occurred: {ex.Message}", "OK");
            }
        }
    }
}
