using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Contracts.Services
{
    public interface ISetorService : IDisposable
    {
        Setor BuscarPorNome(string nome);
        void Cadastrar(string nome);
        void AlterarNome(string nome);
        IEnumerable<Setor> BuscarPorColecao(int pular, int pegar);
    }
}
