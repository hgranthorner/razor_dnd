using dnd.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace dnd.Data
{
    public class DnDContext : DbContext
    {
        protected DnDContext()
        {
        }

        public DnDContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Character> Characters { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Gil",
                    Password = "gillovespoo"
                },
                new User
                {
                    Id = 2,
                    Name = "admin",
                    Password = "admin"
                },
                new User
                {
                    Id = 3,
                    Name = "Grant",
                    Password = "gillovespoo"
                },
                new User
                {
                    Id = 4,
                    Name = "Matt",
                    Password = "gillovespoo"
                },
                new User
                {
                    Id = 5,
                    Name = "Carolyn",
                    Password = "gillovespoo"
                },
                new User
                {
                    Id = 6,
                    Name = "Greg",
                    Password = "gillovespoo"
                },
                new User
                {
                    Id = 7,
                    Name = "Quinn",
                    Password = "gillovespoo"
                }
            );

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Id = 1,
                    Name = "Crimson Tide"
                },
                new Room
                {
                    Id = 2,
                    Name = "Tales of Terrasis"
                }
            );

            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    Id = 1,
                    Name = "Pipes",
                    Race = "Human",
                    RoomId = 2,
                    UserId = 1
                },
                new Character
                {
                    Id = 2,
                    Name = "Tormatyr",
                    Race = "Aasimar",
                    RoomId = 1,
                    UserId = 3
                },

                new Character
                {
                    Id = 3,
                    Name = "Matt's Character",
                    Race = "Human",
                    RoomId = 1,
                    UserId = 4
                },
                new Character
                {
                    Id = 4,
                    Name = "Carolyn's Character",
                    Race = "Human",
                    RoomId = 1,
                    UserId = 5
                },
                new Character
                {
                    Id = 5,
                    Name = "Quinn's Character",
                    Race = "Human",
                    RoomId = 1,
                    UserId = 7
                },
                new Character
                {
                    Id = 6,
                    Name = "Greg's Character",
                    Race = "Human",
                    RoomId = 1,
                    UserId = 6
                }
            );
        }
    }
}