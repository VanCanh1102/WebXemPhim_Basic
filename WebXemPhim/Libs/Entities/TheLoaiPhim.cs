namespace Libs.Entities
{
    public class TheLoaiPhim
    {
        public int Id { get; set; }
        public string TenTheLoaiPhim { get; set; }
        public List<Phim> Phims { get; set; }
    }
}
