using System.ComponentModel.DataAnnotations;

namespace Firma.Intranet.Models.CMS
{
    public class Parametr
    {
        [Key]
        public int IdParametru { get; set; }

        [Required(ErrorMessage = "Kod jest wymagany")]
        [MaxLength(10, ErrorMessage = "Kod powinien zawierać max 10 znaków")]
        public string? Kod { get; set; } // do precyzyjnego rozpoznawania pola po nazwie

        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [MaxLength(30, ErrorMessage = "Nazwa powinna zawierać max 30 znaków")]
        public string? Nazwa { get; set; }

        [Required(ErrorMessage = "Wartość jest wymagana")]
        [Display(Name = "Wartość")]
        public string? Wartosc { get; set; } // treść pola
        
        public string? Opis { get; set; } // dodatkowe uwagi widoczne tylko z poziomu Intranetu

        // Pola dodatkowe, które powinny być w każdym projekcie
        // Te pola mogą być dziedziczone, ponieważ każda tabela je zawiera
        // Można to zrobić na zasadzie dziedziczenia z klasy Record
        //    - Kto dodał
        //    - Kiedy dodał
        //    - Kto zmodyfikował
        //    - Kiedy zmodyfikował
        //    - Kto usunął
        //    - Kiedy usunął
        //    - Czy aktywny
    }
}
