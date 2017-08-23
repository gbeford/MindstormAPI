using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindstormApi.Models
{
    public class MindstormDbContext : DbContext
    {
        public MindstormDbContext(DbContextOptions<MindstormDbContext> options)
            : base(options)
        { }
        public DbSet<MatchDefinition> MatchDefinition { get; set; }
        public DbSet<Match> Matches { get; set; }       
        public DbSet<MatchDetails> MatchDetails { get; set; }        
        public DbSet<Points> Points { get; set; }
        public DbSet<Team> Teams { get; set; }

        public DbSet<Mission> Missions { get; set; }
        public DbSet<MissionItem> MissionItems { get; set; }
    }

}

