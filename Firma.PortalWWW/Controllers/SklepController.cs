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
            _context = context;
        }

        //funkcja wyświetla wszystkie produkty, id to id Rodzaju
        public async Task<IActionResult> Index(int? id)
        {
            if(id == null)
            {
                return View(await _context.Towar!.Where(t => t.Promocja).ToListAsync());
            }
            else
            {
                return View(await _context.Towar!.Where(t => t.IdRodzaju == id).ToListAsync());
            }
        }

        //wyswietla szczegóły klikniętego Towaru
        public async Task<IActionResult> Szczegoly(int id)
        {
            ViewBag.ModelRodzaje = await _context.Rodzaj!.ToListAsync();
            return View(await _context.Towar!.Where(t => t.IdTowaru == id).FirstOrDefaultAsync());
        }
    }
}