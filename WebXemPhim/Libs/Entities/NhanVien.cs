
namespace Libs.Entities
{
    public class NhanVien
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public int CaLam { get; set; }
        public int Luong { get; set; }
        public int ChucVuId { get; set; }
        public ChucVu ChucVu { get; set; }
        public List<HoaDonDichVu> HoaDonDichVus { get; set; }
    }
}
