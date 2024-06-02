using Libs.Data;
using Libs.Entities;
using Microsoft.EntityFrameworkCore;

namespace Libs.Services
{
    public interface IVePhimService
    {
        void Save();
        List<VePhim> getVePhimsList();
        VePhim getVePhimById(int id);
        void insertVePhim(VePhim VePhim);
        void updateVePhim(VePhim VePhim);
        void deleteVePhim(int id);
        Task<List<PhongPhim>> GetPhongPhims(); 
        Task<List<KhuyenMaiGiaVe>> GetKhuyenMaiGiaVes();
        Task<List<Phim>> GetPhims();
    }
    public class VePhimService : IVePhimService
    {
        private ApplicationDbContext dbContext;
        private readonly IUnitOfWork _unitOfWork;

        public VePhimService(ApplicationDbContext dbContext, IUnitOfWork unitOfWork)
        {
            this.dbContext = dbContext;
            this._unitOfWork = unitOfWork;
        }
        public void Save()
        {
            _unitOfWork.SaveChanges();
        }

        public List<VePhim> getVePhimsList()
        {
            var vePhims = _unitOfWork.VePhimRepository.GetAll();
            return (List<VePhim>)(vePhims ?? new List<VePhim>());
        }
        public VePhim getVePhimById(int id)
        {
            return _unitOfWork.VePhimRepository.GetById(id);
        }

        public void insertVePhim(VePhim VePhim)
        {
            _unitOfWork.VePhimRepository.Add(VePhim);
            Save();
        }

        public void updateVePhim(VePhim VePhim)
        {
            _unitOfWork.VePhimRepository.Update(VePhim);
            Save();
        }
        public void deleteVePhim(int id)
        {
            VePhim VePhim = _unitOfWork.VePhimRepository.GetById(id);
            if (VePhim != null)
            {
                _unitOfWork.VePhimRepository.Delete(VePhim);
                Save();
            }
        }

        public async Task<List<PhongPhim>> GetPhongPhims()
        {
           return await dbContext.PhongPhims.ToListAsync();
        }

        public async Task<List<KhuyenMaiGiaVe>> GetKhuyenMaiGiaVes()
        {
            return await dbContext.KhuyenMaiGiaVes.ToListAsync();
        }

        public async Task<List<Phim>> GetPhims()
        {
            return await dbContext.Phims.ToListAsync();

        }
    }
}
