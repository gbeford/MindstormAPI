﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MindstormApi.Models;
using System;

namespace MindstormApi.Migrations
{
    [DbContext(typeof(MindstormDbContext))]
    [Migration("20170822234222_AddNewMatchTables")]
    partial class AddNewMatchTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MindstormApi.Models.Match", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("MatchNumber");

                    b.Property<int>("MatchYear");

                    b.Property<int>("Score");

                    b.Property<int>("TableNumber");

                    b.Property<int>("TeamId");

                    b.HasKey("MatchId");

                    b.HasIndex("TeamId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("MindstormApi.Models.MatchDefinition", b =>
                {
                    b.Property<int>("MatchDefinitionId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("MatchYear");

                    b.Property<int?>("MaxRange");

                    b.Property<int?>("MinRange");

                    b.Property<string>("MissionDescription");

                    b.Property<int>("MissionOrder");

                    b.Property<string>("OptionList");

                    b.Property<string>("QuestionDescription");

                    b.Property<int>("SortOrder");

                    b.Property<string>("Type");

                    b.HasKey("MatchDefinitionId");

                    b.ToTable("MatchDefinition");
                });

            modelBuilder.Entity("MindstormApi.Models.MatchDetails", b =>
                {
                    b.Property<int>("MatchDetailsId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("MatchDefinitionId");

                    b.Property<int>("MatchYear");

                    b.Property<string>("TeamSignature");

                    b.HasKey("MatchDetailsId");

                    b.HasIndex("MatchDefinitionId");

                    b.ToTable("MatchDetails");
                });

            modelBuilder.Entity("MindstormApi.Models.Mission", b =>
                {
                    b.Property<int>("MissionId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<int>("MatchYear");

                    b.Property<string>("MissionDescription");

                    b.Property<int>("SortOrder");

                    b.HasKey("MissionId");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("MindstormApi.Models.MissionItem", b =>
                {
                    b.Property<int>("MissionItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("MaxRange");

                    b.Property<int?>("MinRange");

                    b.Property<int>("MissionId");

                    b.Property<string>("OptionList");

                    b.Property<string>("QuestionDescription");

                    b.Property<int>("SortOrder");

                    b.Property<string>("Type");

                    b.HasKey("MissionItemId");

                    b.HasIndex("MissionId");

                    b.ToTable("MissionItems");
                });

            modelBuilder.Entity("MindstormApi.Models.Points", b =>
                {
                    b.Property<int>("PointsId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MatchDefinitionDesc");

                    b.Property<int>("MatchDefinitionId");

                    b.Property<int>("Point");

                    b.Property<int>("year");

                    b.HasKey("PointsId");

                    b.ToTable("Points");
                });

            modelBuilder.Entity("MindstormApi.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AltCoachEmail");

                    b.Property<string>("AltCoachFirstName");

                    b.Property<string>("AltCoachlastName");

                    b.Property<string>("City");

                    b.Property<string>("CoachEmail");

                    b.Property<string>("CoachFirstName");

                    b.Property<string>("CoachLastName");

                    b.Property<string>("CompetitionID");

                    b.Property<DateTime>("Created");

                    b.Property<string>("State");

                    b.Property<string>("TeamName");

                    b.Property<int>("TeamNumber");

                    b.Property<DateTime>("Updated");

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

            modelBuilder.Entity("MindstormApi.Models.MatchDetails", b =>
                {
                    b.HasOne("MindstormApi.Models.MatchDefinition", "MatchDefinition")
                        .WithMany()
                        .HasForeignKey("MatchDefinitionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MindstormApi.Models.MissionItem", b =>
                {
                    b.HasOne("MindstormApi.Models.Mission", "Mission")
                        .WithMany("MissionItems")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
