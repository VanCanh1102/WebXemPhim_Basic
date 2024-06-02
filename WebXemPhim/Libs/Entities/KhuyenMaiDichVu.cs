namespace Libs.Entities
{
    public class KhuyenMaiDichVu
    {
        public int Id { get; set; }
        public string MieuTa { get; set; }
        public int PhanTramGiam { get; set; }
        public DateTime Han { get; set; }
        public List<HoaDonDichVu> HoaDonDichVus { get; set; }
    }
}
