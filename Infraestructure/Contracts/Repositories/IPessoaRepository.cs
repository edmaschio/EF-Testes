using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Contracts.Repositories
{
    public interface IPessoaRepository : IDisposable
    {
        IEnumerable<Pessoa> GetAll();
        IEnumerable<Pessoa> Get(int skip, int take);
        Pessoa Get(string nome);
        Pessoa Get(Guid id);
        void Add(Pessoa pessoa);
        void Remove(Guid id);
        void Remove(Pessoa pessoa);
        void Update(Pessoa pessoa);
    }
}
