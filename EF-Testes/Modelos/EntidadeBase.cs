using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Testes.Modelos
{
    public abstract class EntidadeBase
    {
        public EntidadeBase()
        {
            ID = Guid.NewGuid();
            Data = DateTime.Now;
        }

        public Guid ID { get; set; }
        public DateTime Data { get; set; }
        public bool Ativo { get; set; }
    }
}
