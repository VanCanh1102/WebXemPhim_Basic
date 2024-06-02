namespace Libs.Entities
{
    public class DaoDien
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QuocTich { get; set; }
        public string MoTa { get; set; }
        public List<Phim> Phims { get; set; }
    }
}
