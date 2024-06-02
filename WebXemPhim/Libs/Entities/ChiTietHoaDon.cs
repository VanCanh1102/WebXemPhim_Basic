namespace Libs.Entities
{
    public class ChiTietHoaDon
    {
        public int Id { get; set; }
        public int HoaDonDichVuId { get; set; }
        public int DichVuId { get; set; }
        public int SoLuong { get; set; }
        public int GiaApDung { get; set; }
        public int TongGia { get; set; }
        public HoaDonDichVu HoaDonDichVu { get; set; }
        public DichVu DichVu { get; set; }
    }
}
