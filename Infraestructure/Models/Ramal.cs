using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    public class Ramal : EntidadeBase
    {
        public Ramal()
        {
            Pessoas = new HashSet<Pessoa>();
        }

        public int NumeroRamal { get; set; }
        public TipoRamal TipoRamal { get; set; }

        public virtual ICollection<Pessoa> Pessoas { get; set; }
    }
}
