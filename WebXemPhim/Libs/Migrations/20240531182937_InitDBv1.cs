using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Libs.Migrations
{
    public partial class InitDBv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChucVus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DaoDiens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuocTich = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaoDiens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HangSanXuats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHangSanXuat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTaHangSanXuat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangSanXuats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMaiDichVus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MieuTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhanTramGiam = table.Column<int>(type: "int", nullable: false),
                    Han = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMaiDichVus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMaiGiaVes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MieuTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhanTramGiam = table.Column<int>(type: "int", nullable: false),
                    Han = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMaiGiaVes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiDichVus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiDichVu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDichVus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiPhongs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiPhong = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiPhongs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiThanhViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiThanhVien = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiThanhViens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TheLoaiPhims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTheLoaiPhim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoaiPhims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaLam = table.Column<int>(type: "int", nullable: false),
                    Luong = table.Column<int>(type: "int", nullable: false),
                    ChucVuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanViens_ChucVus_ChucVuId",
                        column: x => x.ChucVuId,
                        principalTable: "ChucVus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DichVus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDichVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiDichVuId = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DichVus_LoaiDichVus_LoaiDichVuId",
                        column: x => x.LoaiDichVuId,
                        principalTable: "LoaiDichVus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhongPhims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoPhong = table.Column<int>(type: "int", nullable: false),
                    SoLuongKhachChua = table.Column<int>(type: "int", nullable: false),
                    LoaiPhongId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongPhims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhongPhims_LoaiPhongs_LoaiPhongId",
                        column: x => x.LoaiPhongId,
                        principalTable: "LoaiPhongs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiThanhVienId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhachHangs_LoaiThanhViens_LoaiThanhVienId",
                        column: x => x.LoaiThanhVienId,
                        principalTable: "LoaiThanhViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TheLoaiPhimId = table.Column<int>(type: "int", nullable: false),
                    HangSanXuatId = table.Column<int>(type: "int", nullable: false),
                    DaoDienId = table.Column<int>(type: "int", nullable: false),
                    NamSanXuat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phims_DaoDiens_DaoDienId",
                        column: x => x.DaoDienId,
                        principalTable: "DaoDiens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phims_HangSanXuats_HangSanXuatId",
                        column: x => x.HangSanXuatId,
                        principalTable: "HangSanXuats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phims_TheLoaiPhims_TheLoaiPhimId",
                        column: x => x.TheLoaiPhimId,
                        principalTable: "TheLoaiPhims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiaVes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gia = table.Column<int>(type: "int", nullable: false),
                    PhongPhimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaVes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiaVes_PhongPhims_PhongPhimId",
                        column: x => x.PhongPhimId,
                        principalTable: "PhongPhims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhGiaDichVus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DichVuId = table.Column<int>(type: "int", nullable: false),
                    KhachHangId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGiaDichVus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DanhGiaDichVus_DichVus_DichVuId",
                        column: x => x.DichVuId,
                        principalTable: "DichVus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhGiaDichVus_KhachHangs_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonDichVus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongThanhToan = table.Column<int>(type: "int", nullable: false),
                    NhanVienId = table.Column<int>(type: "int", nullable: false),
                    KhuyenMaiDichVuId = table.Column<int>(type: "int", nullable: false),
                    KhachHangId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonDichVus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonDichVus_KhachHangs_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonDichVus_KhuyenMaiDichVus_KhuyenMaiDichVuId",
                        column: x => x.KhuyenMaiDichVuId,
                        principalTable: "KhuyenMaiDichVus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonDichVus_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhGiaPhims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoDiemCham = table.Column<int>(type: "int", nullable: false),
                    PhimId = table.Column<int>(type: "int", nullable: false),
                    KhachHangId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGiaPhims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DanhGiaPhims_KhachHangs_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhGiaPhims_Phims_PhimId",
                        column: x => x.PhimId,
                        principalTable: "Phims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoaDonDichVuId = table.Column<int>(type: "int", nullable: false),
                    DichVuId = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaApDung = table.Column<int>(type: "int", nullable: false),
                    TongGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDons_DichVus_DichVuId",
                        column: x => x.DichVuId,
                        principalTable: "DichVus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDons_HoaDonDichVus_HoaDonDichVuId",
                        column: x => x.HoaDonDichVuId,
                        principalTable: "HoaDonDichVus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VePhims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhongPhimId = table.Column<int>(type: "int", nullable: false),
                    KhuyenMaiGiaVeId = table.Column<int>(type: "int", nullable: false),
                    SoChoNgoi = table.Column<int>(type: "int", nullable: false),
                    TongThanhToan = table.Column<int>(type: "int", nullable: false),
                    HoaDonDichVuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VePhims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VePhims_HoaDonDichVus_HoaDonDichVuId",
                        column: x => x.HoaDonDichVuId,
                        principalTable: "HoaDonDichVus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VePhims_KhuyenMaiGiaVes_KhuyenMaiGiaVeId",
                        column: x => x.KhuyenMaiGiaVeId,
                        principalTable: "KhuyenMaiGiaVes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VePhims_PhongPhims_PhongPhimId",
                        column: x => x.PhongPhimId,
                        principalTable: "PhongPhims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDons_DichVuId",
                table: "ChiTietHoaDons",
                column: "DichVuId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDons_HoaDonDichVuId",
                table: "ChiTietHoaDons",
                column: "HoaDonDichVuId");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGiaDichVus_DichVuId",
                table: "DanhGiaDichVus",
                column: "DichVuId");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGiaDichVus_KhachHangId",
                table: "DanhGiaDichVus",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGiaPhims_KhachHangId",
                table: "DanhGiaPhims",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGiaPhims_PhimId",
                table: "DanhGiaPhims",
                column: "PhimId");

            migrationBuilder.CreateIndex(
                name: "IX_DichVus_LoaiDichVuId",
                table: "DichVus",
                column: "LoaiDichVuId");

            migrationBuilder.CreateIndex(
                name: "IX_GiaVes_PhongPhimId",
                table: "GiaVes",
                column: "PhongPhimId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonDichVus_KhachHangId",
                table: "HoaDonDichVus",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonDichVus_KhuyenMaiDichVuId",
                table: "HoaDonDichVus",
                column: "KhuyenMaiDichVuId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonDichVus_NhanVienId",
                table: "HoaDonDichVus",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHangs_LoaiThanhVienId",
                table: "KhachHangs",
                column: "LoaiThanhVienId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_ChucVuId",
                table: "NhanViens",
                column: "ChucVuId");

            migrationBuilder.CreateIndex(
                name: "IX_Phims_DaoDienId",
                table: "Phims",
                column: "DaoDienId");

            migrationBuilder.CreateIndex(
                name: "IX_Phims_HangSanXuatId",
                table: "Phims",
                column: "HangSanXuatId");

            migrationBuilder.CreateIndex(
                name: "IX_Phims_TheLoaiPhimId",
                table: "Phims",
                column: "TheLoaiPhimId");

            migrationBuilder.CreateIndex(
                name: "IX_PhongPhims_LoaiPhongId",
                table: "PhongPhims",
                column: "LoaiPhongId");

            migrationBuilder.CreateIndex(
                name: "IX_VePhims_HoaDonDichVuId",
                table: "VePhims",
                column: "HoaDonDichVuId");

            migrationBuilder.CreateIndex(
                name: "IX_VePhims_KhuyenMaiGiaVeId",
                table: "VePhims",
                column: "KhuyenMaiGiaVeId");

            migrationBuilder.CreateIndex(
                name: "IX_VePhims_PhongPhimId",
                table: "VePhims",
                column: "PhongPhimId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDons");

            migrationBuilder.DropTable(
                name: "DanhGiaDichVus");

            migrationBuilder.DropTable(
                name: "DanhGiaPhims");

            migrationBuilder.DropTable(
                name: "GiaVes");

            migrationBuilder.DropTable(
                name: "VePhims");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DichVus");

            migrationBuilder.DropTable(
                name: "Phims");

            migrationBuilder.DropTable(
                name: "HoaDonDichVus");

            migrationBuilder.DropTable(
                name: "KhuyenMaiGiaVes");

            migrationBuilder.DropTable(
                name: "PhongPhims");

            migrationBuilder.DropTable(
                name: "LoaiDichVus");

            migrationBuilder.DropTable(
                name: "DaoDiens");

            migrationBuilder.DropTable(
                name: "HangSanXuats");

            migrationBuilder.DropTable(
                name: "TheLoaiPhims");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "KhuyenMaiDichVus");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "LoaiPhongs");

            migrationBuilder.DropTable(
                name: "LoaiThanhViens");

            migrationBuilder.DropTable(
                name: "ChucVus");
        }
    }
}
