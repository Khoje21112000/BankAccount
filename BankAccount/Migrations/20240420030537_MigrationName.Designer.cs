﻿// <auto-generated />
using BankAccount.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BankAccount.Migrations
{
    [DbContext(typeof(BankDbContext))]
    [Migration("20240420030537_MigrationName")]
    partial class MigrationName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BankAccount.Models.BankAccountModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("BankAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("BankAccount");
                });
#pragma warning restore 612, 618
        }
    }
}
