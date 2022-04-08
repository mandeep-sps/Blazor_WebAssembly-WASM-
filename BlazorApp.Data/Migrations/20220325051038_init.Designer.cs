﻿// <auto-generated />
using System;
using BlazorApp.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp.Data.Migrations
{
    [DbContext(typeof(BlazorDBContext))]
    [Migration("20220325051038_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorApp.Data.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<int>("DomainId")
                        .HasColumnType("int");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Theme")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DomainId");

                    b.ToTable("ApplicationUser", (string)null);
                });

            modelBuilder.Entity("BlazorApp.Data.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<int?>("DomainId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("DomainId");

                    b.ToTable("Department", (string)null);
                });

            modelBuilder.Entity("BlazorApp.Data.Models.DepartmentRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("RoleId");

                    b.ToTable("DepartmentRole", (string)null);
                });

            modelBuilder.Entity("BlazorApp.Data.Models.Domain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Domain", (string)null);
                });

            modelBuilder.Entity("BlazorApp.Data.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Doj")
                        .HasColumnType("date")
                        .HasColumnName("DOJ");

                    b.Property<int>("DomainId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EmployeeCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DomainId");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("BlazorApp.Data.Models.EmployeeTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TaskId");

                    b.ToTable("EmployeeTask", (string)null);
                });

            modelBuilder.Entity("BlazorApp.Data.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<int>("DomainId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DomainId");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("BlazorApp.Data.Models.Tasks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.Property<int>("DomainId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DomainId");

                    b.ToTable("Tasks", (string)null);
                });

            modelBuilder.Entity("BlazorApp.Data.Models.TasksStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TasksStatus", (string)null);
                });

            modelBuilder.Entity("BlazorApp.Data.Models.ApplicationUser", b =>
                {
                    b.HasOne("BlazorApp.Data.Models.Domain", "Domain")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("DomainId")
                        .IsRequired()
                        .HasConstraintName("FK__Applicati__Domai__440B1D61");

                    b.Navigation("Domain");
                });

            modelBuilder.Entity("BlazorApp.Data.Models.Department", b =>
                {
                    b.HasOne("BlazorApp.Data.Models.Domain", "Domain")
                        .WithMany("Departments")
                        .HasForeignKey("DomainId")
                        .HasConstraintName("FK__Departmen__Domai__33D4B598");

                    b.Navigation("Domain");
                });

            modelBuilder.Entity("BlazorApp.Data.Models.DepartmentRole", b =>
                {
                    b.HasOne("BlazorApp.Data.Models.Department", "Department")
                        .WithMany("DepartmentRoles")
                        .HasForeignKey("DepartmentId")
                        .IsRequired()
                        .HasConstraintName("FK__Departmen__Depar__3C69FB99");

                    b.HasOne("BlazorApp.Data.Models.Role", "Role")
                        .WithMany("DepartmentRoles")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK__Departmen__RoleI__3D5E1FD2");

                    b.Navigation("Department");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BlazorApp.Data.Models.Employee", b =>
                {
                    b.HasOne("BlazorApp.Data.Models.Domain", "Domain")
                        .WithMany("Employees")
                        .HasForeignKey("DomainId")
                        .IsRequired()
                        .HasConstraintName("FK__Employee__Domain__4316F928");

                    b.HasOne("BlazorApp.Data.Models.ApplicationUser", "IdNavigation")
                        .WithOne("Employee")
                        .HasForeignKey("BlazorApp.Data.Models.Employee", "Id")
                        .IsRequired()
                        .HasConstraintName("FK__Employee__Id__4222D4EF");

                    b.Navigation("Domain");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("BlazorApp.Data.Models.EmployeeTask", b =>
                {
                    b.HasOne("BlazorApp.Data.Models.Employee", "Employee")
                        .WithMany("EmployeeTasks")
                        .HasForeignKey("EmployeeId")
                        .IsRequired()
                        .HasConstraintName("FK__EmployeeT__Emplo__52593CB8");

                    b.HasOne("BlazorApp.Data.Models.Tasks", "Task")
                        .WithMany("EmployeeTasks")
                        .HasForeignKey("TaskId")
                        .IsRequired()
                        .HasConstraintName("FK__EmployeeT__TaskI__534D60F1");

                    b.Navigation("Employee");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("BlazorApp.Data.Models.Role", b =>
                {
                    b.HasOne("BlazorApp.Data.Models.Domain", "Domain")
                        .WithMany("Roles")
                        .HasForeignKey("DomainId")
                        .IsRequired()
                        .HasConstraintName("FK__Role__DomainId__38996AB5");

                    b.Navigation("Domain");
                });

            modelBuilder.Entity("BlazorApp.Data.Models.Tasks", b =>
                {
                    b.HasOne("BlazorApp.Data.Models.Domain", "Domain")
                        .WithMany("Tasks")
                        .HasForeignKey("DomainId")
                        .IsRequired()
                        .HasConstraintName("FK_Task_Domain");

                    b.Navigation("Domain");
                });

            modelBuilder.Entity("BlazorApp.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("Employee")
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorApp.Data.Models.Department", b =>
                {
                    b.Navigation("DepartmentRoles");
                });

            modelBuilder.Entity("BlazorApp.Data.Models.Domain", b =>
                {
                    b.Navigation("ApplicationUsers");

                    b.Navigation("Departments");

                    b.Navigation("Employees");

                    b.Navigation("Roles");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("BlazorApp.Data.Models.Employee", b =>
                {
                    b.Navigation("EmployeeTasks");
                });

            modelBuilder.Entity("BlazorApp.Data.Models.Role", b =>
                {
                    b.Navigation("DepartmentRoles");
                });

            modelBuilder.Entity("BlazorApp.Data.Models.Tasks", b =>
                {
                    b.Navigation("EmployeeTasks");
                });
#pragma warning restore 612, 618
        }
    }
}
