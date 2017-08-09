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

        public DbSet<Match> Matches { get; set; }
        public DbSet<Team> Teams { get; set; }
    }

}

