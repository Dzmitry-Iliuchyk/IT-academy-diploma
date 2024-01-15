﻿// <auto-generated />
using System;
using HW_cookie_autentification.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HW_cookie_autentification.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20230603074056_Add propertyname")]
    partial class Addpropertyname
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.16");

            modelBuilder.Entity("HW_cookie_autentification.Models.ShopModels.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Create")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modify")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Create = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1358),
                            Modify = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1360),
                            Name = "Pavel"
                        },
                        new
                        {
                            Id = 2,
                            Create = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1364),
                            Modify = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1366),
                            Name = "Vitaliy"
                        },
                        new
                        {
                            Id = 3,
                            Create = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1369),
                            Modify = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1370),
                            Name = "Dmitry"
                        });
                });

            modelBuilder.Entity("HW_cookie_autentification.Models.ShopModels.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ClientId");

                    b.Property<DateTime>("Create")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modify")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 1,
                            Create = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1442),
                            Modify = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1445),
                            Name = "Order 1"
                        },
                        new
                        {
                            Id = 2,
                            ClientId = 2,
                            Create = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1451),
                            Modify = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1452),
                            Name = "Order 2"
                        },
                        new
                        {
                            Id = 3,
                            ClientId = 2,
                            Create = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1455),
                            Modify = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1457),
                            Name = "Order 3"
                        });
                });

            modelBuilder.Entity("HW_cookie_autentification.Models.ShopModels.OrderProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Create")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modify")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("HW_cookie_autentification.Models.ShopModels.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Create")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modify")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Create = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1406),
                            Modify = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1409),
                            Name = "Oil",
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Create = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1414),
                            Modify = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1416),
                            Name = "Butter",
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Create = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1418),
                            Modify = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1420),
                            Name = "Bread",
                            ProductTypeId = 2
                        });
                });

            modelBuilder.Entity("HW_cookie_autentification.Models.ShopModels.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Create")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modify")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Create = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1165),
                            Modify = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1214),
                            Name = "Oils"
                        },
                        new
                        {
                            Id = 2,
                            Create = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1227),
                            Modify = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1229),
                            Name = "Eats"
                        },
                        new
                        {
                            Id = 3,
                            Create = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1231),
                            Modify = new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1233),
                            Name = "Water"
                        });
                });

            modelBuilder.Entity("HW_cookie_autentification.Models.ShopModels.Order", b =>
                {
                    b.HasOne("HW_cookie_autentification.Models.ShopModels.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("HW_cookie_autentification.Models.ShopModels.OrderProduct", b =>
                {
                    b.HasOne("HW_cookie_autentification.Models.ShopModels.Order", "Order")
                        .WithMany("OrderProduct")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HW_cookie_autentification.Models.ShopModels.Product", "Product")
                        .WithMany("OrderProduct")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("HW_cookie_autentification.Models.ShopModels.Product", b =>
                {
                    b.HasOne("HW_cookie_autentification.Models.ShopModels.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("HW_cookie_autentification.Models.ShopModels.Client", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("HW_cookie_autentification.Models.ShopModels.Order", b =>
                {
                    b.Navigation("OrderProduct");
                });

            modelBuilder.Entity("HW_cookie_autentification.Models.ShopModels.Product", b =>
                {
                    b.Navigation("OrderProduct");
                });

            modelBuilder.Entity("HW_cookie_autentification.Models.ShopModels.ProductType", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}