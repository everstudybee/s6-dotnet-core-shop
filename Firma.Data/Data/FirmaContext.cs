using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Data.Data
{
    internal class FirmaContext
    {
        public FirmaIntranetContext(DbContextOptions<FirmaIntranetContext> options)
            : base(options)
        {
        }

        public DbSet<Aktualnosc> Aktualnosc { get; set; } = default!;

        public DbSet<Strona>? Strona { get; set; }

        public DbSet<Parametr>? Parametr { get; set; }
    }
}
