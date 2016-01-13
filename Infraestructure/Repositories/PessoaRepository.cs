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
    public class PessoaRepository : IPessoaRepository
    {
        private AppDataContext _context;

        public PessoaRepository(AppDataContext context)
        {
            _context = context;
        }

        public Pessoa Busca(Guid id)
        {
            return _context.Pessoas.Where(x => x.ID == id).FirstOrDefault();
        }

        public Pessoa Busca(string nome)
        {
            return _context.Pessoas.Where(x => x.NomePessoa.ToLower() == nome.ToLower()).FirstOrDefault();
        }

        public IEnumerable<Pessoa> Busca(int skip, int take)
        {
            return _context.Pessoas.OrderBy(x => x.NomePessoa).Skip(skip).Take(take).ToList();
        }

        public IEnumerable<Pessoa> BuscaTodos()
        {
            return _context.Pessoas.ToList();
        }

        public void Inclui(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
        }

        public void Altera(Pessoa pessoa)
        {
            _context.Entry<Pessoa>(pessoa).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Exclui(Pessoa pessoa)
        {
            _context.Pessoas.Remove(pessoa);
            _context.SaveChanges();
        }

        public void Exclui(Guid id)
        {
            _context.Pessoas.Remove(_context.Pessoas.Where(x => x.ID == id).FirstOrDefault());
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
