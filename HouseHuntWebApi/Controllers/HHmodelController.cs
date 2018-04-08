using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HouseHuntWebApi.Models;

namespace HouseHuntWebApi.Controllers
{
    public class HHmodelController : ApiController
    {
        private HouseHuntEntities context = new HouseHuntEntities();
        // GET: api/HHmodel
        public IEnumerable<Property> Get()
        {
            return context.Properties.ToList();
           // return new string[] { "value1", "value2" };
        }

        // GET: api/HHmodel/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/HHmodel
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/HHmodel/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/HHmodel/5
        public void Delete(int id)
        {
        }
    }
}
