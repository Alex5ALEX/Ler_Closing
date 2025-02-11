﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WarehouseClosingServer.Data;

#nullable disable

namespace WarehouseClosingServer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241109132455_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("WarehouseClosingServer.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WarehouseClosingServer.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WarehouseClosingServer.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Id_Customer")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Id_Employee")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WarehouseClosingServer.Models.OrderCompaund", b =>
                {
                    b.Property<Guid>("Id_Order")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0);

                    b.Property<Guid>("Id_Product")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(1);

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id_Order", "Id_Product");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderCompaunds");
                });

            modelBuilder.Entity("WarehouseClosingServer.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WarehouseClosingServer.Models.Provider", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("WarehouseClosingServer.Models.Supply", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("Id_Provider")
                        .HasColumnType("char(36)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<Guid?>("ProviderId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.ToTable("Supplies");
                });

            modelBuilder.Entity("WarehouseClosingServer.Models.SupplyCompaund", b =>
                {
                    b.Property<Guid>("Id_Supply")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Id_Product")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid?>("SupplyId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id_Supply", "Id_Product");

                    b.HasIndex("ProductId");

                    b.HasIndex("SupplyId");

                    b.ToTable("SupplyCompaunds");
                });

            modelBuilder.Entity("WarehouseClosingServer.Models.Order", b =>
                {
                    b.HasOne("WarehouseClosingServer.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("WarehouseClosingServer.Models.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("WarehouseClosingServer.Models.OrderCompaund", b =>
                {
                    b.HasOne("WarehouseClosingServer.Models.Order", "Order")
                        .WithMany("OrderCompaunds")
                        .HasForeignKey("OrderId");

                    b.HasOne("WarehouseClosingServer.Models.Product", "Product")
                        .WithMany("OrderCompaunds")
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WarehouseClosingServer.Models.Supply", b =>
                {
                    b.HasOne("WarehouseClosingServer.Models.Provider", "Provider")
                        .WithMany("Supplies")
                        .HasForeignKey("ProviderId");

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("WarehouseClosingServer.Models.SupplyCompaund", b =>
                {
                    b.HasOne("WarehouseClosingServer.Models.Product", "Product")
                        .WithMany("SupplyCompaunds")
                        .HasForeignKey("ProductId");

                    b.HasOne("WarehouseClosingServer.Models.Supply", "Supply")
                        .WithMany("SupplyCompaunds")
                        .HasForeignKey("SupplyId");

                    b.Navigation("Product");

                    b.Navigation("Supply");
                });

            modelBuilder.Entity("WarehouseClosingServer.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WarehouseClosingServer.Models.Employee", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WarehouseClosingServer.Models.Order", b =>
                {
                    b.Navigation("OrderCompaunds");
                });

            modelBuilder.Entity("WarehouseClosingServer.Models.Product", b =>
                {
                    b.Navigation("OrderCompaunds");

                    b.Navigation("SupplyCompaunds");
                });

            modelBuilder.Entity("WarehouseClosingServer.Models.Provider", b =>
                {
                    b.Navigation("Supplies");
                });

            modelBuilder.Entity("WarehouseClosingServer.Models.Supply", b =>
                {
                    b.Navigation("SupplyCompaunds");
                });
#pragma warning restore 612, 618
        }
    }
}
