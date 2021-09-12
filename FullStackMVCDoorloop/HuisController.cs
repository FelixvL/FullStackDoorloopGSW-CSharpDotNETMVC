using Microsoft.AspNetCore.Mvc;
using NaarDeDatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackMVCDoorloop
{
    [Route("api/[controller]")]
    [ApiController]
    public class HuisController : ControllerBase
    {
        private DeDatabaseContext _db;
        public HuisController(DeDatabaseContext db) {
            _db = db;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Huis huis = new Huis();
            huis.Adres = "Vlakbij";
            huis.Huisnummer = 24;
            _db.Add(huis);
            _db.SaveChanges();
            return new string[] { "value1", "value2" };
        }

        // GET api/<HuisController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HuisController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HuisController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HuisController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
