﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using vega.Persistence;

namespace vega.Migrations
{
    [DbContext(typeof(VegaDbContext))]
    [Migration("20171225072043_AddImageUrl")]
    partial class AddImageUrl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("vega.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("vega.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .HasMaxLength(255);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("vega.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("OrderDate");

                    b.Property<decimal>("TotalPrice");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("vega.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("Quantity");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("vega.Models.Order", b =>
                {
                    b.HasOne("vega.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("vega.Models.Product", b =>
                {
                    b.HasOne("vega.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
