﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Produccion.App.Services.AppRepository;

namespace Produccion.App.Services.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Produccion.App.Domain.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_type_identification")
                        .HasColumnType("int");

                    b.Property<string>("identification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Produccion.App.Domain.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("code_product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("date_expiration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("date_manufacturing")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_type_product")
                        .HasColumnType("int");

                    b.Property<string>("lote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name_product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("qty_available")
                        .HasColumnType("int");

                    b.Property<int>("qty_order")
                        .HasColumnType("int");

                    b.Property<int>("qty_production")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Produccion.App.Domain.ProductionOrder", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("code_order")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("date_delivery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_status_op")
                        .HasColumnType("int");

                    b.Property<string>("mod")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ProductionOrder");
                });

            modelBuilder.Entity("Produccion.App.Domain.PurchanseOrder", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("date_delivery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_customer")
                        .HasColumnType("int");

                    b.Property<int>("id_status_oc")
                        .HasColumnType("int");

                    b.Property<string>("num_oc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("PurchanseOrder");
                });
#pragma warning restore 612, 618
        }
    }
}
