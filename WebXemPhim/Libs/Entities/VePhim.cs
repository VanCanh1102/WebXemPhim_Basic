namespace Libs.Entities
{
    public class VePhim
    {
        public int Id { get; set; }
        public DateTime ThoiGian { get; set; }
        public int PhongPhimId { get; set; }
        public int KhuyenMaiGiaVeId { get; set; }
        public int SoChoNgoi { get; set; }
        public int TongThanhToan { get; set; }
        public int PhimId { get; set; }
        public Phim Phim { get; set; }
        public List<HoaDonDichVu> HoaDonDichVus { get; set; }
        public KhuyenMaiGiaVe KhuyenMaiGiaVe { get; set; }
        public PhongPhim PhongPhim { get; set; }
    }
}
