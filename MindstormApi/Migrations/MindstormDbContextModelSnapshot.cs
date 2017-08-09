using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MindstormApi.Models;

namespace MindstormApi.Migrations
{
    [DbContext(typeof(MindstormDbContext))]
    partial class MindstormDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MindstormApi.Models.Match", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MatchNumber");

                    b.Property<int>("Score");

                    b.Property<int>("TableNumber");

                    b.Property<int>("TeamId");

                    b.HasKey("MatchId");

                    b.HasIndex("TeamId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("MindstormApi.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Coach");

                    b.Property<string>("CoachEmail");

                    b.Property<string>("State");

                    b.Property<string>("TeamName");

                    b.Property<int>("TeamNumber");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("MindstormApi.Models.Match", b =>
                {
                    b.HasOne("MindstormApi.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
