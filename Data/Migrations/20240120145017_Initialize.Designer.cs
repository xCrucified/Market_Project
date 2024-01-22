﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using data_access.Data;

#nullable disable

namespace data_access.Migrations
{
    [DbContext(typeof(MarketDbContext))]
    [Migration("20240120145017_Initialize")]
    partial class Initialize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("data_access.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Travel",
                            Description = "Not exist",
                            Discount = 10,
                            ImageUrl = "",
                            InStock = true,
                            Name = "Ticket",
                            Price = 650m
                        },
                        new
                        {
                            Id = 2,
                            Category = "Electronics",
                            Description = "High-performance device",
                            Discount = 5,
                            ImageUrl = "",
                            InStock = true,
                            Name = "Smartphone",
                            Price = 899m
                        },
                        new
                        {
                            Id = 3,
                            Category = "Sports",
                            Description = "Comfortable and durable",
                            Discount = 15,
                            ImageUrl = "",
                            InStock = true,
                            Name = "Running Shoes",
                            Price = 79m
                        },
                        new
                        {
                            Id = 4,
                            Category = "Electronics",
                            Description = "Powerful and lightweight",
                            Discount = 12,
                            ImageUrl = "",
                            InStock = true,
                            Name = "Laptop",
                            Price = 1299m
                        },
                        new
                        {
                            Id = 5,
                            Category = "Home and Kitchen",
                            Description = "Non-stick and easy to clean",
                            Discount = 8,
                            ImageUrl = "",
                            InStock = true,
                            Name = "Cookware Set",
                            Price = 149m
                        },
                        new
                        {
                            Id = 6,
                            Category = "Electronics",
                            Description = "High-resolution images",
                            Discount = 20,
                            ImageUrl = "",
                            InStock = true,
                            Name = "Camera",
                            Price = 599m
                        },
                        new
                        {
                            Id = 7,
                            Category = "Sports",
                            Description = "Tracks your activity and health",
                            Discount = 10,
                            ImageUrl = "",
                            InStock = true,
                            Name = "Fitness Tracker",
                            Price = 49m
                        },
                        new
                        {
                            Id = 8,
                            Category = "Electronics",
                            Description = "Noise-canceling and comfortable",
                            Discount = 15,
                            ImageUrl = "",
                            InStock = true,
                            Name = "Headphones",
                            Price = 129m
                        },
                        new
                        {
                            Id = 9,
                            Category = "Fashion",
                            Description = "Stylish and spacious",
                            Discount = 8,
                            ImageUrl = "",
                            InStock = true,
                            Name = "Backpack",
                            Price = 39m
                        },
                        new
                        {
                            Id = 10,
                            Category = "Electronics",
                            Description = "Immersive gaming experience",
                            Discount = 10,
                            ImageUrl = "",
                            InStock = true,
                            Name = "Gaming Console",
                            Price = 299m
                        },
                        new
                        {
                            Id = 11,
                            Category = "Home and Kitchen",
                            Description = "Brews delicious coffee",
                            Discount = 10,
                            ImageUrl = "",
                            InStock = true,
                            Name = "Coffee Maker",
                            Price = 79m
                        },
                        new
                        {
                            Id = 12,
                            Category = "Camping",
                            Description = "Weather-resistant and easy to set up",
                            Discount = 15,
                            ImageUrl = "",
                            InStock = true,
                            Name = "Outdoor Tent",
                            Price = 199m
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

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
#pragma warning restore 612, 618
        }
    }
}