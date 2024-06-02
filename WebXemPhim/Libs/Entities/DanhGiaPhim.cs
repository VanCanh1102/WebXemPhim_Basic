namespace Libs.Entities
{
    public class DanhGiaPhim
    {
        public int Id { get; set; }
        public int SoDiemCham { get; set; }
        public int PhimId { get; set; }
        public int KhachHangId { get; set; }
        public KhachHang KhachHang { get; set; }
        public Phim Phim { get; set; }
    }
}
