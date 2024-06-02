namespace Libs.Entities
{
    public class PhongPhim
    {
        public int Id { get; set; }
        public int SoPhong { get; set; }
        public int SoLuongKhachChua { get; set; }
        public int LoaiPhongId { get; set; }
        public LoaiPhong LoaiPhong { get; set; }
        public List<GiaVe> GiaVes { get; set; }
    }
}
