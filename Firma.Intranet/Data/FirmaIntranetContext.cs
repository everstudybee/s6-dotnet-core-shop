using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Firma.Intranet.Models.CMS;

namespace Firma.Intranet.Data
{
    public class FirmaIntranetContext : DbContext
    {
        public FirmaIntranetContext (DbContextOptions<FirmaIntranetContext> options)
            : base(options)
        {
        }

        public DbSet<Aktualnosc> Aktualnosc { get; set; } = default!;

        public DbSet<Strona>? Strona { get; set; }

        public DbSet<Parametr>? Parametr { get; set; }
    }
}
