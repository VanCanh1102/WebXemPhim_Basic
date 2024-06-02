namespace Libs.Entities
{
    public class Phim
    {
        public int Id { get; set; }
        public string TenPhim { get; set; }
        public int TheLoaiPhimId { get; set; }
        public int HangSanXuatId { get; set; }
        public int DaoDienId { get; set; }
        public int NamSanXuat { get; set; }
        public TheLoaiPhim TheLoaiPhim { get; set; }
        public HangSanXuat HangSanXuat { get; set; }
        public DaoDien DaoDien { get; set; }
        public List<VePhim> VePhims { get; set; }
    }
}
