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
        IEnumerable<Pessoa> BuscaTodos();
        IEnumerable<Pessoa> Busca(int skip, int take);
        Pessoa Busca(string nome);
        Pessoa Busca(Guid id);
        void Inclui(Pessoa pessoa);
        void Altera(Pessoa pessoa);
        void Exclui(Guid id);
        void Exclui(Pessoa pessoa);
    }
}
