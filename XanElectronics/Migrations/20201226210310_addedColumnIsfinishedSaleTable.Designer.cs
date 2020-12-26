﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XanElectronics.Dal;

namespace XanElectronics.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201226210310_addedColumnIsfinishedSaleTable")]
    partial class addedColumnIsfinishedSaleTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("XanElectronics.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Fullname")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsActivated")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "da7f7354-df6b-43e5-86f0-6f39c59f290d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5cf198ab-062d-406a-9062-07cd57d766fe",
                            EmailConfirmed = false,
                            Fullname = "Ulvi Mecidov",
                            IsActivated = true,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "df2b55d2-5fa2-4a02-8d3f-8cbaa2c76fe0",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("XanElectronics.Models.Bio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Facebook")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FooterLogoUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("HeaderLogoUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Instagram")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Twitter")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Youtube")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Bios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Baku city,Sabail district",
                            Email = "orkhanmm@code.edu.az",
                            Facebook = "www.facebook.com",
                            FooterLogoUrl = "logo-dark.jpg",
                            HeaderLogoUrl = "logo-dark.jpg",
                            Instagram = "www.instagram.com",
                            Phone = "+994555535373",
                            Twitter = "www.twitter.com",
                            Youtube = "www.youtube.com"
                        });
                });

            modelBuilder.Entity("XanElectronics.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("XanElectronics.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsPopular")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("ProductCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "1.jpg",
                            IsDeleted = false,
                            IsPopular = true,
                            Name = "phone",
                            ProductCount = 4
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "1.jpg",
                            IsDeleted = false,
                            IsPopular = true,
                            Name = "laptop",
                            ProductCount = 4
                        });
                });

            modelBuilder.Entity("XanElectronics.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Context")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Subject")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("XanElectronics.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Color")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("DisCountRate")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsNew")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsOriginal")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LongDescription")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("ResultPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Size")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Star")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Code = "11",
                            Color = "ag",
                            Count = 50,
                            DisCountRate = 10,
                            IsDeleted = false,
                            IsFeatured = true,
                            IsNew = true,
                            IsOriginal = true,
                            LongDescription = "...",
                            Name = "iphone1",
                            Price = 3000m,
                            ResultPrice = 2700m,
                            ShortDescription = "..",
                            Size = "X",
                            Star = 5
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Code = "12",
                            Color = "ag",
                            Count = 50,
                            DisCountRate = 10,
                            IsDeleted = false,
                            IsFeatured = true,
                            IsNew = true,
                            IsOriginal = true,
                            LongDescription = "...",
                            Name = "samsung1",
                            Price = 2000m,
                            ResultPrice = 1800m,
                            ShortDescription = "..",
                            Size = "X",
                            Star = 4
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Code = "13",
                            Color = "ag",
                            Count = 50,
                            DisCountRate = 10,
                            IsDeleted = false,
                            IsFeatured = true,
                            IsNew = true,
                            IsOriginal = true,
                            LongDescription = "...",
                            Name = "xiaomi1",
                            Price = 1000m,
                            ResultPrice = 1000m,
                            ShortDescription = "..",
                            Size = "X",
                            Star = 4
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Code = "14",
                            Color = "ag",
                            Count = 50,
                            DisCountRate = 0,
                            IsDeleted = false,
                            IsFeatured = true,
                            IsNew = true,
                            IsOriginal = true,
                            LongDescription = "...",
                            Name = "nokia1",
                            Price = 200m,
                            ResultPrice = 200m,
                            ShortDescription = "..",
                            Size = "X",
                            Star = 2
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Code = "15",
                            Color = "ag",
                            Count = 50,
                            DisCountRate = 10,
                            IsDeleted = false,
                            IsFeatured = true,
                            IsNew = true,
                            IsOriginal = true,
                            LongDescription = "...",
                            Name = "iphone2",
                            Price = 3000m,
                            ResultPrice = 2700m,
                            ShortDescription = "..",
                            Size = "X",
                            Star = 5
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Code = "16",
                            Color = "ag",
                            Count = 50,
                            DisCountRate = 10,
                            IsDeleted = false,
                            IsFeatured = true,
                            IsNew = true,
                            IsOriginal = true,
                            LongDescription = "...",
                            Name = "samsung2",
                            Price = 2000m,
                            ResultPrice = 1800m,
                            ShortDescription = "..",
                            Size = "X",
                            Star = 4
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Code = "17",
                            Color = "ag",
                            Count = 50,
                            DisCountRate = 10,
                            IsDeleted = false,
                            IsFeatured = true,
                            IsNew = true,
                            IsOriginal = true,
                            LongDescription = "...",
                            Name = "xiaomi2",
                            Price = 1000m,
                            ResultPrice = 1000m,
                            ShortDescription = "..",
                            Size = "X",
                            Star = 4
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Code = "18",
                            Color = "ag",
                            Count = 50,
                            DisCountRate = 0,
                            IsDeleted = false,
                            IsFeatured = true,
                            IsNew = true,
                            IsOriginal = true,
                            LongDescription = "...",
                            Name = "nokia2",
                            Price = 200m,
                            ResultPrice = 200m,
                            ShortDescription = "..",
                            Size = "X",
                            Star = 2
                        });
                });

            modelBuilder.Entity("XanElectronics.Models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "1.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "1.jpg",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "1.jpg",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "1.jpg",
                            ProductId = 4
                        },
                        new
                        {
                            Id = 5,
                            ImageUrl = "1.jpg",
                            ProductId = 5
                        },
                        new
                        {
                            Id = 6,
                            ImageUrl = "1.jpg",
                            ProductId = 6
                        },
                        new
                        {
                            Id = 7,
                            ImageUrl = "1.jpg",
                            ProductId = 7
                        },
                        new
                        {
                            Id = 8,
                            ImageUrl = "1.jpg",
                            ProductId = 8
                        });
                });

            modelBuilder.Entity("XanElectronics.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AppUserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsFinished")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("XanElectronics.Models.SaleProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SaleId");

                    b.ToTable("SaleProducts");
                });

            modelBuilder.Entity("XanElectronics.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("XanElectronics.Models.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("XanElectronics.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("XanElectronics.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XanElectronics.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("XanElectronics.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("XanElectronics.Models.Product", b =>
                {
                    b.HasOne("XanElectronics.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("XanElectronics.Models.ProductImage", b =>
                {
                    b.HasOne("XanElectronics.Models.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("XanElectronics.Models.Sale", b =>
                {
                    b.HasOne("XanElectronics.Models.AppUser", "AppUser")
                        .WithMany("Sales")
                        .HasForeignKey("AppUserId");
                });

            modelBuilder.Entity("XanElectronics.Models.SaleProduct", b =>
                {
                    b.HasOne("XanElectronics.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XanElectronics.Models.Sale", "Sale")
                        .WithMany("SaleProducts")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
