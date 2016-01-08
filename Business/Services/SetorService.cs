using Infraestructure.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure.Models;
using Infraestructure.Contracts.Repositories;

namespace Business.Services
{
    public class SetorService : ISetorService
    {
        private ISetorRepository _repository;

        public SetorService(ISetorRepository repository)
        {
            _repository = repository;
        }

        public void AlterarNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Setor> BuscarPorColecao(int pular, int pegar)
        {
            throw new NotImplementedException();
        }

        public Setor BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(string nome)
        {
            var temSetor = _repository;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
