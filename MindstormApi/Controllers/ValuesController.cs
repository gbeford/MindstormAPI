using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MindstormApi.Models;

namespace MindstormApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly MindstormDbContext ctx;

        public ValuesController(MindstormDbContext context)
        {
            ctx = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Team> Get()
        {
            //var teams = ctx.Teams.Where(t => t.TeamName.Contains("Shrewsbury")).OrderBy(t => t.TeamNumber).ToList();
            var teams = ctx.Teams;
            return teams.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var team = ctx.Teams.Find(id);
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
