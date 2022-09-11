using System.ComponentModel.DataAnnotations;

namespace Firma.Data.Data.Sklep
{
    public class ElementKoszyka
    {
        [Key]
        public int IdElementuKoszyka { get; set; }

        public string IdSesjiKoszyka { get; set; } //przechowuje identyfikator przeglądarki

        public int IdTowaru { get; set; }

        public Towar Towar { get; set; }

        public int Ilosc { get; set; }

        public DateTime DataUtworzenia { get; set; }
    }
}
