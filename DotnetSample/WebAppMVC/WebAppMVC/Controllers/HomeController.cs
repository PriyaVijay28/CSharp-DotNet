using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> JsonReader(string pincode)
        {
            var client = _httpClientFactory.CreateClient();
            string apiUrl = $"http://api.postalpincode.in/pincode/{pincode}"; // Replace with your actual API URL

            // Send GET request to the API
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                // Deserialize the response content into a list of PostPinResponse objects
                var postJson = await response.Content.ReadAsStringAsync();
                var postPinResponseList = JsonConvert.DeserializeObject<List<ApiResponse>>(postJson);

                // Pass the data to the view
                return View(postPinResponseList);
            }
            else
            {
                // Handle error (you can pass an error message or an empty object)
                ViewBag.ErrorMessage = "Unable to fetch data from the API.";
                return View(null);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
