using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Firma.Data.Data.Sklep
{
    public class Towar
    {
        [Key]
        public int IdTowaru { get; set; }

        [Required(ErrorMessage = "Kod towaru jest wymagany")]
        public string? Kod { get; set; }

        [Required(ErrorMessage = "Nazwa towaru jest wymagana")]
        public string? Nazwa { get; set; }

        [Required(ErrorMessage = "Cena towaru jest wymagana")]
        [Column(TypeName = "money")]
        public decimal Cena { get; set; }

        [Required(ErrorMessage = "Foto towaru jest wymagane")]
        [Display(Name = "Zdjęcie towaru")]
        public string? Foto { get; set; }

        public string? Opis { get; set; }

        //Towar może mieć jeden Rodzaj
        public int IdRodzaju { get; set; } //Ta sama nazwa co nazwa property IdRodzaju w klasie Rodzaj
        public Rodzaj? Rodzaj { get; set; } //Nazwa property taka sama jak nazwa klasy Rodzaj
    }
}
