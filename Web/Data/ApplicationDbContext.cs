using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Web.Models;
using ControleAtivosTI.Models;

namespace Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Web.Models.SupImp> SupImp { get; set; }
        public DbSet<Web.Models.Unidades> Unidades { get; set; }
        public DbSet<Web.Models.Equipamentos> Equipamentos { get; set; }
        public DbSet<ControleAtivosTI.Models.Portifolio> Portifolios { get; set; }
        public DbSet<Web.Models.Linha> Linha { get; set; }
        public DbSet<Web.Models.Ramal> Ramal { get; set; }
        public DbSet<Web.Models.Camera> Camera { get; set; }
        public DbSet<Web.Models.Setor> Setor { get; set; }
    }
}
