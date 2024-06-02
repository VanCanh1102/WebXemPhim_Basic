using Libs.Entities;
using Libs.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebXemPhim.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class HomeMngController : Controller
    {        
        private readonly IVePhimService _vePhimService;

        public HomeMngController(IVePhimService vePhimService)
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
        public IActionResult Create()
        {
            return View();
        }

        // POST: VePhim/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VePhim vePhim)
        {
            if (ModelState.IsValid)
            {
                _vePhimService.insertVePhim(vePhim);
                return RedirectToAction(nameof(Index));
            }
            return View(vePhim);
        }

        // GET: VePhim/Edit/5
        public IActionResult Edit(int id)
        {
            var vePhim = _vePhimService.getVePhimById(id);
            if (vePhim == null)
            {
                return NotFound();
            }
            return View(vePhim);
        }

        // POST: VePhim/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, VePhim vePhim)
        {
            if (id != vePhim.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _vePhimService.updateVePhim(vePhim);
                return RedirectToAction(nameof(Index));
            }
            return View(vePhim);
        }

        // GET: VePhim/Delete/5
        public IActionResult Delete(int id)
        {
            var vePhim = _vePhimService.getVePhimById(id);
            if (vePhim == null)
            {
                return NotFound();
            }
            return View(vePhim);
        }

        // POST: VePhim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _vePhimService.deleteVePhim(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
