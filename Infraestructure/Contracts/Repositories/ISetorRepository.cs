using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Contracts.Repositories
{
    public interface ISetorRepository : IDisposable
    {
        IEnumerable<Setor> BuscaTodos();
        IEnumerable<Setor> Busca(int pular, int pegar);
        Setor Busca(string nome);
        Setor Busca(Guid id);
        void Inclui(Setor setor);
        void Altera(Setor setor);
        void Exclui(Guid id);
        void Exclui(Setor setor);
    }
}
