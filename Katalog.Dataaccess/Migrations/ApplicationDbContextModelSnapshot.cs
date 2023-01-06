﻿// <auto-generated />
using System;
using Katalog.Dataaccess.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Katalog.Dataaccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Katalog.Entity.Firma", b =>
                {
                    b.Property<long>("FirmaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("FirmaAdi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Pasif")
                        .HasColumnType("tinyint(1)");

                    b.Property<long>("Siralama")
                        .HasColumnType("bigint");

                    b.HasKey("FirmaID");

                    b.ToTable("Firmalar", (string)null);
                });

            modelBuilder.Entity("Katalog.Entity.Kullanici", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("Pasif")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Katalog.Entity.KullanilanParca", b =>
                {
                    b.Property<long>("KullanildigiParcaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("EslestirilenUrunNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KullanildigiParcaAdi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KullanildigiParcaUrunNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Pasif")
                        .HasColumnType("tinyint(1)");

                    b.Property<long>("Siralama")
                        .HasColumnType("bigint");

                    b.Property<long>("UrunID")
                        .HasColumnType("bigint");

                    b.Property<string>("UrunNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("KullanildigiParcaID");

                    b.ToTable("KullanilanParcalar", (string)null);
                });

            modelBuilder.Entity("Katalog.Entity.Marka", b =>
                {
                    b.Property<long>("MarkaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("MarkaAdi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Pasif")
                        .HasColumnType("tinyint(1)");

                    b.Property<long>("Siralama")
                        .HasColumnType("bigint");

                    b.HasKey("MarkaID");

                    b.ToTable("Markalar", (string)null);
                });

            modelBuilder.Entity("Katalog.Entity.Model", b =>
                {
                    b.Property<long>("ModelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("MarkaID")
                        .HasColumnType("bigint");

                    b.Property<string>("ModelAdi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Pasif")
                        .HasColumnType("tinyint(1)");

                    b.Property<long>("Siralama")
                        .HasColumnType("bigint");

                    b.Property<long>("TipID")
                        .HasColumnType("bigint");

                    b.HasKey("ModelID");

                    b.ToTable("Modeller", (string)null);
                });

            modelBuilder.Entity("Katalog.Entity.OEM", b =>
                {
                    b.Property<long>("FirmaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("OEMno")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Pasif")
                        .HasColumnType("tinyint(1)");

                    b.Property<long>("Siralama")
                        .HasColumnType("bigint");

                    b.Property<long>("UrunID")
                        .HasColumnType("bigint");

                    b.Property<string>("UrunNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("FirmaID");

                    b.ToTable("OEMler", (string)null);
                });

            modelBuilder.Entity("Katalog.Entity.Referans", b =>
                {
                    b.Property<long>("RefID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("FirmaID")
                        .HasColumnType("bigint");

                    b.Property<bool>("Pasif")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("RefNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Siralama")
                        .HasColumnType("bigint");

                    b.Property<long>("UrunID")
                        .HasColumnType("bigint");

                    b.Property<string>("UrunNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RefID");

                    b.ToTable("Referanslar", (string)null);
                });

            modelBuilder.Entity("Katalog.Entity.Tip", b =>
                {
                    b.Property<long>("TipID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("MarkaID")
                        .HasColumnType("bigint");

                    b.Property<bool>("Pasif")
                        .HasColumnType("tinyint(1)");

                    b.Property<long>("Siralama")
                        .HasColumnType("bigint");

                    b.Property<string>("TipAdi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TipID");

                    b.ToTable("Tipler", (string)null);
                });

            modelBuilder.Entity("Katalog.Entity.Urun", b =>
                {
                    b.Property<long>("UrunID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("EANno")
                        .HasColumnType("bigint");

                    b.Property<string>("EslestirilenUrunNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("KullanildigiParcaID")
                        .HasColumnType("bigint");

                    b.Property<string>("Olculer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Pasif")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Resim")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Siralama")
                        .HasColumnType("bigint");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UrunNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UrunID");

                    b.ToTable("Urunler", (string)null);
                });

            modelBuilder.Entity("Katalog.Entity.Urun_Araba", b =>
                {
                    b.Property<long>("Urun_ArabaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("MarkaID")
                        .HasColumnType("bigint");

                    b.Property<long>("ModelID")
                        .HasColumnType("bigint");

                    b.Property<long>("TipID")
                        .HasColumnType("bigint");

                    b.Property<long>("UrunID")
                        .HasColumnType("bigint");

                    b.HasKey("Urun_ArabaID");

                    b.ToTable("Urun_Araba", (string)null);
                });

            modelBuilder.Entity("Katalog.Entity.Uyumluluk", b =>
                {
                    b.Property<long>("UyumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("ModelID")
                        .HasColumnType("bigint");

                    b.Property<long>("Siralama")
                        .HasColumnType("bigint");

                    b.Property<long>("UrunID")
                        .HasColumnType("bigint");

                    b.Property<string>("UrunNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Uyum")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UyumID");

                    b.ToTable("Uyumluluklar", (string)null);
                });

            modelBuilder.Entity("Katalog.Entity.Views.KatalogListe", b =>
                {
                    b.Property<string>("OEMno")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Olculer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Resim")
                        .HasColumnType("longtext");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("UrunID")
                        .HasColumnType("bigint");

                    b.Property<string>("UrunNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.ToView("KatalogListe");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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
                    b.HasOne("Katalog.Entity.Kullanici", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Katalog.Entity.Kullanici", null)
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

                    b.HasOne("Katalog.Entity.Kullanici", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Katalog.Entity.Kullanici", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
