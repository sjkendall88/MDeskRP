﻿// <auto-generated />
using System;
using MDeskRP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MDeskRP.Migrations
{
    [DbContext(typeof(MDeskRPContext))]
    [Migration("20191109045815_Fix-it2")]
    partial class Fixit2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MDeskRP.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(24)")
                        .HasMaxLength(24);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(24)")
                        .HasMaxLength(24);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("MDeskRP.Models.DeskQuote", b =>
                {
                    b.Property<int>("DeskQuoteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("DeskSpecsID")
                        .HasColumnType("int");

                    b.HasKey("DeskQuoteID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("DeskSpecsID");

                    b.ToTable("DeskQuote");
                });

            modelBuilder.Entity("MDeskRP.Models.DeskSpecs", b =>
                {
                    b.Property<int>("DeskSpecsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Depth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeskTypeDescriptionDeskTypeString")
                        .HasColumnType("int");

                    b.Property<int>("DeskTypeString")
                        .HasColumnType("int");

                    b.Property<string>("NumOfDrawers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RushDays")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Width")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeskSpecsID");

                    b.HasIndex("DeskTypeDescriptionDeskTypeString");

                    b.ToTable("DeskSpecs");
                });

            modelBuilder.Entity("MDeskRP.Models.DeskTypeDescription", b =>
                {
                    b.Property<int>("DeskTypeString")
                        .HasColumnType("int");

                    b.Property<string>("DeskType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeskTypeString");

                    b.ToTable("DeskTypeDescription");
                });

            modelBuilder.Entity("MDeskRP.Models.DeskQuote", b =>
                {
                    b.HasOne("MDeskRP.Models.Customer", "Customer")
                        .WithMany("DeskQuotes")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MDeskRP.Models.DeskSpecs", "DeskSpecs")
                        .WithMany("DeskQuotes")
                        .HasForeignKey("DeskSpecsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MDeskRP.Models.DeskSpecs", b =>
                {
                    b.HasOne("MDeskRP.Models.DeskTypeDescription", "DeskTypeDescription")
                        .WithMany("DeskQuote")
                        .HasForeignKey("DeskTypeDescriptionDeskTypeString");
                });
#pragma warning restore 612, 618
        }
    }
}
