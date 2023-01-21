﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.DAL;

#nullable disable

namespace WebApp.Migrations
{
    [DbContext(typeof(HastaneDB))]
    [Migration("20230121140813_21.01.2023_v2")]
    partial class _21012023_v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebApp.Models.Gun", b =>
                {
                    b.Property<int>("GunID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GunID"), 1L, 1);

                    b.Property<string>("GunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GunID");

                    b.ToTable("Gunler");

                    b.HasData(
                        new
                        {
                            GunID = 1,
                            GunAdi = "Pazartesi"
                        },
                        new
                        {
                            GunID = 2,
                            GunAdi = "Salı"
                        },
                        new
                        {
                            GunID = 3,
                            GunAdi = "Çarşamba"
                        },
                        new
                        {
                            GunID = 4,
                            GunAdi = "Perşembe"
                        },
                        new
                        {
                            GunID = 5,
                            GunAdi = "Cuma"
                        });
                });

            modelBuilder.Entity("WebApp.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriID"), 1L, 1);

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("WebApp.Models.Kitap", b =>
                {
                    b.Property<int>("KitapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KitapID"), 1L, 1);

                    b.Property<string>("ArkaKapakYazisi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EklendigiTarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("KapakResmi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KitapAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OduncVerildi")
                        .HasColumnType("bit");

                    b.Property<bool>("Onerilen")
                        .HasColumnType("bit");

                    b.Property<double>("OrtalamaPuan")
                        .HasColumnType("float");

                    b.Property<int>("StokAdedi")
                        .HasColumnType("int");

                    b.Property<int>("YazarID")
                        .HasColumnType("int");

                    b.HasKey("KitapID");

                    b.HasIndex("YazarID");

                    b.ToTable("Kitaplar");
                });

            modelBuilder.Entity("WebApp.Models.Kitap_Kategori", b =>
                {
                    b.Property<int>("KKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KKID"), 1L, 1);

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<int>("KitapID")
                        .HasColumnType("int");

                    b.Property<int?>("Kitap_KategoriKKID")
                        .HasColumnType("int");

                    b.HasKey("KKID");

                    b.HasIndex("KategoriID");

                    b.HasIndex("KitapID");

                    b.HasIndex("Kitap_KategoriKKID");

                    b.ToTable("Kitap_Kategori");
                });

            modelBuilder.Entity("WebApp.Models.OduncVerme", b =>
                {
                    b.Property<int>("OduncVermeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OduncVermeID"), 1L, 1);

                    b.Property<int>("KitapID")
                        .HasColumnType("int");

                    b.Property<int?>("Kitap_KategoriKKID")
                        .HasColumnType("int");

                    b.Property<DateTime>("TeslimTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("UyeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("VarsayilanTeslimTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VerilisTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("OduncVermeID");

                    b.HasIndex("KitapID");

                    b.HasIndex("Kitap_KategoriKKID");

                    b.HasIndex("UyeID");

                    b.ToTable("OduncVerme");
                });

            modelBuilder.Entity("WebApp.Models.Poliklinik", b =>
                {
                    b.Property<int>("PoliklinikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PoliklinikID"), 1L, 1);

                    b.Property<string>("PoliklinikAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PoliklinikID");

                    b.ToTable("Poliklinikler");

                    b.HasData(
                        new
                        {
                            PoliklinikID = 1,
                            PoliklinikAdi = "Kulak Burun Boğaz",
                            Resim = "resim1.jpg"
                        },
                        new
                        {
                            PoliklinikID = 2,
                            PoliklinikAdi = "Genel Cerrahi",
                            Resim = "resim2.jpg"
                        },
                        new
                        {
                            PoliklinikID = 3,
                            PoliklinikAdi = "Göz",
                            Resim = "resim3.jpg"
                        });
                });

            modelBuilder.Entity("WebApp.Models.Puan", b =>
                {
                    b.Property<int>("PuanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PuanID"), 1L, 1);

                    b.Property<int>("KitapID")
                        .HasColumnType("int");

                    b.Property<int?>("Kitap_KategoriKKID")
                        .HasColumnType("int");

                    b.Property<int>("Puanlama")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("UyeID")
                        .HasColumnType("int");

                    b.HasKey("PuanID");

                    b.HasIndex("KitapID");

                    b.HasIndex("Kitap_KategoriKKID");

                    b.HasIndex("UyeID");

                    b.ToTable("Puanlar");
                });

            modelBuilder.Entity("WebApp.Models.Randevu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("RandevuTanimiID")
                        .HasColumnType("int");

                    b.Property<DateTime>("RandevuTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("UyeGeldiMi")
                        .HasColumnType("bit");

                    b.Property<int>("UyeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RandevuTanimiID");

                    b.HasIndex("UyeID");

                    b.ToTable("Randevular");
                });

            modelBuilder.Entity("WebApp.Models.RandevuTanimi", b =>
                {
                    b.Property<int>("RandevuTanimiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RandevuTanimiID"), 1L, 1);

                    b.Property<int>("GunID")
                        .HasColumnType("int");

                    b.Property<int>("PoliklinikID")
                        .HasColumnType("int");

                    b.Property<bool>("RandevuDurumu")
                        .HasColumnType("bit");

                    b.Property<int?>("RandevuTanimiID1")
                        .HasColumnType("int");

                    b.Property<int>("SaatID")
                        .HasColumnType("int");

                    b.HasKey("RandevuTanimiID");

                    b.HasIndex("GunID");

                    b.HasIndex("PoliklinikID");

                    b.HasIndex("RandevuTanimiID1");

                    b.HasIndex("SaatID");

                    b.ToTable("RandevuTanimlari");
                });

            modelBuilder.Entity("WebApp.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "a1a38154-8c68-498f-8b87-ff6bfa6d6a68",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "e898ecbd-a490-4340-b77c-e356431d0d3e",
                            Name = "Uye",
                            NormalizedName = "UYE"
                        });
                });

            modelBuilder.Entity("WebApp.Models.Saat", b =>
                {
                    b.Property<int>("SaatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaatID"), 1L, 1);

                    b.Property<string>("RandevuSaati")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SaatID");

                    b.ToTable("Saatler");

                    b.HasData(
                        new
                        {
                            SaatID = 1,
                            RandevuSaati = "10"
                        },
                        new
                        {
                            SaatID = 2,
                            RandevuSaati = "11"
                        },
                        new
                        {
                            SaatID = 3,
                            RandevuSaati = "12"
                        },
                        new
                        {
                            SaatID = 4,
                            RandevuSaati = "13"
                        },
                        new
                        {
                            SaatID = 5,
                            RandevuSaati = "14"
                        },
                        new
                        {
                            SaatID = 6,
                            RandevuSaati = "15"
                        },
                        new
                        {
                            SaatID = 7,
                            RandevuSaati = "16"
                        });
                });

            modelBuilder.Entity("WebApp.Models.Sepet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<int>("KitapID")
                        .HasColumnType("int");

                    b.Property<int?>("Kitap_KategoriKKID")
                        .HasColumnType("int");

                    b.Property<int>("UyeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KitapID");

                    b.HasIndex("Kitap_KategoriKKID");

                    b.HasIndex("UyeID");

                    b.ToTable("Sepetler");
                });

            modelBuilder.Entity("WebApp.Models.Uye", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("WebApp.Models.Yazar", b =>
                {
                    b.Property<int>("YazarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YazarID"), 1L, 1);

                    b.Property<string>("Biyografi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YazarID");

                    b.ToTable("Yazarlar");
                });

            modelBuilder.Entity("WebApp.Models.Yorum", b =>
                {
                    b.Property<int>("YorumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YorumID"), 1L, 1);

                    b.Property<int>("KitapID")
                        .HasColumnType("int");

                    b.Property<int?>("Kitap_KategoriKKID")
                        .HasColumnType("int");

                    b.Property<string>("Mesaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UyeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("YorumTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("YorumID");

                    b.HasIndex("KitapID");

                    b.HasIndex("Kitap_KategoriKKID");

                    b.HasIndex("UyeID");

                    b.ToTable("Yorumlar");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("WebApp.Models.Rol", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("WebApp.Models.Uye", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("WebApp.Models.Uye", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("WebApp.Models.Rol", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.Uye", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("WebApp.Models.Uye", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApp.Models.Kitap", b =>
                {
                    b.HasOne("WebApp.Models.Yazar", "Yazar")
                        .WithMany("Kitaplar")
                        .HasForeignKey("YazarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yazar");
                });

            modelBuilder.Entity("WebApp.Models.Kitap_Kategori", b =>
                {
                    b.HasOne("WebApp.Models.Kategori", "Kategori")
                        .WithMany("Kitaplar")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.Kitap", "Kitap")
                        .WithMany("Kategoriler")
                        .HasForeignKey("KitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.Kitap_Kategori", null)
                        .WithMany("Kategoriler")
                        .HasForeignKey("Kitap_KategoriKKID");

                    b.Navigation("Kategori");

                    b.Navigation("Kitap");
                });

            modelBuilder.Entity("WebApp.Models.OduncVerme", b =>
                {
                    b.HasOne("WebApp.Models.Kitap", "Kitap")
                        .WithMany("Oduncler")
                        .HasForeignKey("KitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.Kitap_Kategori", null)
                        .WithMany("Oduncler")
                        .HasForeignKey("Kitap_KategoriKKID");

                    b.HasOne("WebApp.Models.Uye", "Uye")
                        .WithMany("Oduncler")
                        .HasForeignKey("UyeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("WebApp.Models.Puan", b =>
                {
                    b.HasOne("WebApp.Models.Kitap", "Kitap")
                        .WithMany("Puanlar")
                        .HasForeignKey("KitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.Kitap_Kategori", null)
                        .WithMany("Puanlar")
                        .HasForeignKey("Kitap_KategoriKKID");

                    b.HasOne("WebApp.Models.Uye", "Uye")
                        .WithMany("Puanlar")
                        .HasForeignKey("UyeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("WebApp.Models.Randevu", b =>
                {
                    b.HasOne("WebApp.Models.RandevuTanimi", "RandevuTanimi")
                        .WithMany()
                        .HasForeignKey("RandevuTanimiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.Uye", "Uye")
                        .WithMany("Randevular")
                        .HasForeignKey("UyeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RandevuTanimi");

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("WebApp.Models.RandevuTanimi", b =>
                {
                    b.HasOne("WebApp.Models.Gun", "Gun")
                        .WithMany("RandevuTanimlari")
                        .HasForeignKey("GunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.Poliklinik", "Poliklinikler")
                        .WithMany("RandevularTanimlari")
                        .HasForeignKey("PoliklinikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.RandevuTanimi", null)
                        .WithMany("RandevuTanimlari")
                        .HasForeignKey("RandevuTanimiID1");

                    b.HasOne("WebApp.Models.Saat", "Saat")
                        .WithMany("RandevuTanimlari")
                        .HasForeignKey("SaatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gun");

                    b.Navigation("Poliklinikler");

                    b.Navigation("Saat");
                });

            modelBuilder.Entity("WebApp.Models.Sepet", b =>
                {
                    b.HasOne("WebApp.Models.Kitap", "Kitap")
                        .WithMany("Sepetler")
                        .HasForeignKey("KitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.Kitap_Kategori", null)
                        .WithMany("Sepetler")
                        .HasForeignKey("Kitap_KategoriKKID");

                    b.HasOne("WebApp.Models.Uye", "Uye")
                        .WithMany("Sepetler")
                        .HasForeignKey("UyeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("WebApp.Models.Yorum", b =>
                {
                    b.HasOne("WebApp.Models.Kitap", "Kitap")
                        .WithMany("Yorumlar")
                        .HasForeignKey("KitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.Kitap_Kategori", null)
                        .WithMany("Yorumlar")
                        .HasForeignKey("Kitap_KategoriKKID");

                    b.HasOne("WebApp.Models.Uye", "Uye")
                        .WithMany("Yorumlar")
                        .HasForeignKey("UyeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("WebApp.Models.Gun", b =>
                {
                    b.Navigation("RandevuTanimlari");
                });

            modelBuilder.Entity("WebApp.Models.Kategori", b =>
                {
                    b.Navigation("Kitaplar");
                });

            modelBuilder.Entity("WebApp.Models.Kitap", b =>
                {
                    b.Navigation("Kategoriler");

                    b.Navigation("Oduncler");

                    b.Navigation("Puanlar");

                    b.Navigation("Sepetler");

                    b.Navigation("Yorumlar");
                });

            modelBuilder.Entity("WebApp.Models.Kitap_Kategori", b =>
                {
                    b.Navigation("Kategoriler");

                    b.Navigation("Oduncler");

                    b.Navigation("Puanlar");

                    b.Navigation("Sepetler");

                    b.Navigation("Yorumlar");
                });

            modelBuilder.Entity("WebApp.Models.Poliklinik", b =>
                {
                    b.Navigation("RandevularTanimlari");
                });

            modelBuilder.Entity("WebApp.Models.RandevuTanimi", b =>
                {
                    b.Navigation("RandevuTanimlari");
                });

            modelBuilder.Entity("WebApp.Models.Saat", b =>
                {
                    b.Navigation("RandevuTanimlari");
                });

            modelBuilder.Entity("WebApp.Models.Uye", b =>
                {
                    b.Navigation("Oduncler");

                    b.Navigation("Puanlar");

                    b.Navigation("Randevular");

                    b.Navigation("Sepetler");

                    b.Navigation("Yorumlar");
                });

            modelBuilder.Entity("WebApp.Models.Yazar", b =>
                {
                    b.Navigation("Kitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}
