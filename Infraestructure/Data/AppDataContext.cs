using System.Data.Entity;
using Infraestructure.Data.Map;
using Infraestructure.Models;

namespace Infraestructure.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext() : base("EF-Testes")
        {
            Database.SetInitializer<AppDataContext>(new EFTestsDBInitializer<AppDataContext>());
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Ramal> Ramais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PessoaMap());
            modelBuilder.Configurations.Add(new SetorMap());
        }
    }
}
