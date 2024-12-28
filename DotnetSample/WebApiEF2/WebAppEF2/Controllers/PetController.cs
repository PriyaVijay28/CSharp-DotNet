using System.Net.Http;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiEF2.Models;
using WebAppEF2.Models;
using PET = WebApiEF2.Models.PET;

namespace WebAppEF2.Controllers
{
    public class PetController : Controller
    {
        // GET: PetController
        private readonly ApiService apiService;
        public PetController(ApiService apiService)
        {
            this.apiService = apiService;   
        }
        public  ActionResult Index()
        {
            IEnumerable<PET> pets = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5205/api/PETApi");
                //HTTP GET
                var responseTask = client.GetAsync("PETApi");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadFromJsonAsync<IList<PET>>();
                    readTask.Wait();

                    pets = readTask.Result;
                }
            }
            return View(pets);
        }

        // GET: PetController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: PetController/Create
       
        public ActionResult Create()
        {
                       
                return View();
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        // GET: PetController/Create
        public ActionResult Create([Bind("PId", "PName", "PType", "DOB", "isVeg")] PET pet)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    // var json = JsonSerializer.Serialize(pet);
                    //var content = new StringContent(json, Encoding.UTF8, "application/json");
                    // var response = client.PostAsync("http://localhost:5205/api/PETApi", content);
                    client.BaseAddress = new Uri("http://localhost:5205/api/PETApi");
                    var postTask = client.PostAsJsonAsync("PETApi", pet);
                    postTask.Wait();
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    ModelState.AddModelError(string.Empty, "An error occurred while creating the pet.");
                }     
              }
            return RedirectToAction("Index", "Pet");
        }

        

        // GET: PetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PetController/Edit/5
        [HttpPut,HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("PId", "PName", "PType", "DOB", "isVeg")] PET pet)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    
                    client.BaseAddress = new Uri("http://localhost:5205/api/PETApi");
                    var postTask = client.PutAsJsonAsync("PETApi", pet);
                    postTask.Wait();
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    ModelState.AddModelError(string.Empty, "An error occurred while creating the pet.");
                }
            }
            return RedirectToAction("Index", "Pet");
        }

        // GET: PetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
