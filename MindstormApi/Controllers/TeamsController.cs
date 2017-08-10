using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MindstormApi.Models;

namespace MindstormApi.Controllers
{
    [Route("api/[controller]")]
    public class TeamsController : Controller
    {
        private readonly MindstormDbContext ctx;

        public TeamsController(MindstormDbContext context)
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
        public Team Post([FromBody]Team value)
        {
            value.Created = DateTime.Now;
            ctx.Teams.Add(value);
            ctx.SaveChanges();
            return value;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Team value)
        {
            var oldTeam = ctx.Teams.Find(id);
            if (oldTeam != null)
            {
                oldTeam.TeamName = value.TeamName;
                oldTeam.TeamNumber = value.TeamNumber;
                oldTeam.CoachFirstName = value.CoachFirstName;

                oldTeam.Updated = DateTime.Now;
                ctx.Update(oldTeam);
                ctx.SaveChanges();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var deleteTeam = ctx.Teams.Find(id);
            if (deleteTeam != null)
            {
                ctx.Remove(deleteTeam);
                ctx.SaveChanges();
            }
        }
    }
}
