using Firma.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Firma.PortalWWW.Controllers
{
    public class SklepController : Controller
    {
        private readonly FirmaContext _context;
        public SklepController(FirmaContext context)
        {
            this._context = context;
        }

        //funkcja wyświetla wszystkie produkty, id to id kategorii
        public async Task<IActionResult> Index(int? id)
        {
            if(_context.Rodzaj is not null)
            {
                ViewBag.ModelRodzaje = await _context.Rodzaj.ToListAsync();

                if(id == null)
                {
                    var pierwszy = await _context.Rodzaj.FirstAsync();
                    id = pierwszy.IdRodzaju;
                }
            }

            if(_context.Towar is not null)
            {
                return View(await _context.Towar.Where(t => t.IdRodzaju == id).ToListAsync());
            }

            return View();
        }
    }
}
