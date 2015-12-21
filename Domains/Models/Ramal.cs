using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Ramal : EntidadeBase
    {
        public int NumeroRamal { get; set; }
        public TipoRamal TipoRamal { get; set; }
    }
}
