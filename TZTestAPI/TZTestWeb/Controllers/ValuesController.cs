using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TZTestWeb.Models;

namespace TZTestWeb.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public ColumnsSection Get()
        {

            var folderDetails = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\{"layout.json"}");
            var strJson = System.IO.File.ReadAllText(folderDetails);

            var root = Newtonsoft.Json.JsonConvert.DeserializeObject<ColumnsSection>(strJson);



            return root;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
