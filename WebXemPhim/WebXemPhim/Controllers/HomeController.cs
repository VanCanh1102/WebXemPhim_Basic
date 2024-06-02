using Libs.Entities;
using Libs.Services;
using Microsoft.AspNetCore.Mvc;
using Libs.ViewModels;

namespace WebXemPhim.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPhimService _phimService;

        public HomeController(IPhimService phimService)
        {
            _phimService = phimService;
        }

        // GET: VePhim
        public IActionResult Index()
        {
            var vePhims = _phimService.getPhimsList();
            return View(vePhims);
        }

        // GET: VePhim/Details/5
        public IActionResult Details(int id)
        {
            var vePhim = _phimService.getPhimById(id);
            if (vePhim == null)
            {
                return NotFound();
            }
            return View(vePhim);
        }

        // GET: VePhim/Create
        public async Task<IActionResult> Create()
        {
            var daoDiens = await _phimService.GetDaoDiens() ?? new List<DaoDien>();
            var hangSanXuats = await _phimService.GetHangSanXuats() ?? new List<HangSanXuat>();
            var theLoaiPhims = await _phimService.GetTheLoaiPhims() ?? new List<TheLoaiPhim>();
            var phimModel = new PhimViewModel
            {
                DaoDiens = daoDiens,
                HangSanXuats = hangSanXuats,
                TheLoaiPhims = theLoaiPhims
            };

            return View(phimModel);
        }

        // POST: VePhim/Create
        [HttpPost]
        public IActionResult Create(PhimViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var phim = new Phim
                {
                    TenPhim = viewModel.TenPhim,
                    TheLoaiPhimId = viewModel.TheLoaiPhimId,
                    HangSanXuatId = viewModel.HangSanXuatId,
                    DaoDienId = viewModel.DaoDienId,
                    NamSanXuat = viewModel.NamSanXuat
                };
                _phimService.insertPhim(phim);
                return RedirectToAction(nameof(Index));
            }

            // In case of error, refill the lists
            viewModel.DaoDiens = _phimService.GetDaoDiens().Result;
            viewModel.HangSanXuats = _phimService.GetHangSanXuats().Result;
            viewModel.TheLoaiPhims = _phimService.GetTheLoaiPhims().Result;
            return View(viewModel);
        }

        // GET: VePhim/Edit/5
        public IActionResult Edit(int id)
        {
            var phim = _phimService.getPhimById(id);
            if (phim == null)
            {
                return NotFound();
            }

            var viewModel = new PhimViewModel
            {
                Id = phim.Id,
                TenPhim = phim.TenPhim,
                TheLoaiPhimId = phim.TheLoaiPhimId,
                HangSanXuatId = phim.HangSanXuatId,
                DaoDienId = phim.DaoDienId,
                NamSanXuat = phim.NamSanXuat,
                DaoDiens = _phimService.GetDaoDiens().Result,
                HangSanXuats = _phimService.GetHangSanXuats().Result,
                TheLoaiPhims = _phimService.GetTheLoaiPhims().Result
            };

            return View(viewModel);
        }

        // POST: VePhim/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, PhimViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var phim = new Phim
                {
                    Id = viewModel.Id,
                    TenPhim = viewModel.TenPhim,
                    TheLoaiPhimId = viewModel.TheLoaiPhimId,
                    HangSanXuatId = viewModel.HangSanXuatId,
                    DaoDienId = viewModel.DaoDienId,
                    NamSanXuat = viewModel.NamSanXuat
                };
                _phimService.updatePhim(phim);
                return RedirectToAction(nameof(Index));
            }

            // In case of error, refill the lists
            viewModel.DaoDiens = _phimService.GetDaoDiens().Result;
            viewModel.HangSanXuats = _phimService.GetHangSanXuats().Result;
            viewModel.TheLoaiPhims = _phimService.GetTheLoaiPhims().Result;
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                var phim = _phimService.getPhimById(id);
                if(phim != null)
                {
                    _phimService.deletePhim(id);
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
