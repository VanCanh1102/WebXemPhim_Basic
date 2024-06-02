using Libs.Entities;

namespace Libs.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IRepository<ChiTietHoaDon> _cthdRepository;
        private IRepository<ChucVu> _cvRepository;
        private IRepository<DanhGiaDichVu> _dgdvRepository;
        private IRepository<DanhGiaPhim> _dgpRepository;
        private IRepository<DaoDien> _ddRepository;
        private IRepository<DichVu> _dvRepository;
        private IRepository<GiaVe> _gvfRepository;
        private IRepository<HangSanXuat> _hsxRepository;
        private IRepository<HoaDonDichVu> _hddvRepository;
        private IRepository<KhachHang> _khRepository;
        private IRepository<KhuyenMaiDichVu> _kmdvRepository;
        private IRepository<KhuyenMaiGiaVe> _kmgvRepository;
        private IRepository<LoaiDichVu> _ldvRepository;
        private IRepository<LoaiPhong> _lvRepository;
        private IRepository<LoaiThanhVien> _ltvRepository;
        private IRepository<NhanVien> _nvRepository;
        private IRepository<Phim> _pRepository;
        private IRepository<PhongPhim> _ppRepository;
        private IRepository<TheLoaiPhim> _tlpRepository;
        private IRepository<VePhim> _vpRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IRepository<ChiTietHoaDon> ChiTietHoaDonRepository => _cthdRepository ??= new RepositoryBase<ChiTietHoaDon>(_context);
        public IRepository<ChucVu> ChucVuRepository => _cvRepository ??= new RepositoryBase<ChucVu>(_context);
        public IRepository<DanhGiaDichVu> DanhGiaDichVuRepository => _dgdvRepository ??= new RepositoryBase<DanhGiaDichVu>(_context);
        public IRepository<DanhGiaPhim> DanhGiaPhimRepository => _dgpRepository ??= new RepositoryBase<DanhGiaPhim>(_context);
        public IRepository<DaoDien> DaoDienRepository => _ddRepository ??= new RepositoryBase<DaoDien>(_context);
        public IRepository<DichVu> DichVuRepository => _dvRepository ??= new RepositoryBase<DichVu>(_context);
        public IRepository<GiaVe> GiaVeRepository => _gvfRepository ??= new RepositoryBase<GiaVe>(_context);
        public IRepository<HangSanXuat> HangSanXuatRepository => _hsxRepository ??= new RepositoryBase<HangSanXuat>(_context);
        public IRepository<HoaDonDichVu> HoaDonDichVuRepository => _hddvRepository ??= new RepositoryBase<HoaDonDichVu>(_context);
        public IRepository<KhachHang> KhachHangRepository => _khRepository ??= new RepositoryBase<KhachHang>(_context);
        public IRepository<KhuyenMaiDichVu> KhuyenMaiDichVuRepository => _kmdvRepository ??= new RepositoryBase<KhuyenMaiDichVu>(_context);
        public IRepository<KhuyenMaiGiaVe> KhuyenMaiGiaVeRepository => _kmgvRepository ??= new RepositoryBase<KhuyenMaiGiaVe>(_context);
        public IRepository<LoaiDichVu> LoaiDichVuRepository => _ldvRepository ??= new RepositoryBase<LoaiDichVu>(_context);
        public IRepository<LoaiPhong> LoaiPhongRepository => _lvRepository ??= new RepositoryBase<LoaiPhong>(_context);
        public IRepository<LoaiThanhVien> LoaiThanhVienRepository => _ltvRepository ??= new RepositoryBase<LoaiThanhVien>(_context);
        public IRepository<NhanVien> NhanVienRepository => _nvRepository ??= new RepositoryBase<NhanVien>(_context);
        public IRepository<Phim> PhimRepository => _pRepository ??= new RepositoryBase<Phim>(_context);
        public IRepository<PhongPhim> PhongPhimRepository => _ppRepository ??= new RepositoryBase<PhongPhim>(_context);
        public IRepository<TheLoaiPhim> TheLoaiPhimRepository => _tlpRepository ??= new RepositoryBase<TheLoaiPhim>(_context);
        public IRepository<VePhim> VePhimRepository => _vpRepository ??= new RepositoryBase<VePhim>(_context);

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
