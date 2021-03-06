// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Warehouse.Repository;

#nullable disable

namespace Warehouse.Repository.Migrations
{
    [DbContext(typeof(WHContext))]
    partial class WHContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("Warehouse.Repository.Entities.RoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Inactive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Warehouse.Repository.Entities.StoreEntity", b =>
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

                    b.HasKey("Id");

                    b.ToTable("Store");
                });

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

            modelBuilder.Entity("Warehouse.Repository.Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StoreId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Warehouse.Repository.Entities.UserRoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
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

            modelBuilder.Entity("Warehouse.Repository.Entities.UserEntity", b =>
                {
                    b.HasOne("Warehouse.Repository.Entities.StoreEntity", "Store")
                        .WithMany("Users")
                        .HasForeignKey("StoreId");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("Warehouse.Repository.Entities.UserRoleEntity", b =>
                {
                    b.HasOne("Warehouse.Repository.Entities.RoleEntity", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId");

                    b.HasOne("Warehouse.Repository.Entities.UserEntity", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId");

                    b.Navigation("Role");

                    b.Navigation("User");
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

            modelBuilder.Entity("Warehouse.Repository.Entities.RoleEntity", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Warehouse.Repository.Entities.StoreEntity", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Warehouse.Repository.Entities.UnitEntity", b =>
                {
                    b.Navigation("WarehouseItems");
                });

            modelBuilder.Entity("Warehouse.Repository.Entities.UserEntity", b =>
                {
                    b.Navigation("UserRoles");
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
