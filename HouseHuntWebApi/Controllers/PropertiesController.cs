using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HouseHuntWebApi.Models;

namespace HouseHuntWebApi.Controllers
{
    public class PropertiesController : ApiController
    {
        private Property context = new Property();
        // GET: api/Properties
        public IEnumerable<string> Get()
        {
         //  return  context.Prop_City.ToString();

            return new string[] { "value1", "value2" };
        }

        // GET: api/Properties/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Properties
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Properties/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Properties/5
        public void Delete(int id)
        {
        }
    }
}
