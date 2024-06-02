using Libs.Data;
using Libs.Entities;
using Microsoft.EntityFrameworkCore;

namespace Libs.Services
{
    public interface IPhimService
    {
        void Save();
        List<Phim> getPhimsList();
        Phim getPhimById(int id);
        void insertPhim(Phim Phim);
        void updatePhim(Phim Phim);
        void deletePhim(int id);
        Task<List<DaoDien>> GetDaoDiens();
        Task<List<HangSanXuat>> GetHangSanXuats();
        Task<List<TheLoaiPhim>> GetTheLoaiPhims();
    }
    public class PhimService : IPhimService
    {
        private ApplicationDbContext dbContext;
        private readonly IUnitOfWork _unitOfWork;

        public async Task<List<DaoDien>> GetDaoDiens()
        {
            return await dbContext.DaoDiens.ToListAsync() ?? new List<DaoDien>();
        }

        public async Task<List<HangSanXuat>> GetHangSanXuats()
        {
            return await dbContext.HangSanXuats.ToListAsync() ?? new List<HangSanXuat>();
        }

        public async Task<List<TheLoaiPhim>> GetTheLoaiPhims()
        {
            return await dbContext.TheLoaiPhims.ToListAsync() ?? new List<TheLoaiPhim>();
        }

        public PhimService(ApplicationDbContext dbContext, IUnitOfWork unitOfWork)
        {
            this.dbContext = dbContext;
            this._unitOfWork = unitOfWork;
        }
        public void Save()
        {
            _unitOfWork.SaveChanges();
        }

        public List<Phim> getPhimsList()
        {
            return (List<Phim>)_unitOfWork.PhimRepository.GetAll();
        }
        public Phim getPhimById(int id)
        {
            return _unitOfWork.PhimRepository.GetById(id);
        }

        public void insertPhim(Phim Phim)
        {
            _unitOfWork.PhimRepository.Add(Phim);
            Save();
        }

        public void updatePhim(Phim Phim)
        {
            _unitOfWork.PhimRepository.Update(Phim);
            Save();
        }
        public void deletePhim(int id)
        {
            Phim Phim = _unitOfWork.PhimRepository.GetById(id);
            if (Phim != null)
            {
                _unitOfWork.PhimRepository.Delete(Phim);
                Save();
            }
        }
    }
}
