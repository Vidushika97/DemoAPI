﻿// <auto-generated />
using DemoAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DemoAPI.Models.StudentModel", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("address")
                        .HasColumnType("int");

                    b.Property<int>("contact_number")
                        .HasColumnType("int");

                    b.Property<int>("email")
                        .HasColumnType("int");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("student");
                });
#pragma warning restore 612, 618
        }
    }
}
