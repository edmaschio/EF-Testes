using Infraestructure.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure.Models;
using Infraestructure.Data;

namespace Infraestructure.Repositories
{
    public class SetorRepository : ISetorRepository
    {
        private AppDataContext _context;

        public SetorRepository(AppDataContext context)
        {
            _context = context;
        }

        public IEnumerable<Setor> BuscaTodos()
        {
            return _context.Setores;
        }

        public Setor Busca(string nome)
        {
            return _context.Setores.Where(x => x.NomeSetor == nome).FirstOrDefault();
        }

        public Setor Busca(Guid id)
        {
            return _context.Setores.Where(x => x.ID == id).FirstOrDefault();
        }

        public IEnumerable<Setor> Busca(int pular, int pegar)
        {
            return _context.Setores.OrderBy(x => x.NomeSetor).Skip(pular).Take(pegar).ToList();
        }

        public void Inclui(Setor setor)
        {
            _context.Setores.Add(setor);
            _context.SaveChanges();
        }

        public void Altera(Setor setor)
        {
            _context.Entry<Setor>(setor).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Exclui(Setor setor)
        {
            _context.Setores.Remove(setor);
            _context.SaveChanges();
        }

        public void Exclui(Guid id)
        {
            _context.Setores.Remove(_context.Setores.Where(x => x.ID == id).FirstOrDefault());
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
