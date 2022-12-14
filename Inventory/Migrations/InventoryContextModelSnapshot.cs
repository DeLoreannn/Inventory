// <auto-generated />
using System;
using Inventory.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Inventory.Migrations
{
    [DbContext(typeof(InventoryContext))]
    partial class InventoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Inventory.Domains.Entities.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsInUse")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExpirationDate = new DateTime(2031, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsInUse = false,
                            Name = "RTX 2080",
                            Price = 1500.0,
                            ReleaseDate = new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomId = 1
                        },
                        new
                        {
                            Id = 2,
                            ExpirationDate = new DateTime(2017, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsInUse = false,
                            Name = "Ball",
                            Price = 3.0,
                            ReleaseDate = new DateTime(2015, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomId = 3
                        },
                        new
                        {
                            Id = 3,
                            IsInUse = false,
                            Name = "Adidas Super Star",
                            Price = 300.0,
                            ReleaseDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomId = 2
                        },
                        new
                        {
                            Id = 4,
                            ExpirationDate = new DateTime(2040, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsInUse = false,
                            Name = "Intel i9",
                            Price = 800.0,
                            ReleaseDate = new DateTime(2019, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomId = 1
                        },
                        new
                        {
                            Id = 5,
                            ExpirationDate = new DateTime(2035, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsInUse = false,
                            Name = "Logitec G-102",
                            Price = 150.0,
                            ReleaseDate = new DateTime(2015, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomId = 1
                        });
                });

            modelBuilder.Entity("Inventory.Domains.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Computer devices"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Clothes"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sport devices"
                        });
                });

            modelBuilder.Entity("Inventory.Domains.Entities.Device", b =>
                {
                    b.HasOne("Inventory.Domains.Entities.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });
#pragma warning restore 612, 618
        }
    }
}
