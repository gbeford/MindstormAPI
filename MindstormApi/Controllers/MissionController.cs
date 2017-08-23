using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MindstormApi.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MindstormApi.Controllers
{
    [Route("api/[controller]")]
    public class MissionController : Controller
    {
        private readonly MindstormDbContext ctx;


        public MissionController(MindstormDbContext context)
        {
            ctx = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Mission> Get()
        {

            var missions = ctx.Missions.OrderBy(o => o.SortOrder).Include(i => i.MissionItems).OrderBy(o => o.SortOrder);

            return missions;
          
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
