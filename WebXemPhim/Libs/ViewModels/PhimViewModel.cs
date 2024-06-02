using Libs.Entities;

namespace Libs.ViewModels
{
    public class PhimViewModel
    {
        public int Id  { get; set; }
        public string TenPhim { get; set; }
        public int TheLoaiPhimId { get; set; }
        public int HangSanXuatId { get; set; }
        public int DaoDienId { get; set; }
        public int NamSanXuat { get; set; }
        public List<DaoDien> DaoDiens { get; set; } = new List<DaoDien>();
        public List<HangSanXuat> HangSanXuats { get; set; } = new List<HangSanXuat>();
        public List<TheLoaiPhim> TheLoaiPhims { get; set; } = new List<TheLoaiPhim>();
    }
}
