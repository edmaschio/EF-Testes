using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Setor : EntidadeBase
    {
        public Setor() : base()
        {
            
        }

        public string NomeSetor { get; set; }
    }
}
