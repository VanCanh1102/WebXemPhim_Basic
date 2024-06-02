namespace Libs.Entities
{
    public class GiaVe
    {
        public int Id { get; set; }
        public int Gia { get; set; }
        public int PhongPhimId { get; set; }
        public PhongPhim PhongPhim { get; set; }
    }
}
