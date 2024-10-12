﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsApi.Models;

#nullable disable

namespace ProductsApi.Migrations
{
    [DbContext(typeof(ProductsContext))]
    [Migration("20241012152831_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("ProductsApi.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            IsActive = true,
                            Price = 11000m,
                            ProductName = "IPhone 11"
                        },
                        new
                        {
                            ProductId = 2,
                            IsActive = true,
                            Price = 12000m,
                            ProductName = "IPhone 12"
                        },
                        new
                        {
                            ProductId = 3,
                            IsActive = false,
                            Price = 13000m,
                            ProductName = "IPhone 13"
                        },
                        new
                        {
                            ProductId = 4,
                            IsActive = false,
                            Price = 14000m,
                            ProductName = "IPhone 14"
                        },
                        new
                        {
                            ProductId = 5,
                            IsActive = true,
                            Price = 15000m,
                            ProductName = "IPhone 15"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
