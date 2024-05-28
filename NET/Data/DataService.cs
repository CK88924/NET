using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
namespace NET.Data
{
    public class DataService
    {
        private readonly HttpClient _httpClient;

        public DataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> SendDataAsync(object data)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5000/process_data", data);
            response.EnsureSuccessStatusCode();
            var responseData = await response.Content.ReadAsStringAsync();
            return responseData;
        }
    }
}
