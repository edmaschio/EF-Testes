using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infraestructure.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext() : base()
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Setor> Setores { get; set; }
    }
}
