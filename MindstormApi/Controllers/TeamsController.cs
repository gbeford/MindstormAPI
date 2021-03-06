﻿using System;
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

        // Get team list
        // GET api/values
        [HttpGet]
        public IEnumerable<Team> Get()
        {
            //var teams = ctx.Teams.Where(t => t.TeamName.Contains("Shrewsbury")).OrderBy(t => t.TeamNumber).ToList();
            var teams = ctx.Teams;
            return teams.ToList();
        }

        // Get a team
        // GET api/values/5
        [HttpGet("{id}")]
        public Team Get(int id)
        {
            var team = ctx.Teams.Find(id);
            return team;
        }

        // Create team
        // POST api/values
        [HttpPost]
        public Team Post([FromBody]Team value)
        {
            value.Created = DateTime.Now;
            ctx.Teams.Add(value);
            ctx.SaveChanges();
            return value;
        }

        // Update team
        // PUT api/values/5
        [HttpPut("{id}")]
        public Team Put(int id, [FromBody]Team value)
        {
            var oldTeam = ctx.Teams.Find(id);
            if (oldTeam != null)
            {
                oldTeam.TeamName = value.TeamName;
                oldTeam.TeamNumber = value.TeamNumber;
                oldTeam.CoachFirstName = value.CoachFirstName;
                oldTeam.CoachLastName = value.CoachLastName;
                oldTeam.CoachEmail = value.CoachEmail;
                oldTeam.AltCoachFirstName = value.AltCoachFirstName;
                oldTeam.AltCoachlastName = value.AltCoachlastName;
                oldTeam.AltCoachEmail = value.AltCoachEmail;
                oldTeam.City = value.City;
                oldTeam.State = value.State;
                oldTeam.Updated = DateTime.Now;
                ctx.Update(oldTeam);
                ctx.SaveChanges();
            }
            return oldTeam;
        }

        // Delete team
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
