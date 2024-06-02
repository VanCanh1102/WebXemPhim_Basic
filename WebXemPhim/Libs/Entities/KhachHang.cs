namespace Libs.Entities
{
    public class KhachHang
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public int LoaiThanhVienId { get; set; }
        public LoaiThanhVien LoaiThanhVien { get; set; }
        public List<DanhGiaPhim> DanhGiaPhims { get; set; }
        public List<HoaDonDichVu> HoaDonDichVus { get; set; }
    }
}
