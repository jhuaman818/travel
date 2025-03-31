using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using travel.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace travel.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://10.0.2.2:8000/api/") // Cambia según la IP de tu servidor
            };
        }

        public async Task<LoginResponse> LoginAsync(string email, string password)
        {
            var data = new { email, password };
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync("login", content);

            if (!response.IsSuccessStatusCode)
            {
                return new LoginResponse { Success = false, Message = "Error en la autenticación" };
            }

            string result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<LoginResponse>(result);
        }

        public void SetAuthToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
    }

    public class LoginResponse
    {
        public bool Success { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
    }
}
