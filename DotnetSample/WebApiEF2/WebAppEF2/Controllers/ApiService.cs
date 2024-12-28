using System.Text.Json;
using Microsoft.DotNet.MSIdentity.Shared;
using WebAppEF2.Models;

namespace WebAppEF2.Controllers
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        public ApiService(HttpClient httpClient)
        {
            this._httpClient = new HttpClient();
        }

        //public async Task<IEnumerable<PET>> GetApiResponse()
        //{
        //    _httpClient.BaseAddress = new Uri("http://localhost:5205/api/PETApi");
        //    var res = await _httpClient.GetAsync("PETApi");
        //    res.EnsureSuccessStatusCode();
        //    var resContent = await res.Content.ReadFromJsonAsync<IList<PET>>();
        //    return JsonSerializer.Deserialize<IEnumerable<PET>>((System.Text.Json.Nodes.JsonNode?)resContent);
        //}
    }
}
