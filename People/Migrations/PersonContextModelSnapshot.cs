﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using People.Data;

namespace People.Migrations
{
    [DbContext(typeof(PersonContext))]
    partial class PersonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("People.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactNo = "98888232736",
                            Firstname = "Fred",
                            Lastname = "Smith"
                        },
                        new
                        {
                            Id = 2,
                            ContactNo = "43888232736",
                            Firstname = "Sam",
                            Lastname = "Tomato"
                        },
                        new
                        {
                            Id = 3,
                            ContactNo = "436688232736",
                            Firstname = "Laura",
                            Lastname = "Pizza"
                        },
                        new
                        {
                            Id = 4,
                            ContactNo = "938888232736",
                            Firstname = "Bob",
                            Lastname = "Bob-bob"
                        },
                        new
                        {
                            Id = 5,
                            ContactNo = "12148888232736",
                            Firstname = "Emily",
                            Lastname = "Jones"
                        },
                        new
                        {
                            Id = 6,
                            ContactNo = "76888232736",
                            Firstname = "Walter",
                            Lastname = "Cabbage"
                        },
                        new
                        {
                            Id = 7,
                            ContactNo = "32888232736",
                            Firstname = "Lisa",
                            Lastname = "Bean"
                        },
                        new
                        {
                            Id = 8,
                            ContactNo = "4888232736",
                            Firstname = "Simon",
                            Lastname = "Steak"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
