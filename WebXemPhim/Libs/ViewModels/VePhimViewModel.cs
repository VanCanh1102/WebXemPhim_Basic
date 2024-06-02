using Libs.Entities;

namespace Libs.ViewModels
{
    public class VePhimViewModel
    {
        public int Id { get; set; }
        public DateTime ThoiGian { get; set; }
        public int PhongPhimId { get; set; }
        public int KhuyenMaiGiaVeId { get; set; }
        public int SoChoNgoi { get; set; }
        public int TongThanhToan { get; set; }
        public int PhimId { get; set; }

        public List<PhongPhim> PhongPhims { get; set; } = new List<PhongPhim>();
        public List<KhuyenMaiGiaVe> KhuyenMaiGiaVes { get; set; } = new List<KhuyenMaiGiaVe>();
        public List<Phim> Phims { get; set; } = new List<Phim>();
    }
}
