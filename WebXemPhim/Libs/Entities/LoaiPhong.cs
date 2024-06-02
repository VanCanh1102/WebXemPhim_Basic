namespace Libs.Entities
{
    public class LoaiPhong
    {
        public int Id { get; set; }
        public string TenLoaiPhong { get; set; }
        public List<PhongPhim> PhongPhims { get; set; }
    }
}
