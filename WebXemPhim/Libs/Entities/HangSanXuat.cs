namespace Libs.Entities
{
    public class HangSanXuat
    {
        public int Id { get; set; }
        public string TenHangSanXuat { get; set; }
        public string MoTaHangSanXuat { get; set; }
        public List<Phim> Phims { get; set; }
    }
}
