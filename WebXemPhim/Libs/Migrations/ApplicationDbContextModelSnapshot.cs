﻿// <auto-generated />
using System;
using Libs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Libs.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Libs.Entities.ChiTietHoaDon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DichVuId")
                        .HasColumnType("int");

                    b.Property<int>("GiaApDung")
                        .HasColumnType("int");

                    b.Property<int>("HoaDonDichVuId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("TongGia")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DichVuId");

                    b.HasIndex("HoaDonDichVuId");

                    b.ToTable("ChiTietHoaDons");
                });

            modelBuilder.Entity("Libs.Entities.ChucVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TenChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ChucVus");
                });

            modelBuilder.Entity("Libs.Entities.DanhGiaDichVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DichVuId")
                        .HasColumnType("int");

                    b.Property<int>("KhachHangId")
                        .HasColumnType("int");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DichVuId");

                    b.HasIndex("KhachHangId");

                    b.ToTable("DanhGiaDichVus");
                });

            modelBuilder.Entity("Libs.Entities.DanhGiaPhim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("KhachHangId")
                        .HasColumnType("int");

                    b.Property<int>("PhimId")
                        .HasColumnType("int");

                    b.Property<int>("SoDiemCham")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KhachHangId");

                    b.HasIndex("PhimId");

                    b.ToTable("DanhGiaPhims");
                });

            modelBuilder.Entity("Libs.Entities.DaoDien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("QuocTich")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DaoDiens");
                });

            modelBuilder.Entity("Libs.Entities.DichVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Gia")
                        .HasColumnType("int");

                    b.Property<int>("LoaiDichVuId")
                        .HasColumnType("int");

                    b.Property<string>("TenDichVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LoaiDichVuId");

                    b.ToTable("DichVus");
                });

            modelBuilder.Entity("Libs.Entities.GiaVe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Gia")
                        .HasColumnType("int");

                    b.Property<int>("PhongPhimId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PhongPhimId");

                    b.ToTable("GiaVes");
                });

            modelBuilder.Entity("Libs.Entities.HangSanXuat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MoTaHangSanXuat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenHangSanXuat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HangSanXuats");
                });

            modelBuilder.Entity("Libs.Entities.HoaDonDichVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("KhachHangId")
                        .HasColumnType("int");

                    b.Property<int>("KhuyenMaiDichVuId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayLap")
                        .HasColumnType("datetime2");

                    b.Property<int>("NhanVienId")
                        .HasColumnType("int");

                    b.Property<int>("TongThanhToan")
                        .HasColumnType("int");

                    b.Property<int>("VePhimId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KhachHangId");

                    b.HasIndex("KhuyenMaiDichVuId");

                    b.HasIndex("NhanVienId");

                    b.HasIndex("VePhimId");

                    b.ToTable("HoaDonDichVus");
                });

            modelBuilder.Entity("Libs.Entities.KhachHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoaiThanhVienId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LoaiThanhVienId");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("Libs.Entities.KhuyenMaiDichVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Han")
                        .HasColumnType("datetime2");

                    b.Property<string>("MieuTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhanTramGiam")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("KhuyenMaiDichVus");
                });

            modelBuilder.Entity("Libs.Entities.KhuyenMaiGiaVe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Han")
                        .HasColumnType("datetime2");

                    b.Property<string>("MieuTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhanTramGiam")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("KhuyenMaiGiaVes");
                });

            modelBuilder.Entity("Libs.Entities.LoaiDichVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TenLoaiDichVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoaiDichVus");
                });

            modelBuilder.Entity("Libs.Entities.LoaiPhong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TenLoaiPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoaiPhongs");
                });

            modelBuilder.Entity("Libs.Entities.LoaiThanhVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TenLoaiThanhVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoaiThanhViens");
                });

            modelBuilder.Entity("Libs.Entities.NhanVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CaLam")
                        .HasColumnType("int");

                    b.Property<int>("ChucVuId")
                        .HasColumnType("int");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Luong")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ChucVuId");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("Libs.Entities.Phim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DaoDienId")
                        .HasColumnType("int");

                    b.Property<int>("HangSanXuatId")
                        .HasColumnType("int");

                    b.Property<int>("NamSanXuat")
                        .HasColumnType("int");

                    b.Property<string>("TenPhim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TheLoaiPhimId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DaoDienId");

                    b.HasIndex("HangSanXuatId");

                    b.HasIndex("TheLoaiPhimId");

                    b.ToTable("Phims");
                });

            modelBuilder.Entity("Libs.Entities.PhongPhim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LoaiPhongId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongKhachChua")
                        .HasColumnType("int");

                    b.Property<int>("SoPhong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LoaiPhongId");

                    b.ToTable("PhongPhims");
                });

            modelBuilder.Entity("Libs.Entities.TheLoaiPhim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TenTheLoaiPhim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TheLoaiPhims");
                });

            modelBuilder.Entity("Libs.Entities.VePhim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("KhuyenMaiGiaVeId")
                        .HasColumnType("int");

                    b.Property<int>("PhimId")
                        .HasColumnType("int");

                    b.Property<int>("PhongPhimId")
                        .HasColumnType("int");

                    b.Property<int>("SoChoNgoi")
                        .HasColumnType("int");

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.Property<int>("TongThanhToan")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KhuyenMaiGiaVeId");

                    b.HasIndex("PhimId");

                    b.HasIndex("PhongPhimId");

                    b.ToTable("VePhims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Libs.Entities.ChiTietHoaDon", b =>
                {
                    b.HasOne("Libs.Entities.DichVu", "DichVu")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("DichVuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libs.Entities.HoaDonDichVu", "HoaDonDichVu")
                        .WithMany()
                        .HasForeignKey("HoaDonDichVuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DichVu");

                    b.Navigation("HoaDonDichVu");
                });

            modelBuilder.Entity("Libs.Entities.DanhGiaDichVu", b =>
                {
                    b.HasOne("Libs.Entities.DichVu", "DichVu")
                        .WithMany("DanhGiaDichVus")
                        .HasForeignKey("DichVuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libs.Entities.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("KhachHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DichVu");

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("Libs.Entities.DanhGiaPhim", b =>
                {
                    b.HasOne("Libs.Entities.KhachHang", "KhachHang")
                        .WithMany("DanhGiaPhims")
                        .HasForeignKey("KhachHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libs.Entities.Phim", "Phim")
                        .WithMany()
                        .HasForeignKey("PhimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("Phim");
                });

            modelBuilder.Entity("Libs.Entities.DichVu", b =>
                {
                    b.HasOne("Libs.Entities.LoaiDichVu", "LoaiDichVu")
                        .WithMany("DichVus")
                        .HasForeignKey("LoaiDichVuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiDichVu");
                });

            modelBuilder.Entity("Libs.Entities.GiaVe", b =>
                {
                    b.HasOne("Libs.Entities.PhongPhim", "PhongPhim")
                        .WithMany("GiaVes")
                        .HasForeignKey("PhongPhimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhongPhim");
                });

            modelBuilder.Entity("Libs.Entities.HoaDonDichVu", b =>
                {
                    b.HasOne("Libs.Entities.KhachHang", "KhachHang")
                        .WithMany("HoaDonDichVus")
                        .HasForeignKey("KhachHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libs.Entities.KhuyenMaiDichVu", "KhuyenMaiDichVu")
                        .WithMany("HoaDonDichVus")
                        .HasForeignKey("KhuyenMaiDichVuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libs.Entities.NhanVien", "NhanVien")
                        .WithMany("HoaDonDichVus")
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libs.Entities.VePhim", "VePhim")
                        .WithMany("HoaDonDichVus")
                        .HasForeignKey("VePhimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("KhuyenMaiDichVu");

                    b.Navigation("NhanVien");

                    b.Navigation("VePhim");
                });

            modelBuilder.Entity("Libs.Entities.KhachHang", b =>
                {
                    b.HasOne("Libs.Entities.LoaiThanhVien", "LoaiThanhVien")
                        .WithMany("KhachHangs")
                        .HasForeignKey("LoaiThanhVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiThanhVien");
                });

            modelBuilder.Entity("Libs.Entities.NhanVien", b =>
                {
                    b.HasOne("Libs.Entities.ChucVu", "ChucVu")
                        .WithMany("NhanViens")
                        .HasForeignKey("ChucVuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChucVu");
                });

            modelBuilder.Entity("Libs.Entities.Phim", b =>
                {
                    b.HasOne("Libs.Entities.DaoDien", "DaoDien")
                        .WithMany("Phims")
                        .HasForeignKey("DaoDienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libs.Entities.HangSanXuat", "HangSanXuat")
                        .WithMany("Phims")
                        .HasForeignKey("HangSanXuatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libs.Entities.TheLoaiPhim", "TheLoaiPhim")
                        .WithMany("Phims")
                        .HasForeignKey("TheLoaiPhimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DaoDien");

                    b.Navigation("HangSanXuat");

                    b.Navigation("TheLoaiPhim");
                });

            modelBuilder.Entity("Libs.Entities.PhongPhim", b =>
                {
                    b.HasOne("Libs.Entities.LoaiPhong", "LoaiPhong")
                        .WithMany("PhongPhims")
                        .HasForeignKey("LoaiPhongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiPhong");
                });

            modelBuilder.Entity("Libs.Entities.VePhim", b =>
                {
                    b.HasOne("Libs.Entities.KhuyenMaiGiaVe", "KhuyenMaiGiaVe")
                        .WithMany()
                        .HasForeignKey("KhuyenMaiGiaVeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libs.Entities.Phim", "Phim")
                        .WithMany("VePhims")
                        .HasForeignKey("PhimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libs.Entities.PhongPhim", "PhongPhim")
                        .WithMany()
                        .HasForeignKey("PhongPhimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhuyenMaiGiaVe");

                    b.Navigation("Phim");

                    b.Navigation("PhongPhim");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Libs.Entities.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("Libs.Entities.DaoDien", b =>
                {
                    b.Navigation("Phims");
                });

            modelBuilder.Entity("Libs.Entities.DichVu", b =>
                {
                    b.Navigation("ChiTietHoaDons");

                    b.Navigation("DanhGiaDichVus");
                });

            modelBuilder.Entity("Libs.Entities.HangSanXuat", b =>
                {
                    b.Navigation("Phims");
                });

            modelBuilder.Entity("Libs.Entities.KhachHang", b =>
                {
                    b.Navigation("DanhGiaPhims");

                    b.Navigation("HoaDonDichVus");
                });

            modelBuilder.Entity("Libs.Entities.KhuyenMaiDichVu", b =>
                {
                    b.Navigation("HoaDonDichVus");
                });

            modelBuilder.Entity("Libs.Entities.LoaiDichVu", b =>
                {
                    b.Navigation("DichVus");
                });

            modelBuilder.Entity("Libs.Entities.LoaiPhong", b =>
                {
                    b.Navigation("PhongPhims");
                });

            modelBuilder.Entity("Libs.Entities.LoaiThanhVien", b =>
                {
                    b.Navigation("KhachHangs");
                });

            modelBuilder.Entity("Libs.Entities.NhanVien", b =>
                {
                    b.Navigation("HoaDonDichVus");
                });

            modelBuilder.Entity("Libs.Entities.Phim", b =>
                {
                    b.Navigation("VePhims");
                });

            modelBuilder.Entity("Libs.Entities.PhongPhim", b =>
                {
                    b.Navigation("GiaVes");
                });

            modelBuilder.Entity("Libs.Entities.TheLoaiPhim", b =>
                {
                    b.Navigation("Phims");
                });

            modelBuilder.Entity("Libs.Entities.VePhim", b =>
                {
                    b.Navigation("HoaDonDichVus");
                });
#pragma warning restore 612, 618
        }
    }
}
