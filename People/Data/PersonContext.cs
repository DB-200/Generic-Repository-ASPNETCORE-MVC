using Microsoft.EntityFrameworkCore;
using People.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.Data
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    Firstname = "Fred",
                    Lastname = "Smith",
                    ContactNo = "98888232736",
                    Id = 1
                },
                new Person
                {
                    Firstname = "Sam",
                    Lastname = "Tomato",
                    ContactNo = "43888232736",
                    Id = 2
                },
                new Person
                {
                    Firstname = "Laura",
                    Lastname = "Pizza",
                    ContactNo = "436688232736",
                    Id = 3
                },
                new Person
                {
                    Firstname = "Bob",
                    Lastname = "Bob-bob",
                    ContactNo = "938888232736",
                    Id = 4
                },
                new Person
                {
                    Firstname = "Emily",
                    Lastname = "Jones",
                    ContactNo = "12148888232736",
                    Id = 5
                },
                new Person
                {
                    Firstname = "Walter",
                    Lastname = "Cabbage",
                    ContactNo = "76888232736",
                    Id = 6
                },
                new Person
                {
                    Firstname = "Lisa",
                    Lastname = "Bean",
                    ContactNo = "32888232736",
                    Id = 7
                },
                new Person
                {
                    Firstname = "Simon",
                    Lastname = "Steak",
                    ContactNo = "4888232736",
                    Id = 8
                }

                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
