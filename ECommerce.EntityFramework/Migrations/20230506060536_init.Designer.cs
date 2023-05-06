﻿// <auto-generated />
using System;
using ECommerce.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerce.EntityFramework.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    [Migration("20230506060536_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ECommerce.Data.Models.LoginInfo", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatedByUserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Key")
                        .HasColumnType("longtext");

                    b.Property<int?>("LoginType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("UpdatedUserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedUserId");

                    b.HasIndex("UserId");

                    b.ToTable("LoginInfos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("531709be-09b1-42b3-95af-5bc663c7739c"),
                            CreatedAt = new DateTime(2023, 5, 6, 14, 5, 35, 980, DateTimeKind.Local).AddTicks(8314),
                            CreatedByUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            Key = "Password",
                            UpdatedAt = new DateTime(2023, 5, 6, 14, 5, 35, 980, DateTimeKind.Local).AddTicks(8330),
                            UpdatedUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            UserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            Value = "$2a$10$Mjaf3iexE0kcKC3gdeEwG.n8z0mKzZw3mzTDGwx5BJEEcRpSFZT9a"
                        },
                        new
                        {
                            Id = new Guid("efd1d492-6068-4d2d-a06a-a1a54ce875e6"),
                            CreatedAt = new DateTime(2023, 5, 6, 14, 5, 35, 980, DateTimeKind.Local).AddTicks(8420),
                            CreatedByUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            Key = "LoginRetries",
                            UpdatedAt = new DateTime(2023, 5, 6, 14, 5, 35, 980, DateTimeKind.Local).AddTicks(8421),
                            UpdatedUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            UserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            Value = "0"
                        },
                        new
                        {
                            Id = new Guid("2a2e3066-ea8b-4ecb-8dfc-beb3561db018"),
                            CreatedAt = new DateTime(2023, 5, 6, 14, 5, 35, 980, DateTimeKind.Local).AddTicks(8446),
                            CreatedByUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            Key = "AccountStatus",
                            UpdatedAt = new DateTime(2023, 5, 6, 14, 5, 35, 980, DateTimeKind.Local).AddTicks(8447),
                            UpdatedUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            UserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            Value = "Active"
                        },
                        new
                        {
                            Id = new Guid("734982df-979c-478f-9312-6a259c4aa0f7"),
                            CreatedAt = new DateTime(2023, 5, 6, 14, 5, 36, 34, DateTimeKind.Local).AddTicks(3165),
                            CreatedByUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            Key = "Password",
                            UpdatedAt = new DateTime(2023, 5, 6, 14, 5, 36, 34, DateTimeKind.Local).AddTicks(3176),
                            UpdatedUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            UserId = new Guid("777eab55-31b1-494a-b804-078b8eccc000"),
                            Value = "$2a$10$CVRWc.XZ/x7t9nmH.3lrjejnSru0AHbyDDGdvIN06PNa.za8quLP."
                        },
                        new
                        {
                            Id = new Guid("be7a6499-e8c1-4d15-91b5-2c4b169b9a52"),
                            CreatedAt = new DateTime(2023, 5, 6, 14, 5, 36, 34, DateTimeKind.Local).AddTicks(3201),
                            CreatedByUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            Key = "LoginRetries",
                            UpdatedAt = new DateTime(2023, 5, 6, 14, 5, 36, 34, DateTimeKind.Local).AddTicks(3201),
                            UpdatedUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            UserId = new Guid("777eab55-31b1-494a-b804-078b8eccc000"),
                            Value = "0"
                        },
                        new
                        {
                            Id = new Guid("06e6da25-fe43-492f-adf9-6315be3828ff"),
                            CreatedAt = new DateTime(2023, 5, 6, 14, 5, 36, 34, DateTimeKind.Local).AddTicks(3220),
                            CreatedByUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            Key = "AccountStatus",
                            UpdatedAt = new DateTime(2023, 5, 6, 14, 5, 36, 34, DateTimeKind.Local).AddTicks(3222),
                            UpdatedUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            UserId = new Guid("777eab55-31b1-494a-b804-078b8eccc000"),
                            Value = "Active"
                        });
                });

            modelBuilder.Entity("ECommerce.Data.Models.Others.Car", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatedByUserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Make")
                        .HasColumnType("longtext");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("UpdatedUserId")
                        .HasColumnType("char(36)");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = new Guid("742acd91-f526-47bf-b862-0e2e018b0680"),
                            CreatedAt = new DateTime(2023, 5, 6, 14, 5, 36, 34, DateTimeKind.Local).AddTicks(3238),
                            CreatedByUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            Make = "Xpander Cross",
                            Manufacturer = "Mitsubishi",
                            UpdatedAt = new DateTime(2023, 5, 6, 14, 5, 36, 34, DateTimeKind.Local).AddTicks(3239),
                            UpdatedUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            Year = 2023
                        });
                });

            modelBuilder.Entity("ECommerce.Data.Models.User", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatedByUserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("UpdatedUserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            CreatedAt = new DateTime(2023, 5, 6, 14, 5, 35, 927, DateTimeKind.Local).AddTicks(1271),
                            CreatedByUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            EmailAddress = "admecom@mailinator.com",
                            FirstName = "Jace",
                            LastName = "Beleren",
                            UpdatedAt = new DateTime(2023, 5, 6, 14, 5, 35, 927, DateTimeKind.Local).AddTicks(1272),
                            UpdatedUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000")
                        },
                        new
                        {
                            Id = new Guid("777eab55-31b1-494a-b804-078b8eccc000"),
                            CreatedAt = new DateTime(2023, 5, 6, 14, 5, 35, 980, DateTimeKind.Local).AddTicks(8479),
                            CreatedByUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000"),
                            EmailAddress = "custecom@mailinator.com",
                            FirstName = "Liliana",
                            LastName = "Vess",
                            UpdatedAt = new DateTime(2023, 5, 6, 14, 5, 35, 980, DateTimeKind.Local).AddTicks(8479),
                            UpdatedUserId = new Guid("777eab55-31b1-494a-b804-078b8eaaa000")
                        });
                });

            modelBuilder.Entity("ECommerce.Data.Models.LoginInfo", b =>
                {
                    b.HasOne("ECommerce.Data.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId");

                    b.HasOne("ECommerce.Data.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId");

                    b.HasOne("ECommerce.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("CreatedByUser");

                    b.Navigation("UpdatedByUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ECommerce.Data.Models.Others.Car", b =>
                {
                    b.HasOne("ECommerce.Data.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId");

                    b.HasOne("ECommerce.Data.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId");

                    b.Navigation("CreatedByUser");

                    b.Navigation("UpdatedByUser");
                });

            modelBuilder.Entity("ECommerce.Data.Models.User", b =>
                {
                    b.HasOne("ECommerce.Data.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId");

                    b.HasOne("ECommerce.Data.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId");

                    b.Navigation("CreatedByUser");

                    b.Navigation("UpdatedByUser");
                });
#pragma warning restore 612, 618
        }
    }
}
