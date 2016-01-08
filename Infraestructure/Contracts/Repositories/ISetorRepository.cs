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
        Setor Busca(string nome);
        Setor Busca(Guid id);
        IEnumerable<Setor> Busca(int pular, int pegar);
        void Cadastrar(Setor setor);
        void Alterar(Setor setor);
        void Excluir(Setor setor);
    }
}
