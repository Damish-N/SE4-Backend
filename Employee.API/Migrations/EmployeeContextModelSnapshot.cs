﻿// <auto-generated />
using Employee.DataAccessLayer.DBContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Employee.API.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Employee.DataAccessLayer.Coffee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Coffees");

                    b.HasData(
                        new
                        {
                            Id = "0741053d-9604-4add-a92b-94268e8eb5f9",
                            Description = "A strong, concentrated coffee beverage made by forcing pressurized hot water through finely ground coffee beans.",
                            Name = "Espresso",
                            Price = 300.0,
                            Rating = 4
                        },
                        new
                        {
                            Id = "fd83c36b-d7be-4b9e-b073-4c321f799dd2",
                            Description = " A coffee beverage made with espresso and steamed milk, topped with a small amount of foam. ",
                            Name = "Latte",
                            Price = 550.0,
                            Rating = 5
                        },
                        new
                        {
                            Id = "f7716028-db41-47fc-9734-bff34e6ac94b",
                            Description = "A coffee drink made with equal parts espresso, steamed milk and milk foam.",
                            Name = "Cappuccino",
                            Price = 450.0,
                            Rating = 3
                        });
                });

            modelBuilder.Entity("Employee.DataAccessLayer.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = "53227acf-81e8-4684-bcf8-0e19f47e1565",
                            Age = 50,
                            FirstName = "David",
                            LastName = "Mike"
                        },
                        new
                        {
                            Id = "2ee0c2a3-5f98-4496-88e3-ffd1c596aeb1",
                            Age = 50,
                            FirstName = "Steve",
                            LastName = "Warner"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
