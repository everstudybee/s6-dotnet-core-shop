using Firma.Data.Data;
using Firma.PortalWWW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Linq;

namespace Firma.PortalWWW.Controllers
{
    public class HomeController : Controller
    {
        private readonly FirmaContext _context;

        public HomeController(FirmaContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            ViewBag.ModelStrony =
                (
                    from strona in _context.Strona
                    orderby strona.Pozycja
                    select strona
                ).ToList();
            ViewBag.ModelAktualnosci =
                (
                    from aktualnosc in _context.Aktualnosc
                    orderby aktualnosc.Pozycja
                    select aktualnosc
                ).ToList();

            //jeśli id == null to wyszukuje stronę Home i przekazuje jej ID do wywołania
            if(id == null)
            {
                if(_context.Strona is not null)
                {
                    foreach(var item in _context.Strona)
                    {
                        if(item.Tytul == "Home")
                            id = item.IdStrony;
                    }
                }
            }

            var pageId = _context.Strona?.Find(id);

            //przekazuję stronę o danym ID do Widoku
            //mogę też do widoku przekazać obiekt z wieloma danymi 
            return View(pageId);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}