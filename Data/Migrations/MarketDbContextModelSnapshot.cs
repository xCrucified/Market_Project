﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using data_access.Data;

#nullable disable

namespace data_access.Migrations
{
    [DbContext(typeof(MarketDbContext))]
    partial class MarketDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("data_access.Data.Entities.Attributes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("isNew")
                        .HasColumnType("bit");

                    b.Property<bool?>("wasUsed")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Attributes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Model = "Audi",
                            isNew = true,
                            wasUsed = false
                        },
                        new
                        {
                            Id = 2
                        },
                        new
                        {
                            Id = 3,
                            Model = "Jordan",
                            isNew = false,
                            wasUsed = true
                        });
                });

            modelBuilder.Entity("data_access.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fashion"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Home & Garden"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Transport"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Toys & Hobbies"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Musical Instruments"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Art"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("data_access.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(9);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Not exist",
                            Discount = 10,
                            ImageUrl = "https://th.bing.com/th/id/OIP.f41ft8r1DGylDfCVbQXJTQAAAA?rs=1&pid=ImgDetMain",
                            InStock = true,
                            Name = "Ticket",
                            Price = 650m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "High-performance device",
                            Discount = 5,
                            ImageUrl = "https://th.bing.com/th/id/OIP.6OI-0NfjMZtcYKH8VulQjgHaFe?rs=1&pid=ImgDetMain",
                            InStock = true,
                            Name = "Smartphone",
                            Price = 899m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Comfortable and durable",
                            ImageUrl = "https://th.bing.com/th/id/OIP.mgap1fs9rd1GOuf4S4KQTwHaEE?rs=1&pid=ImgDetMain",
                            InStock = true,
                            Name = "Running Shoes",
                            Price = 79m
                        });
                });

            modelBuilder.Entity("data_access.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Registration")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Balance = 1000.50m,
                            Email = "john.doe@example.com",
                            Name = "John Doe",
                            Password = "password123",
                            Registration = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "john_doe"
                        },
                        new
                        {
                            Id = 2,
                            Balance = 750.25m,
                            Email = "jane.smith@example.com",
                            Name = "Jane Smith",
                            Password = "securepass",
                            Registration = new DateTime(2000, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "jane_smith"
                        },
                        new
                        {
                            Id = 3,
                            Balance = 1200.75m,
                            Email = "michael.johnson@example.com",
                            Name = "Michael Johnson",
                            Password = "pass123",
                            Registration = new DateTime(2000, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "michael_j"
                        },
                        new
                        {
                            Id = 4,
                            Balance = 850.30m,
                            Email = "emily.brown@example.com",
                            Name = "Emily Brown",
                            Password = "strongpass",
                            Registration = new DateTime(2000, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "emily_b"
                        });
                });

            modelBuilder.Entity("data_access.Data.Entities.Product", b =>
                {
                    b.HasOne("data_access.Data.Entities.Category", "Categories")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("data_access.Data.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
