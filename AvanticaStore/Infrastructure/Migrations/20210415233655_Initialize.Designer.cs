﻿// <auto-generated />
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210415233655_Initialize")]
    partial class Initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Catalog")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "Description for product 1",
                            Name = "Product 1",
                            Price = 776m,
                            Stock = 41
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "Description for product 2",
                            Name = "Product 2",
                            Price = 991m,
                            Stock = 52
                        },
                        new
                        {
                            ProductId = 3,
                            Description = "Description for product 3",
                            Name = "Product 3",
                            Price = 595m,
                            Stock = 53
                        },
                        new
                        {
                            ProductId = 4,
                            Description = "Description for product 4",
                            Name = "Product 4",
                            Price = 962m,
                            Stock = 73
                        },
                        new
                        {
                            ProductId = 5,
                            Description = "Description for product 5",
                            Name = "Product 5",
                            Price = 556m,
                            Stock = 3
                        },
                        new
                        {
                            ProductId = 6,
                            Description = "Description for product 6",
                            Name = "Product 6",
                            Price = 265m,
                            Stock = 82
                        },
                        new
                        {
                            ProductId = 7,
                            Description = "Description for product 7",
                            Name = "Product 7",
                            Price = 193m,
                            Stock = 64
                        },
                        new
                        {
                            ProductId = 8,
                            Description = "Description for product 8",
                            Name = "Product 8",
                            Price = 899m,
                            Stock = 6
                        },
                        new
                        {
                            ProductId = 9,
                            Description = "Description for product 9",
                            Name = "Product 9",
                            Price = 179m,
                            Stock = 53
                        },
                        new
                        {
                            ProductId = 10,
                            Description = "Description for product 10",
                            Name = "Product 10",
                            Price = 308m,
                            Stock = 97
                        },
                        new
                        {
                            ProductId = 11,
                            Description = "Description for product 11",
                            Name = "Product 11",
                            Price = 344m,
                            Stock = 25
                        },
                        new
                        {
                            ProductId = 12,
                            Description = "Description for product 12",
                            Name = "Product 12",
                            Price = 275m,
                            Stock = 32
                        },
                        new
                        {
                            ProductId = 13,
                            Description = "Description for product 13",
                            Name = "Product 13",
                            Price = 496m,
                            Stock = 93
                        },
                        new
                        {
                            ProductId = 14,
                            Description = "Description for product 14",
                            Name = "Product 14",
                            Price = 777m,
                            Stock = 31
                        },
                        new
                        {
                            ProductId = 15,
                            Description = "Description for product 15",
                            Name = "Product 15",
                            Price = 589m,
                            Stock = 39
                        },
                        new
                        {
                            ProductId = 16,
                            Description = "Description for product 16",
                            Name = "Product 16",
                            Price = 678m,
                            Stock = 59
                        },
                        new
                        {
                            ProductId = 17,
                            Description = "Description for product 17",
                            Name = "Product 17",
                            Price = 292m,
                            Stock = 33
                        },
                        new
                        {
                            ProductId = 18,
                            Description = "Description for product 18",
                            Name = "Product 18",
                            Price = 171m,
                            Stock = 86
                        },
                        new
                        {
                            ProductId = 19,
                            Description = "Description for product 19",
                            Name = "Product 19",
                            Price = 201m,
                            Stock = 59
                        },
                        new
                        {
                            ProductId = 20,
                            Description = "Description for product 20",
                            Name = "Product 20",
                            Price = 812m,
                            Stock = 72
                        },
                        new
                        {
                            ProductId = 21,
                            Description = "Description for product 21",
                            Name = "Product 21",
                            Price = 700m,
                            Stock = 61
                        },
                        new
                        {
                            ProductId = 22,
                            Description = "Description for product 22",
                            Name = "Product 22",
                            Price = 356m,
                            Stock = 99
                        },
                        new
                        {
                            ProductId = 23,
                            Description = "Description for product 23",
                            Name = "Product 23",
                            Price = 624m,
                            Stock = 20
                        },
                        new
                        {
                            ProductId = 24,
                            Description = "Description for product 24",
                            Name = "Product 24",
                            Price = 655m,
                            Stock = 49
                        },
                        new
                        {
                            ProductId = 25,
                            Description = "Description for product 25",
                            Name = "Product 25",
                            Price = 792m,
                            Stock = 82
                        },
                        new
                        {
                            ProductId = 26,
                            Description = "Description for product 26",
                            Name = "Product 26",
                            Price = 727m,
                            Stock = 82
                        },
                        new
                        {
                            ProductId = 27,
                            Description = "Description for product 27",
                            Name = "Product 27",
                            Price = 674m,
                            Stock = 36
                        },
                        new
                        {
                            ProductId = 28,
                            Description = "Description for product 28",
                            Name = "Product 28",
                            Price = 128m,
                            Stock = 49
                        },
                        new
                        {
                            ProductId = 29,
                            Description = "Description for product 29",
                            Name = "Product 29",
                            Price = 302m,
                            Stock = 67
                        },
                        new
                        {
                            ProductId = 30,
                            Description = "Description for product 30",
                            Name = "Product 30",
                            Price = 172m,
                            Stock = 61
                        },
                        new
                        {
                            ProductId = 31,
                            Description = "Description for product 31",
                            Name = "Product 31",
                            Price = 802m,
                            Stock = 63
                        },
                        new
                        {
                            ProductId = 32,
                            Description = "Description for product 32",
                            Name = "Product 32",
                            Price = 270m,
                            Stock = 11
                        },
                        new
                        {
                            ProductId = 33,
                            Description = "Description for product 33",
                            Name = "Product 33",
                            Price = 456m,
                            Stock = 59
                        },
                        new
                        {
                            ProductId = 34,
                            Description = "Description for product 34",
                            Name = "Product 34",
                            Price = 653m,
                            Stock = 76
                        },
                        new
                        {
                            ProductId = 35,
                            Description = "Description for product 35",
                            Name = "Product 35",
                            Price = 608m,
                            Stock = 2
                        },
                        new
                        {
                            ProductId = 36,
                            Description = "Description for product 36",
                            Name = "Product 36",
                            Price = 959m,
                            Stock = 49
                        },
                        new
                        {
                            ProductId = 37,
                            Description = "Description for product 37",
                            Name = "Product 37",
                            Price = 773m,
                            Stock = 50
                        },
                        new
                        {
                            ProductId = 38,
                            Description = "Description for product 38",
                            Name = "Product 38",
                            Price = 380m,
                            Stock = 65
                        },
                        new
                        {
                            ProductId = 39,
                            Description = "Description for product 39",
                            Name = "Product 39",
                            Price = 977m,
                            Stock = 19
                        },
                        new
                        {
                            ProductId = 40,
                            Description = "Description for product 40",
                            Name = "Product 40",
                            Price = 763m,
                            Stock = 23
                        },
                        new
                        {
                            ProductId = 41,
                            Description = "Description for product 41",
                            Name = "Product 41",
                            Price = 389m,
                            Stock = 26
                        },
                        new
                        {
                            ProductId = 42,
                            Description = "Description for product 42",
                            Name = "Product 42",
                            Price = 595m,
                            Stock = 72
                        },
                        new
                        {
                            ProductId = 43,
                            Description = "Description for product 43",
                            Name = "Product 43",
                            Price = 725m,
                            Stock = 81
                        },
                        new
                        {
                            ProductId = 44,
                            Description = "Description for product 44",
                            Name = "Product 44",
                            Price = 958m,
                            Stock = 85
                        },
                        new
                        {
                            ProductId = 45,
                            Description = "Description for product 45",
                            Name = "Product 45",
                            Price = 372m,
                            Stock = 58
                        },
                        new
                        {
                            ProductId = 46,
                            Description = "Description for product 46",
                            Name = "Product 46",
                            Price = 678m,
                            Stock = 44
                        },
                        new
                        {
                            ProductId = 47,
                            Description = "Description for product 47",
                            Name = "Product 47",
                            Price = 563m,
                            Stock = 17
                        },
                        new
                        {
                            ProductId = 48,
                            Description = "Description for product 48",
                            Name = "Product 48",
                            Price = 953m,
                            Stock = 2
                        },
                        new
                        {
                            ProductId = 49,
                            Description = "Description for product 49",
                            Name = "Product 49",
                            Price = 481m,
                            Stock = 16
                        },
                        new
                        {
                            ProductId = 50,
                            Description = "Description for product 50",
                            Name = "Product 50",
                            Price = 639m,
                            Stock = 99
                        },
                        new
                        {
                            ProductId = 51,
                            Description = "Description for product 51",
                            Name = "Product 51",
                            Price = 627m,
                            Stock = 84
                        },
                        new
                        {
                            ProductId = 52,
                            Description = "Description for product 52",
                            Name = "Product 52",
                            Price = 934m,
                            Stock = 74
                        },
                        new
                        {
                            ProductId = 53,
                            Description = "Description for product 53",
                            Name = "Product 53",
                            Price = 881m,
                            Stock = 20
                        },
                        new
                        {
                            ProductId = 54,
                            Description = "Description for product 54",
                            Name = "Product 54",
                            Price = 167m,
                            Stock = 13
                        },
                        new
                        {
                            ProductId = 55,
                            Description = "Description for product 55",
                            Name = "Product 55",
                            Price = 146m,
                            Stock = 37
                        },
                        new
                        {
                            ProductId = 56,
                            Description = "Description for product 56",
                            Name = "Product 56",
                            Price = 565m,
                            Stock = 2
                        },
                        new
                        {
                            ProductId = 57,
                            Description = "Description for product 57",
                            Name = "Product 57",
                            Price = 940m,
                            Stock = 84
                        },
                        new
                        {
                            ProductId = 58,
                            Description = "Description for product 58",
                            Name = "Product 58",
                            Price = 360m,
                            Stock = 52
                        },
                        new
                        {
                            ProductId = 59,
                            Description = "Description for product 59",
                            Name = "Product 59",
                            Price = 180m,
                            Stock = 46
                        },
                        new
                        {
                            ProductId = 60,
                            Description = "Description for product 60",
                            Name = "Product 60",
                            Price = 478m,
                            Stock = 57
                        },
                        new
                        {
                            ProductId = 61,
                            Description = "Description for product 61",
                            Name = "Product 61",
                            Price = 674m,
                            Stock = 76
                        },
                        new
                        {
                            ProductId = 62,
                            Description = "Description for product 62",
                            Name = "Product 62",
                            Price = 520m,
                            Stock = 97
                        },
                        new
                        {
                            ProductId = 63,
                            Description = "Description for product 63",
                            Name = "Product 63",
                            Price = 440m,
                            Stock = 51
                        },
                        new
                        {
                            ProductId = 64,
                            Description = "Description for product 64",
                            Name = "Product 64",
                            Price = 979m,
                            Stock = 56
                        },
                        new
                        {
                            ProductId = 65,
                            Description = "Description for product 65",
                            Name = "Product 65",
                            Price = 598m,
                            Stock = 28
                        },
                        new
                        {
                            ProductId = 66,
                            Description = "Description for product 66",
                            Name = "Product 66",
                            Price = 311m,
                            Stock = 80
                        },
                        new
                        {
                            ProductId = 67,
                            Description = "Description for product 67",
                            Name = "Product 67",
                            Price = 640m,
                            Stock = 74
                        },
                        new
                        {
                            ProductId = 68,
                            Description = "Description for product 68",
                            Name = "Product 68",
                            Price = 687m,
                            Stock = 47
                        },
                        new
                        {
                            ProductId = 69,
                            Description = "Description for product 69",
                            Name = "Product 69",
                            Price = 399m,
                            Stock = 80
                        },
                        new
                        {
                            ProductId = 70,
                            Description = "Description for product 70",
                            Name = "Product 70",
                            Price = 867m,
                            Stock = 49
                        },
                        new
                        {
                            ProductId = 71,
                            Description = "Description for product 71",
                            Name = "Product 71",
                            Price = 768m,
                            Stock = 81
                        },
                        new
                        {
                            ProductId = 72,
                            Description = "Description for product 72",
                            Name = "Product 72",
                            Price = 819m,
                            Stock = 92
                        },
                        new
                        {
                            ProductId = 73,
                            Description = "Description for product 73",
                            Name = "Product 73",
                            Price = 162m,
                            Stock = 61
                        },
                        new
                        {
                            ProductId = 74,
                            Description = "Description for product 74",
                            Name = "Product 74",
                            Price = 557m,
                            Stock = 67
                        },
                        new
                        {
                            ProductId = 75,
                            Description = "Description for product 75",
                            Name = "Product 75",
                            Price = 901m,
                            Stock = 42
                        },
                        new
                        {
                            ProductId = 76,
                            Description = "Description for product 76",
                            Name = "Product 76",
                            Price = 945m,
                            Stock = 95
                        },
                        new
                        {
                            ProductId = 77,
                            Description = "Description for product 77",
                            Name = "Product 77",
                            Price = 774m,
                            Stock = 2
                        },
                        new
                        {
                            ProductId = 78,
                            Description = "Description for product 78",
                            Name = "Product 78",
                            Price = 417m,
                            Stock = 82
                        },
                        new
                        {
                            ProductId = 79,
                            Description = "Description for product 79",
                            Name = "Product 79",
                            Price = 442m,
                            Stock = 94
                        },
                        new
                        {
                            ProductId = 80,
                            Description = "Description for product 80",
                            Name = "Product 80",
                            Price = 433m,
                            Stock = 35
                        },
                        new
                        {
                            ProductId = 81,
                            Description = "Description for product 81",
                            Name = "Product 81",
                            Price = 304m,
                            Stock = 50
                        },
                        new
                        {
                            ProductId = 82,
                            Description = "Description for product 82",
                            Name = "Product 82",
                            Price = 623m,
                            Stock = 76
                        },
                        new
                        {
                            ProductId = 83,
                            Description = "Description for product 83",
                            Name = "Product 83",
                            Price = 224m,
                            Stock = 71
                        },
                        new
                        {
                            ProductId = 84,
                            Description = "Description for product 84",
                            Name = "Product 84",
                            Price = 482m,
                            Stock = 18
                        },
                        new
                        {
                            ProductId = 85,
                            Description = "Description for product 85",
                            Name = "Product 85",
                            Price = 269m,
                            Stock = 81
                        },
                        new
                        {
                            ProductId = 86,
                            Description = "Description for product 86",
                            Name = "Product 86",
                            Price = 269m,
                            Stock = 28
                        },
                        new
                        {
                            ProductId = 87,
                            Description = "Description for product 87",
                            Name = "Product 87",
                            Price = 655m,
                            Stock = 93
                        },
                        new
                        {
                            ProductId = 88,
                            Description = "Description for product 88",
                            Name = "Product 88",
                            Price = 850m,
                            Stock = 82
                        },
                        new
                        {
                            ProductId = 89,
                            Description = "Description for product 89",
                            Name = "Product 89",
                            Price = 968m,
                            Stock = 53
                        },
                        new
                        {
                            ProductId = 90,
                            Description = "Description for product 90",
                            Name = "Product 90",
                            Price = 917m,
                            Stock = 76
                        },
                        new
                        {
                            ProductId = 91,
                            Description = "Description for product 91",
                            Name = "Product 91",
                            Price = 104m,
                            Stock = 30
                        },
                        new
                        {
                            ProductId = 92,
                            Description = "Description for product 92",
                            Name = "Product 92",
                            Price = 710m,
                            Stock = 12
                        },
                        new
                        {
                            ProductId = 93,
                            Description = "Description for product 93",
                            Name = "Product 93",
                            Price = 409m,
                            Stock = 28
                        },
                        new
                        {
                            ProductId = 94,
                            Description = "Description for product 94",
                            Name = "Product 94",
                            Price = 149m,
                            Stock = 57
                        },
                        new
                        {
                            ProductId = 95,
                            Description = "Description for product 95",
                            Name = "Product 95",
                            Price = 454m,
                            Stock = 83
                        },
                        new
                        {
                            ProductId = 96,
                            Description = "Description for product 96",
                            Name = "Product 96",
                            Price = 185m,
                            Stock = 38
                        },
                        new
                        {
                            ProductId = 97,
                            Description = "Description for product 97",
                            Name = "Product 97",
                            Price = 488m,
                            Stock = 49
                        },
                        new
                        {
                            ProductId = 98,
                            Description = "Description for product 98",
                            Name = "Product 98",
                            Price = 336m,
                            Stock = 23
                        },
                        new
                        {
                            ProductId = 99,
                            Description = "Description for product 99",
                            Name = "Product 99",
                            Price = 313m,
                            Stock = 3
                        },
                        new
                        {
                            ProductId = 100,
                            Description = "Description for product 100",
                            Name = "Product 100",
                            Price = 812m,
                            Stock = 35
                        });
                });
#pragma warning restore 612, 618
        }
    }
}