using EFGetStarted.AspNet5.NewDb.Models;
using Microsoft.AspNet.Mvc;
using System.Linq;

namespace EFGetStarted.AspNet5.NewDb.Controllers
{
    public class ContactosController : Controller
    {
        private ContactoContext _context;

        public ContactosController(ContactoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Contactos.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                _context.Contactos.Add(contacto);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contacto);
        }

    }
}