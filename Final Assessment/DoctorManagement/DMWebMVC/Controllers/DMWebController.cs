using System.Drawing;
using DoctorManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace DMWebMVC.Controllers
{
    public class DMWebController : Controller
    {
        // GET: DMWebController
        public ActionResult Index()
        {
            IEnumerable<DM> Doctors = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5055/api/DMApi");
                //HTTP GET
                var responseTask = client.GetAsync("DMApi");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadFromJsonAsync<IList<DM>>();
                    readTask.Wait();

                    Doctors = readTask.Result;
                }
            }
            return View(Doctors);
        }

        // GET: DMWebController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DMWebController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DMWebController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id","Name","Speciality","Mobile","Email")] DM Doctor)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5055/api/DMApi");
                    var postTask = client.PostAsJsonAsync("DMApi", Doctor);
                    postTask.Wait();
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    ModelState.AddModelError(string.Empty, "An error occurred while creating the pet.");
                }
            }
            return RedirectToAction("Index", "DMWeb");

        }

        // GET: DMWebController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DMWebController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: DMWebController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DMWebController/Delete/5
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
