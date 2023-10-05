﻿// <auto-generated />
using System;
using EmployeeCRUD.DbCon;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeCRUD.Migrations
{
    [DbContext(typeof(DbConContext))]
    [Migration("20231005081517_BoolDeteted")]
    partial class BoolDeteted
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeCRUD.Models.TblEmpAttendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("AttendanceDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("EmployeeeId")
                        .HasColumnType("int");

                    b.Property<int>("IsAbsent")
                        .HasColumnType("int");

                    b.Property<int>("IsOffday")
                        .HasColumnType("int");

                    b.Property<int>("IsPreset")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TblEmpAttendances");
                });

            modelBuilder.Entity("EmployeeCRUD.Models.TblEmplyee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("EmployeeCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeSalary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupervisorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("TblEmplyees");
                });
#pragma warning restore 612, 618
        }
    }
}
