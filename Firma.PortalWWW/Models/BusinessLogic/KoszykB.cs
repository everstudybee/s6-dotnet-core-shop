using Firma.Data.Data;
using Firma.Data.Data.Sklep;
using Microsoft.EntityFrameworkCore;

namespace Firma.PortalWWW.Models.BusinessLogic
{
    public class KoszykB
    {
        private readonly FirmaContext _context;
        private string idSesjiKoszyka; //przechowuje identyfikator przeglądarki

        public KoszykB(FirmaContext context, HttpContext httpContext)
        {
            _context = context;
            idSesjiKoszyka = GetIdSesjiKoszyka(httpContext);
        }

        private string GetIdSesjiKoszyka(HttpContext httpContext)
        {
            if(httpContext.Session.GetString("IdSesjiKoszyka") == null)
            {
                if(!string.IsNullOrWhiteSpace(httpContext.User.Identity!.Name))
                {
                    httpContext.Session.SetString("IdSesjiKoszyka", httpContext.User.Identity.Name);
                }
                else
                {
                    Guid tempIdSesjiKoszyka = Guid.NewGuid();
                    httpContext.Session.SetString("IdSesjiKoszyka", tempIdSesjiKoszyka.ToString());
                }
            }
            return httpContext.Session.GetString("IdSesjiKoszyka")!;
        }

        public void DodajDoKoszyka(Towar? towar)
        {
            if(towar is not null)
            {
                //sprawdzimy czy w koszyku z tej samej sersji jest już ten sam towar
                var tempElementKoszyka =
                    _context.ElementKoszyka!
                    .Where(e => e.IdSesjiKoszyka == idSesjiKoszyka && e.IdTowaru == towar.IdTowaru)
                    .FirstOrDefault();

                if(tempElementKoszyka != null)
                {
                    //jeżeli towar jest w koszyku to po dodaniu jeszcze raz tylko zwiększa się ilość
                    tempElementKoszyka.Ilosc++;
                }
                else
                {
                    //jeżeli towaru nie ma w koszyku to go tworzymy
                    tempElementKoszyka = new ElementKoszyka()
                    {
                        IdSesjiKoszyka = idSesjiKoszyka,
                        IdTowaru = towar.IdTowaru,
                        Towar = _context.Towar!.Find(towar.IdTowaru)!,
                        Ilosc = 1,
                        DataUtworzenia = DateTime.Now
                    };
                    _context.ElementKoszyka?.Add(tempElementKoszyka); //nowy towar dodajemy do lokalnej kolecji
                }
                _context.SaveChanges(); //zapisujemy zmiany w bazie danych
            }
        }

        //funkcja zwraca wszystkie elementy koszyka dla danego identyfikatora sesji
        public async Task<List<ElementKoszyka>> GetElementyKoszykaKlienta()
        {
            //tu brakuje kodu
            return await _context.ElementKoszyka!.Where(e => e.IdSesjiKoszyka == idSesjiKoszyka).ToListAsync();
        }

        //funkcja zwraca Sumę wartości towarów w koszyku danego klinta
        public async Task<decimal> GetRazem()
        {
            //zwracamy wszystkie iloczyny (ilość razy cena towaru w danej sesji)
            var items =
                (
                from element in _context.ElementKoszyka
                where element.IdSesjiKoszyka == idSesjiKoszyka
                select element.Towar!.Cena * (decimal?)element.Ilosc
            );

            //zwraca wartość koszyka
            return await items.SumAsync() ?? 0;
        }
    }
}
