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

        public void Add(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Pessoa Get(Guid id)
        {
            return _context.Pessoas.Where(x => x.ID == id).FirstOrDefault();
        }

        public Pessoa Get(string nome)
        {
            return _context.Pessoas.Where(x => x.NomePessoa.ToLower() == nome.ToLower()).FirstOrDefault();
        }

        public IEnumerable<Pessoa> Get(int skip, int take)
        {
            return _context.Pessoas.OrderBy(x => x.NomePessoa).Skip(skip).Take(take).ToList();
        }

        public IEnumerable<Pessoa> GetAll()
        {
            return _context.Pessoas.ToList();
        }

        public void Remove(Pessoa pessoa)
        {
            _context.Pessoas.Remove(pessoa);
            _context.SaveChanges();
        }

        public void Remove(Guid id)
        {
            _context.Pessoas.Remove(_context.Pessoas.Where(x => x.ID == id).FirstOrDefault());
            _context.SaveChanges();
        }

        public void Update(Pessoa pessoa)
        {
            _context.Entry<Pessoa>(pessoa).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
