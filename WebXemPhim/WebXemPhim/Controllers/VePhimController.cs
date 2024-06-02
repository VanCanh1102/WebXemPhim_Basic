using Libs.Entities;
using Libs.Services;
using Libs.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace WebXemPhim.Controllers
{
    public class VePhimController : Controller
    {
        private readonly IVePhimService _vePhimService;

        public VePhimController(IVePhimService vePhimService)
        {
            _vePhimService = vePhimService;
        }

        // GET: VePhim
        public IActionResult Index()
        {
            var vePhims = _vePhimService.getVePhimsList();
            return View(vePhims);
        }

        // GET: VePhim/Details/5
        public IActionResult Details(int id)
        {
            var vePhim = _vePhimService.getVePhimById(id);
            if (vePhim == null)
            {
                return NotFound();
            }
            return View(vePhim);
        }

        // GET: VePhim/Create
        public async Task<IActionResult> Create()
        {
            var phongPhims = await _vePhimService.GetPhongPhims() ?? new List<PhongPhim>();
            var khuyenMaiGiaVes = await _vePhimService.GetKhuyenMaiGiaVes() ?? new List<KhuyenMaiGiaVe>();
            var phims = await _vePhimService.GetPhims() ?? new List<Phim>();
            var viewModel = new VePhimViewModel
            {
                PhongPhims = phongPhims,
                KhuyenMaiGiaVes = khuyenMaiGiaVes,
                Phims = phims,
            };
            return View(viewModel);
        }

        // POST: VePhim/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VePhimViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var vePhim = new VePhim
                {
                    ThoiGian = viewModel.ThoiGian,
                    PhongPhimId = viewModel.PhongPhimId,
                    PhimId = viewModel.PhimId,
                    KhuyenMaiGiaVeId = viewModel.KhuyenMaiGiaVeId,
                    SoChoNgoi = viewModel.SoChoNgoi,
                    TongThanhToan = viewModel.TongThanhToan,
                };
                _vePhimService.insertVePhim(vePhim);
                return RedirectToAction(nameof(Index));
            }
            viewModel.PhongPhims = _vePhimService.GetPhongPhims().Result;
            viewModel.KhuyenMaiGiaVes = _vePhimService.GetKhuyenMaiGiaVes().Result;
            viewModel.Phims = _vePhimService.GetPhims().Result;

            return View(viewModel);
        }

        // GET: VePhim/Edit/5
        public IActionResult Edit(int id)
        {
            var vePhim = _vePhimService.getVePhimById(id);
            if (vePhim == null)
            {
                return NotFound();
            }
            var viewModel = new VePhimViewModel
            {
                Id = vePhim.Id,
                ThoiGian = vePhim.ThoiGian,
                TongThanhToan = vePhim.TongThanhToan,
                PhongPhimId = vePhim.PhongPhimId,
                KhuyenMaiGiaVeId = vePhim.KhuyenMaiGiaVeId,
                PhimId = vePhim.PhimId,
                SoChoNgoi = vePhim.SoChoNgoi,
                Phims = _vePhimService.GetPhims().Result,
                PhongPhims = _vePhimService.GetPhongPhims().Result,
                KhuyenMaiGiaVes = _vePhimService.GetKhuyenMaiGiaVes().Result
            };
            return View(viewModel);
        }

        // POST: VePhim/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, VePhimViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var vePhim = _vePhimService.getVePhimById(id); // Lấy thông tin đối tượng từ cơ sở dữ liệu
                if (vePhim == null)
                {
                    return NotFound();
                }

                // Cập nhật thông tin của đối tượng đã lấy từ cơ sở dữ liệu
                vePhim.ThoiGian = viewModel.ThoiGian;
                vePhim.PhongPhimId = viewModel.PhongPhimId;
                vePhim.PhimId = viewModel.PhimId;
                vePhim.KhuyenMaiGiaVeId = viewModel.KhuyenMaiGiaVeId;
                vePhim.SoChoNgoi = viewModel.SoChoNgoi;
                vePhim.TongThanhToan = viewModel.TongThanhToan;

                // Gọi phương thức cập nhật từ service
                _vePhimService.updateVePhim(vePhim);
                return RedirectToAction(nameof(Index));
            }
            viewModel.PhongPhims = _vePhimService.GetPhongPhims().Result;
            viewModel.KhuyenMaiGiaVes = _vePhimService.GetKhuyenMaiGiaVes().Result;
            viewModel.Phims = _vePhimService.GetPhims().Result;
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                var phim = _vePhimService.getVePhimById(id);
                if (phim != null)
                {
                    _vePhimService.deleteVePhim(id);
                    return Ok();
                }
                return BadRequest("Phim cannot be deleted.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}
