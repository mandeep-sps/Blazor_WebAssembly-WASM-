﻿// <auto-generated />
using BlazorApp.Server.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp.MinimalAPI.Migrations
{
    [DbContext(typeof(BlazorDBContext))]
    [Migration("20220307102214_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorApp.Server.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<int>("Designation")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees_Blazor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Department = 2,
                            Designation = 6,
                            Email = "param@sp.com",
                            EmployeeCode = "SP-1001",
                            Name = "Paramjeet Singh"
                        },
                        new
                        {
                            Id = 2,
                            Department = 2,
                            Designation = 5,
                            Email = "mandeep@sp.com",
                            EmployeeCode = "SP-1002",
                            Name = "Mandeep Singh"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}