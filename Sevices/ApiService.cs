using Crud_MVC.Models;
using Newtonsoft.Json;
using System.Text;

namespace Crud_MVC.Sevices
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;   
        }

        public async Task<UserModel> POST(UserModel model)
        {  
            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://localhost:44388/api/User/createUser/", content);
            var responseBody = await response.Content.ReadAsStringAsync();

            var user = JsonConvert.DeserializeObject<UserModel>(responseBody);
            return user;
        }

        public async Task<UserModel> GET(int id)
        {
            var response = await _httpClient.GetAsync($"https://localhost:44388/api/User/getUser/{id}");
            var responseBody = await response.Content.ReadAsStringAsync();

            var user = JsonConvert.DeserializeObject<UserModel>(responseBody);
            return user;
        }

        public Task<UserModel> UPDATE(UserModel model)
        {
            throw new NotImplementedException();
        }

        public async Task DELETE(int id)
        {
            var response = await _httpClient.GetAsync($"https://localhost:44388/api/User/deleteUser/{id}");
            var responseBody = await response.Content.ReadAsStringAsync();
        }

        public async Task<List<UserModel>> GETALL()
        {
            var response = await _httpClient.GetAsync("https://localhost:44388/api/User/getUsers/");
            var responseBody = await response.Content.ReadAsStringAsync();

            var user = JsonConvert.DeserializeObject<List<UserModel>>(responseBody);
            return user;
        }
    }
}
