// <auto-generated />
using System;
using InvetoryFull.Infrastructure.Data.Persistence.Core.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InvetoryFull.Infrastructure.Data.Persistence.Core.Migrations
{
    [DbContext(typeof(ContextDb))]
    [Migration("20210320171401_first-commit")]
    partial class firstcommit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InventoryFull.Domain.Core.Inventory.Category.CategoryEntity", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("InventoryFull.Domain.Core.Inventory.InputOutput.InputOutputEntity", b =>
                {
                    b.Property<string>("InOutId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("InOutDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsInput")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("StorageId")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InOutId");

                    b.HasIndex("StorageId");

                    b.ToTable("InOut");
                });

            modelBuilder.Entity("InventoryFull.Domain.Core.Inventory.Product.ProductEntity", b =>
                {
                    b.Property<string>("ProductId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("InventoryFull.Domain.Core.Inventory.Storage.StorageEntity", b =>
                {
                    b.Property<string>("StorageId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PartialQuantity")
                        .HasColumnType("int");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("WarehouseId")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StorageId");

                    b.HasIndex("ProductId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Storage");
                });

            modelBuilder.Entity("InventoryFull.Domain.Core.Inventory.Warehouse.WarehouseEntity", b =>
                {
                    b.Property<string>("WarehouseId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("WarehouseAdress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("WarehouseName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("WarehouseId");

                    b.ToTable("Warehouse");
                });

            modelBuilder.Entity("InventoryFull.Domain.Core.Inventory.InputOutput.InputOutputEntity", b =>
                {
                    b.HasOne("InventoryFull.Domain.Core.Inventory.Storage.StorageEntity", "Storage")
                        .WithMany("InputOutputs")
                        .HasForeignKey("StorageId");

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("InventoryFull.Domain.Core.Inventory.Product.ProductEntity", b =>
                {
                    b.HasOne("InventoryFull.Domain.Core.Inventory.Category.CategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("InventoryFull.Domain.Core.Inventory.Storage.StorageEntity", b =>
                {
                    b.HasOne("InventoryFull.Domain.Core.Inventory.Product.ProductEntity", "Product")
                        .WithMany("Storages")
                        .HasForeignKey("ProductId");

                    b.HasOne("InventoryFull.Domain.Core.Inventory.Warehouse.WarehouseEntity", "Warehouse")
                        .WithMany("Storages")
                        .HasForeignKey("WarehouseId");

                    b.Navigation("Product");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("InventoryFull.Domain.Core.Inventory.Category.CategoryEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("InventoryFull.Domain.Core.Inventory.Product.ProductEntity", b =>
                {
                    b.Navigation("Storages");
                });

            modelBuilder.Entity("InventoryFull.Domain.Core.Inventory.Storage.StorageEntity", b =>
                {
                    b.Navigation("InputOutputs");
                });

            modelBuilder.Entity("InventoryFull.Domain.Core.Inventory.Warehouse.WarehouseEntity", b =>
                {
                    b.Navigation("Storages");
                });
#pragma warning restore 612, 618
        }
    }
}
