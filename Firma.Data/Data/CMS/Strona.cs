using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Firma.Data.Data.CMS
{
    internal class Strona
    {
        [Key]
        public int IdStrony { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł odnośnika")]
        [MaxLength(10, ErrorMessage = "Tytuł powinien zawierać max. 10 znaków")]
        [Display(Name = "Tytuł odnośnika")]
        public string? LinkTytul { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł strony")]
        [MaxLength(30, ErrorMessage = "Tytuł strony powinien zawierać max. 30 znaków")]
        [Display(Name = "Tytuł strony")]
        public string? Tytul { get; set; }

        [Display(Name = "Treść")]
        [Column(TypeName = "nvarchar(MAX)")]
        public string? Tresc { get; set; }

        [Required(ErrorMessage = "Pozycja jest wymagana")]
        [Display(Name = "Pozycja wyświetlania")]
        public int Pozycja { get; set; }

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
