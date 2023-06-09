﻿// <auto-generated />
using System;
using ExamNextJsBackend.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExamNextJsBackend.Entities.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.16");

            modelBuilder.Entity("GripFoodBackEnd.Entities.Cart", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("RestaurantId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("GripFoodBackEnd.Entities.CartDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CartId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("FoodItemId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("FoodItemId");

                    b.ToTable("CartDetails");
                });

            modelBuilder.Entity("GripFoodBackEnd.Entities.FoodItem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("RestaurantId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("FoodItems");

                    b.HasData(
                        new
                        {
                            Id = "01GY7CQMZWBQ62RN7MG8VWDBF6",
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 4, 17, 10, 38, 55, 484, DateTimeKind.Unspecified).AddTicks(797), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Rendang",
                            Price = 15000m,
                            RestaurantId = "SukaPadang"
                        },
                        new
                        {
                            Id = "01GY7CQMZW1MPXHWAXKS106DNV",
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 4, 17, 10, 38, 55, 484, DateTimeKind.Unspecified).AddTicks(800), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Ayam Gulai",
                            Price = 13000m,
                            RestaurantId = "SukaPadang"
                        },
                        new
                        {
                            Id = "01GY7CQMZWAS7J928Y9CPANRHK",
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 4, 17, 10, 38, 55, 484, DateTimeKind.Unspecified).AddTicks(803), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Nasi Putih",
                            Price = 5000m,
                            RestaurantId = "SukaPadang"
                        },
                        new
                        {
                            Id = "01GY7CQMZW3D3ZXD36ZKWYYX0G",
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 4, 17, 10, 38, 55, 484, DateTimeKind.Unspecified).AddTicks(816), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Aqua",
                            Price = 3000m,
                            RestaurantId = "SukaPadang"
                        },
                        new
                        {
                            Id = "01GY7CQMZWKDAXE831YM1DM3S1",
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 4, 17, 10, 38, 55, 484, DateTimeKind.Unspecified).AddTicks(819), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Es Teh Manis",
                            Price = 7000m,
                            RestaurantId = "SukaPadang"
                        },
                        new
                        {
                            Id = "01GY7CQMZW54V3GWVDGYRXXWD9",
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 4, 17, 10, 38, 55, 484, DateTimeKind.Unspecified).AddTicks(811), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Ayam Goreng",
                            Price = 15000m,
                            RestaurantId = "LebahBahagia"
                        },
                        new
                        {
                            Id = "01GY7CQMZW9W2SXHBSPKYRGNYA",
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 4, 17, 10, 38, 55, 484, DateTimeKind.Unspecified).AddTicks(814), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Spagetti",
                            Price = 18000m,
                            RestaurantId = "LebahBahagia"
                        },
                        new
                        {
                            Id = "01GY7CQMZWYASXEKW2CJWS46ZY",
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 4, 17, 10, 38, 55, 484, DateTimeKind.Unspecified).AddTicks(822), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Coca-Cola",
                            Price = 12000m,
                            RestaurantId = "LebahBahagia"
                        },
                        new
                        {
                            Id = "01GY7CQMZWGNV1ZWMHGMT8TAS6",
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 4, 17, 10, 38, 55, 484, DateTimeKind.Unspecified).AddTicks(825), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Sprite",
                            Price = 12000m,
                            RestaurantId = "LebahBahagia"
                        });
                });

            modelBuilder.Entity("GripFoodBackEnd.Entities.Restaurant", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = "SukaPadang",
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 4, 17, 10, 38, 55, 484, DateTimeKind.Unspecified).AddTicks(790), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Suka Padang"
                        },
                        new
                        {
                            Id = "LebahBahagia",
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 4, 17, 10, 38, 55, 484, DateTimeKind.Unspecified).AddTicks(791), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Lebah Bahagia"
                        });
                });

            modelBuilder.Entity("GripFoodBackEnd.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "01GY7CQMZW0396JD2M6BJKDJAS",
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 4, 17, 10, 38, 55, 484, DateTimeKind.Unspecified).AddTicks(783), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "yanto@mail.com",
                            Name = "Yanto",
                            Password = "yannto11"
                        },
                        new
                        {
                            Id = "01GY7CQMZWX4KR0YYJ45PFYSSV",
                            CreatedAt = new DateTimeOffset(new DateTime(2023, 4, 17, 10, 38, 55, 484, DateTimeKind.Unspecified).AddTicks(787), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "annie@mail.com",
                            Name = "Annie",
                            Password = "annie11"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.DataProtection.EntityFrameworkCore.DataProtectionKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FriendlyName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Xml")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DataProtectionKeys");
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictEntityFrameworkCoreApplication", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientId")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientSecret")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("ConsentType")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayNames")
                        .HasColumnType("TEXT");

                    b.Property<string>("Permissions")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostLogoutRedirectUris")
                        .HasColumnType("TEXT");

                    b.Property<string>("Properties")
                        .HasColumnType("TEXT");

                    b.Property<string>("RedirectUris")
                        .HasColumnType("TEXT");

                    b.Property<string>("Requirements")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("OpenIddictApplications", (string)null);
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictEntityFrameworkCoreAuthorization", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ApplicationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Properties")
                        .HasColumnType("TEXT");

                    b.Property<string>("Scopes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasMaxLength(400)
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId", "Status", "Subject", "Type");

                    b.ToTable("OpenIddictAuthorizations", (string)null);
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictEntityFrameworkCoreScope", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descriptions")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayNames")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Properties")
                        .HasColumnType("TEXT");

                    b.Property<string>("Resources")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("OpenIddictScopes", (string)null);
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictEntityFrameworkCoreToken", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ApplicationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthorizationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Payload")
                        .HasColumnType("TEXT");

                    b.Property<string>("Properties")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RedemptionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReferenceId")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasMaxLength(400)
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorizationId");

                    b.HasIndex("ReferenceId")
                        .IsUnique();

                    b.HasIndex("ApplicationId", "Status", "Subject", "Type");

                    b.ToTable("OpenIddictTokens", (string)null);
                });

            modelBuilder.Entity("GripFoodBackEnd.Entities.Cart", b =>
                {
                    b.HasOne("GripFoodBackEnd.Entities.Restaurant", "Restaurant")
                        .WithMany("Carts")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GripFoodBackEnd.Entities.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GripFoodBackEnd.Entities.CartDetail", b =>
                {
                    b.HasOne("GripFoodBackEnd.Entities.Cart", "Cart")
                        .WithMany("CartDetails")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GripFoodBackEnd.Entities.FoodItem", "FoodItem")
                        .WithMany("CartDetails")
                        .HasForeignKey("FoodItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("FoodItem");
                });

            modelBuilder.Entity("GripFoodBackEnd.Entities.FoodItem", b =>
                {
                    b.HasOne("GripFoodBackEnd.Entities.Restaurant", "Restaurant")
                        .WithMany("FoodItems")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictEntityFrameworkCoreAuthorization", b =>
                {
                    b.HasOne("OpenIddict.EntityFrameworkCore.Models.OpenIddictEntityFrameworkCoreApplication", "Application")
                        .WithMany("Authorizations")
                        .HasForeignKey("ApplicationId");

                    b.Navigation("Application");
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictEntityFrameworkCoreToken", b =>
                {
                    b.HasOne("OpenIddict.EntityFrameworkCore.Models.OpenIddictEntityFrameworkCoreApplication", "Application")
                        .WithMany("Tokens")
                        .HasForeignKey("ApplicationId");

                    b.HasOne("OpenIddict.EntityFrameworkCore.Models.OpenIddictEntityFrameworkCoreAuthorization", "Authorization")
                        .WithMany("Tokens")
                        .HasForeignKey("AuthorizationId");

                    b.Navigation("Application");

                    b.Navigation("Authorization");
                });

            modelBuilder.Entity("GripFoodBackEnd.Entities.Cart", b =>
                {
                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("GripFoodBackEnd.Entities.FoodItem", b =>
                {
                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("GripFoodBackEnd.Entities.Restaurant", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("FoodItems");
                });

            modelBuilder.Entity("GripFoodBackEnd.Entities.User", b =>
                {
                    b.Navigation("Carts");
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictEntityFrameworkCoreApplication", b =>
                {
                    b.Navigation("Authorizations");

                    b.Navigation("Tokens");
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictEntityFrameworkCoreAuthorization", b =>
                {
                    b.Navigation("Tokens");
                });
#pragma warning restore 612, 618
        }
    }
}
