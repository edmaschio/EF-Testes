using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    public class Setor : EntidadeBase
    {
        public Setor() : base()
        {
            Pessoas = new HashSet<Pessoa>();
        }

        public Setor(string nome)
        {
            Pessoas = new HashSet<Pessoa>();
            NomeSetor = nome;
        }

        public string NomeSetor { get; set; }

        public virtual ICollection<Pessoa> Pessoas { get; set; }
    }
}
