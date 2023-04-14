﻿// <auto-generated />
using System;
using EmployeeManagement.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManagement.Context.Migrations
{
    [DbContext(typeof(EmployeeDBContext))]
    partial class EmployeeDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeManagement.Models.Address", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EMPID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HouseNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PinCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VillageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Department", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CREATEDBY")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CREATEDON")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ISACTIVE")
                        .HasColumnType("bit");

                    b.Property<string>("NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UPDATEDBY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATEDON")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EmployeeManagement.Models.EmpSalary", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CREATEDBY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CREATEDON")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EMPID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("EMPTYPE")
                        .HasColumnType("bit");

                    b.Property<Guid?>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ISACTIVE")
                        .HasColumnType("bit");

                    b.Property<double>("SALARY")
                        .HasColumnType("float");

                    b.Property<string>("UPDATEDBY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATEDON")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("EmpSalaries");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CREATEDBY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CREATEDON")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DATEOFBIRTH")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GENDER")
                        .HasColumnType("bit");

                    b.Property<bool>("ISACTIVE")
                        .HasColumnType("bit");

                    b.Property<bool>("MARITALSTATUS")
                        .HasColumnType("bit");

                    b.Property<string>("MOBILE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UPDATEDBY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATEDON")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeManagement.Models.EmpSalary", b =>
                {
                    b.HasOne("EmployeeManagement.Models.Employee", "Employee")
                        .WithMany("EmpSalaries")
                        .HasForeignKey("EmployeeID");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.Navigation("EmpSalaries");
                });
#pragma warning restore 612, 618
        }
    }
}
