namespace Libs.Entities
{
    public class HoaDonDichVu
    {
        public int Id { get; set; }
        public DateTime NgayLap { get; set; }
        public int TongThanhToan { get; set; }
        public int NhanVienId { get; set; }
        public int KhuyenMaiDichVuId { get; set; }
        public int KhachHangId { get; set; }
        public int VePhimId { get; set; }
        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }
        public KhuyenMaiDichVu KhuyenMaiDichVu { get; set; }
        public VePhim VePhim { get; set; }
    }
}
