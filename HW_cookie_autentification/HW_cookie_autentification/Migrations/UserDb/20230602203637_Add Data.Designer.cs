﻿// <auto-generated />
using HW_cookie_autentification.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HW_cookie_autentification.Migrations.UserDb
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20230602203637_Add Data")]
    partial class AddData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.16");

            modelBuilder.Entity("HW_cookie_autentification.Models.UserModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Dmitry123@mail.ru",
                            Name = "Dmitry",
                            Password = "123",
                            Role = "1"
                        },
                        new
                        {
                            Id = 2,
                            Email = "1@mail.ru",
                            Name = "DD",
                            Password = "123",
                            Role = "customer"
                        },
                        new
                        {
                            Id = 3,
                            Email = "2@mail.ru",
                            Name = "Mit",
                            Password = "123",
                            Role = "admin"
                        },
                        new
                        {
                            Id = 4,
                            Email = "3@mail.ru",
                            Name = "adsa",
                            Password = "123",
                            Role = "supervisor"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}