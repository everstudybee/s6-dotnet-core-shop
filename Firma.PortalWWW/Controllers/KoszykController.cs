using Firma.Data.Data;
using Firma.PortalWWW.Models.BusinessLogic;
using Firma.PortalWWW.Models.Sklep;
using Microsoft.AspNetCore.Mvc;

namespace Firma.PortalWWW.Controllers
{
    public class KoszykController : Controller
    {
        public readonly FirmaContext _context;
        public KoszykController(FirmaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //obiekt koszykB jest potrzebny by mieć dostęp do klas biznesowych
            KoszykB koszykB = new KoszykB(_context, HttpContext);

            //wypełniamy obiekt danymi koszyka i wysyłamy go do widoku
            DaneDoKoszyka daneDoKoszyka = new DaneDoKoszyka()
            {
                ElementyKoszyka = await koszykB.GetElementyKoszykaKlienta(),
                Razem = await koszykB.GetRazem()
            };

            return View(daneDoKoszyka);
        }
    }
}
