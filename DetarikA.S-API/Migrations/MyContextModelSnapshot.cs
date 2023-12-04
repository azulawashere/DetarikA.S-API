﻿// <auto-generated />
using System;
using DetarikA.S_API.Models.ContexClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DetarikA.S_API.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DetarikA.S_API.Models.Entities.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Yaratılma Tarihi");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryName = "Games",
                            CreatedDate = new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7192),
                            Description = "Veritatis dignissimos otobüs enim ullam masaya laboriosam camisi ekşili lambadaki.",
                            Status = 1
                        },
                        new
                        {
                            ID = 2,
                            CategoryName = "Shoes",
                            CreatedDate = new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7495),
                            Description = "Qui kapının nesciunt mutlu magni amet voluptas otobüs accusantium de.",
                            Status = 1
                        },
                        new
                        {
                            ID = 3,
                            CategoryName = "Movies",
                            CreatedDate = new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7589),
                            Description = "Alias şafak koşuyorlar consequatur odit aspernatur kapının molestiae anlamsız ki.",
                            Status = 1
                        },
                        new
                        {
                            ID = 4,
                            CategoryName = "Movies",
                            CreatedDate = new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7636),
                            Description = "Gazete de dışarı tv in aut olduğu öyle gülüyorum et.",
                            Status = 1
                        });
                });

            modelBuilder.Entity("DetarikA.S_API.Models.Entities.Dealer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Yaratılma Tarihi");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShippingAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Dealers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CompanyName = "AlfaTeam",
                            CreatedDate = new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7986),
                            ShippingAdress = "Istanbul Tahtakale Merkezzz",
                            Status = 1
                        });
                });

            modelBuilder.Entity("DetarikA.S_API.Models.Entities.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Yaratılma Tarihi");

                    b.Property<int>("DealerID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("money");

                    b.HasKey("ID");

                    b.HasIndex("DealerID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DetarikA.S_API.Models.Entities.OrderDetail", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Yaratılma Tarihi");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("DetarikA.S_API.Models.Entities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Yaratılma Tarihi");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("money");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            CreatedDate = new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7714),
                            ProductName = "Awesome Granite Gloves",
                            Status = 1,
                            UnitPrice = 689.83m
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = 2,
                            CreatedDate = new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7859),
                            ProductName = "Licensed Concrete Ball",
                            Status = 1,
                            UnitPrice = 608.94m
                        },
                        new
                        {
                            ID = 3,
                            CategoryID = 3,
                            CreatedDate = new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7885),
                            ProductName = "Sleek Rubber Ball",
                            Status = 1,
                            UnitPrice = 539.66m
                        },
                        new
                        {
                            ID = 4,
                            CategoryID = 4,
                            CreatedDate = new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7909),
                            ProductName = "Handcrafted Granite Bike",
                            Status = 1,
                            UnitPrice = 472.02m
                        });
                });

            modelBuilder.Entity("DetarikA.S_API.Models.Entities.Order", b =>
                {
                    b.HasOne("DetarikA.S_API.Models.Entities.Dealer", "Dealer")
                        .WithMany("Orders")
                        .HasForeignKey("DealerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dealer");
                });

            modelBuilder.Entity("DetarikA.S_API.Models.Entities.OrderDetail", b =>
                {
                    b.HasOne("DetarikA.S_API.Models.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DetarikA.S_API.Models.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DetarikA.S_API.Models.Entities.Product", b =>
                {
                    b.HasOne("DetarikA.S_API.Models.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DetarikA.S_API.Models.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DetarikA.S_API.Models.Entities.Dealer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DetarikA.S_API.Models.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("DetarikA.S_API.Models.Entities.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
