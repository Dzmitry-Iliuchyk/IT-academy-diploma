﻿// <auto-generated />
using System;
using HW_cookie_autentification.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HW_cookie_autentification.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    partial class ShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.19");

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
                            Create = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(3987),
                            Modify = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(3994),
                            Name = "Pavel"
                        },
                        new
                        {
                            Id = 2,
                            Create = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4004),
                            Modify = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4009),
                            Name = "Vitaliy"
                        },
                        new
                        {
                            Id = 3,
                            Create = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4015),
                            Modify = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4020),
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
                            Create = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4154),
                            Modify = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4161),
                            Name = "Order 1"
                        },
                        new
                        {
                            Id = 2,
                            ClientId = 2,
                            Create = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4176),
                            Modify = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4181),
                            Name = "Order 2"
                        },
                        new
                        {
                            Id = 3,
                            ClientId = 2,
                            Create = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4188),
                            Modify = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4192),
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Create = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modify = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            Create = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modify = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderId = 2,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            Create = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modify = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderId = 3,
                            ProductId = 3
                        });
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
                            Create = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4071),
                            Modify = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4078),
                            Name = "Oil",
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Create = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4090),
                            Modify = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4095),
                            Name = "Butter",
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Create = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4101),
                            Modify = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4106),
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
                            Create = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(3823),
                            Modify = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(3888),
                            Name = "Oils"
                        },
                        new
                        {
                            Id = 2,
                            Create = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(3904),
                            Modify = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(3909),
                            Name = "Food"
                        },
                        new
                        {
                            Id = 3,
                            Create = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(3916),
                            Modify = new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(3921),
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
                        .WithMany("OrderProducts")
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
                    b.Navigation("OrderProducts");
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