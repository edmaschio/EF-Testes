using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Testes.Modelos
{
    public class Pessoa : EntidadeBase
    {
        public Pessoa() : base()
        {

        }

        public string NomePessoa { get; set; }

        public Setor Setor { get; set; }
    }
}
