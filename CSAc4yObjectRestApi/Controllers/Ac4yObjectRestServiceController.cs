using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSAc4yObjectRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Ac4yObjectRestServiceController : ControllerBase
    {
        // GET: api/Ac4yObjectRestService/Get
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Ac4yObjectRestService/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Ac4yObjectRestService/Post
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Ac4yObjectRestService/Put/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/Delete/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
