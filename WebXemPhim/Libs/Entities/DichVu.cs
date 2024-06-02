namespace Libs.Entities
{
    public class DichVu
    {
        public int Id { get; set; }
        public string TenDichVu { get; set; }
        public int LoaiDichVuId { get; set; }
        public int Gia { get; set; }
        public LoaiDichVu LoaiDichVu { get; set; }
        public List<DanhGiaDichVu> DanhGiaDichVus { get; set; }
        public List<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
