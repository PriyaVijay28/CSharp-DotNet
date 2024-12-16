using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPISample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelPackageController : ControllerBase
    {
       private static List<string> _tp = new List<string>() { "Bangalore","Kerala","Srilanka"};
        // GET: api/<TravelPackageController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _tp;
           
        }

        // GET api/<TravelPackageController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return _tp[id];
        }

        // POST api/<TravelPackageController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _tp.Add(value);
        }

        // PUT api/<TravelPackageController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            _tp[id] = value;
        }

        // DELETE api/<TravelPackageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _tp.RemoveAt(id);
        }
    }
}
