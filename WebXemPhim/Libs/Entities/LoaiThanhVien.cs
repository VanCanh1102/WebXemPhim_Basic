namespace Libs.Entities
{
    public class LoaiThanhVien
    {
        public int Id { get; set; }
        public string TenLoaiThanhVien { get; set; }
        public List<KhachHang> KhachHangs { get; set; }
    }
}
