using EFGetStarted.AspNet5.NewDb.Models;
using Microsoft.AspNet.Mvc;
using System.Linq;

namespace EFGetStarted.AspNet5.NewDb.Controllers
{
    public class ParquesController : Controller
    {
        private ParqueContext _context;

        public ParquesController(ParqueContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Parques.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Parque parque)
        {
            if (ModelState.IsValid)
            {
                _context.Parques.Add(parque);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parque);
        }

    }
}