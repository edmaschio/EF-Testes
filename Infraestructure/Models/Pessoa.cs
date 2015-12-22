using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    public class Pessoa : EntidadeBase
    {
        public Pessoa() : base()
        {
            Ramais = new HashSet<Ramal>();
        }

        public string NomePessoa { get; set; }

        public virtual Setor Setor { get; set; }
        public ICollection<Ramal> Ramais { get; set; }
    }
}
