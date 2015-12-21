using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Infraestructure.Data.Map;

namespace Infraestructure.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext() : base()
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Ramal> Ramais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PessoaMap());
        }
    }
}
