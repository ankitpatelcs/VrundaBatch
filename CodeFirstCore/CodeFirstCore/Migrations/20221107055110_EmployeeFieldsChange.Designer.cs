﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppCore.Models;

#nullable disable

namespace CodeFirstCore.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20221107055110_EmployeeFieldsChange")]
    partial class EmployeeFieldsChange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebAppCore.Models.tblcity", b =>
                {
                    b.Property<int>("city_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("city_id"), 1L, 1);

                    b.Property<string>("city_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("city_id");

                    b.ToTable("tblcities");
                });

            modelBuilder.Entity("WebAppCore.Models.tblemployee", b =>
                {
                    b.Property<int>("emp_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("emp_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("emp_id"), 1L, 1);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("address");

                    b.Property<int?>("city_id")
                        .HasColumnType("int")
                        .HasColumnName("city_id");

                    b.Property<DateTime?>("dob")
                        .HasColumnType("datetime2")
                        .HasColumnName("dob");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("f_name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("f_name");

                    b.Property<string>("mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("mobile");

                    b.Property<int>("salary")
                        .HasColumnType("int")
                        .HasColumnName("salary");

                    b.HasKey("emp_id");

                    b.ToTable("tblemployee");
                });
#pragma warning restore 612, 618
        }
    }
}
