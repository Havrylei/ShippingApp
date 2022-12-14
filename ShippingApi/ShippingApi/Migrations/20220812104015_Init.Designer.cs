// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShippingApi.Infrastructure;

#nullable disable

namespace ShippingApi.Migrations
{
    [DbContext(typeof(ShippingDbContext))]
    [Migration("20220812104015_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShippingApi.Infrastructure.Entities.Bag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BagNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ShipmentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BagNumber")
                        .IsUnique();

                    b.ToTable("Bags");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Bag");
                });

            modelBuilder.Entity("ShippingApi.Infrastructure.Entities.Parcel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DestinationCountry")
                        .IsRequired()
                        .HasColumnType("nchar(2)");

                    b.Property<Guid>("ParcelBagId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ParcelNumber")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<decimal>("Price")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("RecipientName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Weight")
                        .HasPrecision(8, 3)
                        .HasColumnType("decimal(8,3)");

                    b.HasKey("Id");

                    b.HasIndex("ParcelBagId");

                    b.HasIndex("ParcelNumber")
                        .IsUnique();

                    b.ToTable("Parcels");
                });

            modelBuilder.Entity("ShippingApi.Infrastructure.Entities.Shipment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Airport")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FlightDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FlightNumber")
                        .IsRequired()
                        .HasColumnType("nchar(6)");

                    b.Property<string>("ShipmentNumber")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("ShipmentNumber")
                        .IsUnique();

                    b.ToTable("Shipments");
                });

            modelBuilder.Entity("ShippingApi.Infrastructure.Entities.LetterBag", b =>
                {
                    b.HasBaseType("ShippingApi.Infrastructure.Entities.Bag");

                    b.Property<int>("CountOfLetters")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("Weight")
                        .HasPrecision(8, 3)
                        .HasColumnType("decimal(8,3)");

                    b.HasIndex("ShipmentId");

                    b.HasDiscriminator().HasValue("LetterBag");
                });

            modelBuilder.Entity("ShippingApi.Infrastructure.Entities.ParcelBag", b =>
                {
                    b.HasBaseType("ShippingApi.Infrastructure.Entities.Bag");

                    b.HasIndex("ShipmentId");

                    b.HasDiscriminator().HasValue("ParcelBag");
                });

            modelBuilder.Entity("ShippingApi.Infrastructure.Entities.Parcel", b =>
                {
                    b.HasOne("ShippingApi.Infrastructure.Entities.ParcelBag", "ParcelBag")
                        .WithMany("Parcels")
                        .HasForeignKey("ParcelBagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParcelBag");
                });

            modelBuilder.Entity("ShippingApi.Infrastructure.Entities.LetterBag", b =>
                {
                    b.HasOne("ShippingApi.Infrastructure.Entities.Shipment", "Shipment")
                        .WithMany("LetterBags")
                        .HasForeignKey("ShipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shipment");
                });

            modelBuilder.Entity("ShippingApi.Infrastructure.Entities.ParcelBag", b =>
                {
                    b.HasOne("ShippingApi.Infrastructure.Entities.Shipment", "Shipment")
                        .WithMany("ParcelBags")
                        .HasForeignKey("ShipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shipment");
                });

            modelBuilder.Entity("ShippingApi.Infrastructure.Entities.Shipment", b =>
                {
                    b.Navigation("LetterBags");

                    b.Navigation("ParcelBags");
                });

            modelBuilder.Entity("ShippingApi.Infrastructure.Entities.ParcelBag", b =>
                {
                    b.Navigation("Parcels");
                });
#pragma warning restore 612, 618
        }
    }
}
