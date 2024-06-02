using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Libs.Entities;


namespace Libs
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<DanhGiaDichVu> DanhGiaDichVus { get; set; }
        public DbSet<DanhGiaPhim> DanhGiaPhims { get; set; }
        public DbSet<DaoDien> DaoDiens { get; set; }
        public DbSet<DichVu> DichVus { get; set; }
        public DbSet<GiaVe> GiaVes { get; set; }
        public DbSet<HangSanXuat> HangSanXuats { get; set; }
        public DbSet<HoaDonDichVu> HoaDonDichVus { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<KhuyenMaiDichVu> KhuyenMaiDichVus { get; set; }
        public DbSet<KhuyenMaiGiaVe> KhuyenMaiGiaVes { get; set; }
        public DbSet<LoaiDichVu> LoaiDichVus { get; set; }
        public DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public DbSet<LoaiThanhVien> LoaiThanhViens { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Phim> Phims { get; set; }
        public DbSet<PhongPhim> PhongPhims { get; set; }
        public DbSet<TheLoaiPhim> TheLoaiPhims { get; set; }
        public DbSet<VePhim> VePhims { get; set; }
    }
}
