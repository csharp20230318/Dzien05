using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        // GET /api/Values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        // GET /api/Values/1
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value" + id;
        }

        // POST /api/Values
        [HttpPost]
        //public string Post(string value1, int value2)
        public string Post([FromBody] string value)
        {
            return $"POST: {value}";
        }


        // DELETE /api/Values/1
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"do usuniecia: {id}";
        }

        // PUT /api/Values/1
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string value)
        {
            return $"PUT: {id} , {value}";
        }
    }
}
