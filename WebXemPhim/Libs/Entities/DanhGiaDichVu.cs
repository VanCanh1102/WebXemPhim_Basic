namespace Libs.Entities
{
    public class DanhGiaDichVu
    {
        public int Id { get; set; }
        public string NoiDung { get; set; }
        public int DichVuId { get; set; }
        public int KhachHangId { get; set; }
        public DichVu DichVu { get; set; }
        public KhachHang KhachHang { get; set; }
    }
}
