using Libs.Entities;

namespace Libs.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<ChiTietHoaDon> ChiTietHoaDonRepository { get; }
        IRepository<ChucVu> ChucVuRepository { get; }
        IRepository<DanhGiaDichVu> DanhGiaDichVuRepository { get; }
        IRepository<DanhGiaPhim> DanhGiaPhimRepository { get; }
        IRepository<DaoDien> DaoDienRepository {  get; }
        IRepository<DichVu> DichVuRepository {  get; }
        IRepository<GiaVe> GiaVeRepository {  get; }
        IRepository<HangSanXuat> HangSanXuatRepository {  get; }
        IRepository<HoaDonDichVu> HoaDonDichVuRepository {  get; }
        IRepository<KhachHang> KhachHangRepository {  get; }
        IRepository<KhuyenMaiDichVu> KhuyenMaiDichVuRepository {  get; }
        IRepository<KhuyenMaiGiaVe> KhuyenMaiGiaVeRepository {  get; }
        IRepository<LoaiDichVu> LoaiDichVuRepository {  get; }
        IRepository<LoaiPhong> LoaiPhongRepository {  get; }
        IRepository<LoaiThanhVien> LoaiThanhVienRepository {  get; }
        IRepository<NhanVien> NhanVienRepository {  get; }
        IRepository<Phim> PhimRepository {  get; }
        IRepository<PhongPhim> PhongPhimRepository {  get; }
        IRepository<TheLoaiPhim> TheLoaiPhimRepository {  get; }
        IRepository<VePhim> VePhimRepository {  get; }

        Task<int> SaveChangesAsync();
        void SaveChanges();
        
    }
}
