namespace Libs.Entities
{
    public class LoaiDichVu
    {
        public int Id { get; set; }
        public string TenLoaiDichVu { get; set; }
        public List<DichVu> DichVus { get; set; }
    }
}
