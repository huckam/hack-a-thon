﻿// <auto-generated />
using ECTPFinalProject.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECTPFinalProject.Data.Migrations
{
    [DbContext(typeof(GolfLeagueContext))]
    [Migration("20231112225257_AddMoreData")]
    partial class AddMoreData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ECTPFinalProject.Core.Entities.GolfCourse", b =>
                {
                    b.Property<int>("GolfCourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GolfCourseId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GolfCourseId")
                        .HasName("PK_GolfCourse");

                    b.ToTable("GolfCourse", (string)null);

                    b.HasData(
                        new
                        {
                            GolfCourseId = 1,
                            Name = "Pebble Beach"
                        },
                        new
                        {
                            GolfCourseId = 2,
                            Name = "Augusta National"
                        });
                });

            modelBuilder.Entity("ECTPFinalProject.Core.Entities.Hole", b =>
                {
                    b.Property<int>("HoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HoleId"));

                    b.Property<int>("GolfCourseId")
                        .HasColumnType("int");

                    b.Property<int>("HoleNumber")
                        .HasColumnType("int");

                    b.Property<int>("Par")
                        .HasColumnType("int");

                    b.HasKey("HoleId")
                        .HasName("PK_Hole");

                    b.HasIndex("GolfCourseId");

                    b.ToTable("Hole", (string)null);

                    b.HasData(
                        new
                        {
                            HoleId = 1,
                            GolfCourseId = 1,
                            HoleNumber = 1,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 2,
                            GolfCourseId = 1,
                            HoleNumber = 2,
                            Par = 3
                        },
                        new
                        {
                            HoleId = 3,
                            GolfCourseId = 1,
                            HoleNumber = 3,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 4,
                            GolfCourseId = 1,
                            HoleNumber = 4,
                            Par = 5
                        },
                        new
                        {
                            HoleId = 5,
                            GolfCourseId = 1,
                            HoleNumber = 5,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 6,
                            GolfCourseId = 1,
                            HoleNumber = 6,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 7,
                            GolfCourseId = 1,
                            HoleNumber = 7,
                            Par = 3
                        },
                        new
                        {
                            HoleId = 8,
                            GolfCourseId = 1,
                            HoleNumber = 8,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 9,
                            GolfCourseId = 1,
                            HoleNumber = 9,
                            Par = 5
                        },
                        new
                        {
                            HoleId = 10,
                            GolfCourseId = 1,
                            HoleNumber = 10,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 11,
                            GolfCourseId = 1,
                            HoleNumber = 11,
                            Par = 3
                        },
                        new
                        {
                            HoleId = 12,
                            GolfCourseId = 1,
                            HoleNumber = 12,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 13,
                            GolfCourseId = 1,
                            HoleNumber = 13,
                            Par = 5
                        },
                        new
                        {
                            HoleId = 14,
                            GolfCourseId = 1,
                            HoleNumber = 14,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 15,
                            GolfCourseId = 1,
                            HoleNumber = 15,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 16,
                            GolfCourseId = 1,
                            HoleNumber = 16,
                            Par = 3
                        },
                        new
                        {
                            HoleId = 17,
                            GolfCourseId = 1,
                            HoleNumber = 17,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 18,
                            GolfCourseId = 1,
                            HoleNumber = 18,
                            Par = 5
                        },
                        new
                        {
                            HoleId = 19,
                            GolfCourseId = 2,
                            HoleNumber = 1,
                            Par = 3
                        },
                        new
                        {
                            HoleId = 20,
                            GolfCourseId = 2,
                            HoleNumber = 2,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 21,
                            GolfCourseId = 2,
                            HoleNumber = 3,
                            Par = 5
                        },
                        new
                        {
                            HoleId = 22,
                            GolfCourseId = 2,
                            HoleNumber = 4,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 23,
                            GolfCourseId = 2,
                            HoleNumber = 5,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 24,
                            GolfCourseId = 2,
                            HoleNumber = 6,
                            Par = 3
                        },
                        new
                        {
                            HoleId = 25,
                            GolfCourseId = 2,
                            HoleNumber = 7,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 26,
                            GolfCourseId = 2,
                            HoleNumber = 8,
                            Par = 5
                        },
                        new
                        {
                            HoleId = 27,
                            GolfCourseId = 2,
                            HoleNumber = 9,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 28,
                            GolfCourseId = 2,
                            HoleNumber = 10,
                            Par = 3
                        },
                        new
                        {
                            HoleId = 29,
                            GolfCourseId = 2,
                            HoleNumber = 11,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 30,
                            GolfCourseId = 2,
                            HoleNumber = 12,
                            Par = 5
                        },
                        new
                        {
                            HoleId = 31,
                            GolfCourseId = 2,
                            HoleNumber = 13,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 32,
                            GolfCourseId = 2,
                            HoleNumber = 14,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 33,
                            GolfCourseId = 2,
                            HoleNumber = 15,
                            Par = 3
                        },
                        new
                        {
                            HoleId = 34,
                            GolfCourseId = 2,
                            HoleNumber = 16,
                            Par = 4
                        },
                        new
                        {
                            HoleId = 35,
                            GolfCourseId = 2,
                            HoleNumber = 17,
                            Par = 5
                        },
                        new
                        {
                            HoleId = 36,
                            GolfCourseId = 2,
                            HoleNumber = 18,
                            Par = 4
                        });
                });

            modelBuilder.Entity("ECTPFinalProject.Core.Entities.League", b =>
                {
                    b.Property<int>("LeagueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeagueId"));

                    b.Property<int>("GolfCourseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("LeagueId")
                        .HasName("Pk_League");

                    b.HasIndex("GolfCourseId");

                    b.ToTable("League", (string)null);

                    b.HasData(
                        new
                        {
                            LeagueId = 1,
                            GolfCourseId = 1,
                            Name = "CGI Golf"
                        });
                });

            modelBuilder.Entity("ECTPFinalProject.Core.Entities.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberId"));

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Handicap")
                        .HasColumnType("float");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.HasKey("MemberId")
                        .HasName("PK_Member");

                    b.HasIndex("LeagueId");

                    b.ToTable("Member", (string)null);

                    b.HasData(
                        new
                        {
                            MemberId = 1,
                            FirstName = "Anthony",
                            Handicap = 20.0,
                            LastName = "Huck",
                            LeagueId = 1
                        },
                        new
                        {
                            MemberId = 2,
                            FirstName = "Patrick",
                            Handicap = 3000.0,
                            LastName = "Dewey",
                            LeagueId = 1
                        },
                        new
                        {
                            MemberId = 3,
                            FirstName = "Heath",
                            Handicap = 22.0,
                            LastName = "Murphy",
                            LeagueId = 1
                        },
                        new
                        {
                            MemberId = 4,
                            FirstName = "Jana",
                            Handicap = 18.0,
                            LastName = "Patchen",
                            LeagueId = 1
                        },
                        new
                        {
                            MemberId = 5,
                            FirstName = "Josh",
                            Handicap = 16.0,
                            LastName = "Kulp",
                            LeagueId = 1
                        },
                        new
                        {
                            MemberId = 6,
                            FirstName = "Olivia",
                            Handicap = 11.0,
                            LastName = "Whitman",
                            LeagueId = 1
                        },
                        new
                        {
                            MemberId = 7,
                            FirstName = "David",
                            Handicap = 6.0,
                            LastName = "Houchens",
                            LeagueId = 1
                        });
                });

            modelBuilder.Entity("ECTPFinalProject.Core.Entities.Score", b =>
                {
                    b.Property<int>("ScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScoreId"));

                    b.Property<int>("Hole1Score")
                        .HasColumnType("int");

                    b.Property<int>("Hole2Score")
                        .HasColumnType("int");

                    b.Property<int>("Hole3Score")
                        .HasColumnType("int");

                    b.Property<int>("Hole4Score")
                        .HasColumnType("int");

                    b.Property<int>("Hole5Score")
                        .HasColumnType("int");

                    b.Property<int>("Hole6Score")
                        .HasColumnType("int");

                    b.Property<int>("Hole7Score")
                        .HasColumnType("int");

                    b.Property<int>("Hole8Score")
                        .HasColumnType("int");

                    b.Property<int>("Hole9Score")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<int>("WeekNumber")
                        .HasColumnType("int");

                    b.HasKey("ScoreId")
                        .HasName("PK_Score");

                    b.HasIndex("MemberId");

                    b.ToTable("Score", (string)null);

                    b.HasData(
                        new
                        {
                            ScoreId = 1,
                            Hole1Score = 4,
                            Hole2Score = 4,
                            Hole3Score = 4,
                            Hole4Score = 4,
                            Hole5Score = 4,
                            Hole6Score = 4,
                            Hole7Score = 4,
                            Hole8Score = 4,
                            Hole9Score = 4,
                            MemberId = 1,
                            WeekNumber = 1
                        },
                        new
                        {
                            ScoreId = 2,
                            Hole1Score = 4,
                            Hole2Score = 4,
                            Hole3Score = 4,
                            Hole4Score = 4,
                            Hole5Score = 4,
                            Hole6Score = 4,
                            Hole7Score = 4,
                            Hole8Score = 4,
                            Hole9Score = 4,
                            MemberId = 1,
                            WeekNumber = 2
                        },
                        new
                        {
                            ScoreId = 3,
                            Hole1Score = 4,
                            Hole2Score = 4,
                            Hole3Score = 4,
                            Hole4Score = 4,
                            Hole5Score = 4,
                            Hole6Score = 4,
                            Hole7Score = 4,
                            Hole8Score = 4,
                            Hole9Score = 4,
                            MemberId = 1,
                            WeekNumber = 3
                        },
                        new
                        {
                            ScoreId = 4,
                            Hole1Score = 4,
                            Hole2Score = 4,
                            Hole3Score = 4,
                            Hole4Score = 4,
                            Hole5Score = 4,
                            Hole6Score = 4,
                            Hole7Score = 4,
                            Hole8Score = 4,
                            Hole9Score = 4,
                            MemberId = 2,
                            WeekNumber = 1
                        },
                        new
                        {
                            ScoreId = 5,
                            Hole1Score = 4,
                            Hole2Score = 4,
                            Hole3Score = 4,
                            Hole4Score = 4,
                            Hole5Score = 4,
                            Hole6Score = 4,
                            Hole7Score = 4,
                            Hole8Score = 4,
                            Hole9Score = 4,
                            MemberId = 2,
                            WeekNumber = 2
                        },
                        new
                        {
                            ScoreId = 6,
                            Hole1Score = 4,
                            Hole2Score = 4,
                            Hole3Score = 4,
                            Hole4Score = 4,
                            Hole5Score = 4,
                            Hole6Score = 4,
                            Hole7Score = 4,
                            Hole8Score = 4,
                            Hole9Score = 4,
                            MemberId = 2,
                            WeekNumber = 3
                        });
                });

            modelBuilder.Entity("ECTPFinalProject.Core.Entities.Hole", b =>
                {
                    b.HasOne("ECTPFinalProject.Core.Entities.GolfCourse", "GolfCourse")
                        .WithMany("Holes")
                        .HasForeignKey("GolfCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GolfCourse");
                });

            modelBuilder.Entity("ECTPFinalProject.Core.Entities.League", b =>
                {
                    b.HasOne("ECTPFinalProject.Core.Entities.GolfCourse", "GolfCourse")
                        .WithMany()
                        .HasForeignKey("GolfCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GolfCourse");
                });

            modelBuilder.Entity("ECTPFinalProject.Core.Entities.Member", b =>
                {
                    b.HasOne("ECTPFinalProject.Core.Entities.League", "League")
                        .WithMany("Members")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("League");
                });

            modelBuilder.Entity("ECTPFinalProject.Core.Entities.Score", b =>
                {
                    b.HasOne("ECTPFinalProject.Core.Entities.Member", "Member")
                        .WithMany("Scores")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("ECTPFinalProject.Core.Entities.GolfCourse", b =>
                {
                    b.Navigation("Holes");
                });

            modelBuilder.Entity("ECTPFinalProject.Core.Entities.League", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("ECTPFinalProject.Core.Entities.Member", b =>
                {
                    b.Navigation("Scores");
                });
#pragma warning restore 612, 618
        }
    }
}
