using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Testes.Modelos.Context
{
    public class TestesEFContext : DbContext
    {
        public TestesEFContext() : base ()
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Setor> Setores { get; set; }
    }
}
