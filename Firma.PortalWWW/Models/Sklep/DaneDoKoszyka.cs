using Firma.Data.Data.Sklep;

namespace Firma.PortalWWW.Models.Sklep
{
    public class DaneDoKoszyka
    {
        public List<ElementKoszyka>? ElementyKoszyka { get; set; }
        public decimal Razem { get; set; }
    }
}
