﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using dnd.Data;

namespace dnd.Migrations
{
    [DbContext(typeof(DnDContext))]
    [Migration("20190825033438_AddedTurnNumberToCharacters")]
    partial class AddedTurnNumberToCharacters
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("dnd.Data.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Dex");

                    b.Property<int>("Initiative");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Race")
                        .IsRequired();

                    b.Property<int>("RoomId");

                    b.Property<int>("TurnNumber");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dex = 0,
                            Initiative = 0,
                            Name = "Pipes",
                            Race = "Human",
                            RoomId = 2,
                            TurnNumber = 0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Dex = 0,
                            Initiative = 0,
                            Name = "Tormatyr",
                            Race = "Aasimar",
                            RoomId = 1,
                            TurnNumber = 0,
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            Dex = 0,
                            Initiative = 0,
                            Name = "Matt's Character",
                            Race = "Human",
                            RoomId = 1,
                            TurnNumber = 0,
                            UserId = 4
                        },
                        new
                        {
                            Id = 4,
                            Dex = 0,
                            Initiative = 0,
                            Name = "Carolyn's Character",
                            Race = "Human",
                            RoomId = 1,
                            TurnNumber = 0,
                            UserId = 5
                        },
                        new
                        {
                            Id = 5,
                            Dex = 0,
                            Initiative = 0,
                            Name = "Quinn's Character",
                            Race = "Human",
                            RoomId = 1,
                            TurnNumber = 0,
                            UserId = 7
                        },
                        new
                        {
                            Id = 6,
                            Dex = 0,
                            Initiative = 0,
                            Name = "Greg's Character",
                            Race = "Human",
                            RoomId = 1,
                            TurnNumber = 0,
                            UserId = 6
                        });
                });

            modelBuilder.Entity("dnd.Data.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("InCombat");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InCombat = false,
                            Name = "Crimson Tide"
                        },
                        new
                        {
                            Id = 2,
                            InCombat = false,
                            Name = "Tales of Terrasis"
                        });
                });

            modelBuilder.Entity("dnd.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Gil",
                            Password = "gillovespoo"
                        },
                        new
                        {
                            Id = 2,
                            Name = "admin",
                            Password = "admin"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Grant",
                            Password = "gillovespoo"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Matt",
                            Password = "gillovespoo"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Carolyn",
                            Password = "gillovespoo"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Greg",
                            Password = "gillovespoo"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Quinn",
                            Password = "gillovespoo"
                        });
                });

            modelBuilder.Entity("dnd.Data.Models.Character", b =>
                {
                    b.HasOne("dnd.Data.Models.Room", "Room")
                        .WithMany("Characters")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("dnd.Data.Models.User", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
