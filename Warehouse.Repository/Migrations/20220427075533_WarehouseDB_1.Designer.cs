﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Warehouse.Repository;

#nullable disable

namespace Warehouse.Repository.Migrations
{
    [DbContext(typeof(WHContext))]
    [Migration("20220427075533_WarehouseDB_1")]
    partial class WarehouseDB_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("Warehouse.Repository.Entities.UnitEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Inactive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UnitName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("Warehouse.Repository.Entities.VendorEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Inactive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("Warehouse.Repository.Entities.WarehouseEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Inactive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ParentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Warehouse");
                });

            modelBuilder.Entity("Warehouse.Repository.Entities.WarehouseItemCategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Inactive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ParentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WarehouseItemCategory");
                });

            modelBuilder.Entity("Warehouse.Repository.Entities.WarehouseItemEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Inactive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UnitId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("VendorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VendorName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("WarehouseItemCategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UnitId");

                    b.HasIndex("VendorId");

                    b.HasIndex("WarehouseItemCategoryId");

                    b.ToTable("WarehouseItem");
                });

            modelBuilder.Entity("Warehouse.Repository.Entities.WarehouseItemEntity", b =>
                {
                    b.HasOne("Warehouse.Repository.Entities.UnitEntity", "Unit")
                        .WithMany("WarehouseItems")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Warehouse.Repository.Entities.VendorEntity", "Vendor")
                        .WithMany("WarehouseItems")
                        .HasForeignKey("VendorId");

                    b.HasOne("Warehouse.Repository.Entities.WarehouseItemCategoryEntity", "WarehouseItemCategory")
                        .WithMany("WarehouseItems")
                        .HasForeignKey("WarehouseItemCategoryId");

                    b.Navigation("Unit");

                    b.Navigation("Vendor");

                    b.Navigation("WarehouseItemCategory");
                });

            modelBuilder.Entity("Warehouse.Repository.Entities.UnitEntity", b =>
                {
                    b.Navigation("WarehouseItems");
                });

            modelBuilder.Entity("Warehouse.Repository.Entities.VendorEntity", b =>
                {
                    b.Navigation("WarehouseItems");
                });

            modelBuilder.Entity("Warehouse.Repository.Entities.WarehouseItemCategoryEntity", b =>
                {
                    b.Navigation("WarehouseItems");
                });
#pragma warning restore 612, 618
        }
    }
}
