using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class EFTestsDBInitializer : DropCreateDatabaseIfModelChanges<AppDataContext>
    {
        protected override void Seed(AppDataContext context)
        {
            IList<Setor> setoresPadrao = new List<Setor>();

            setoresPadrao.Add(new Setor() { NomeSetor = "AM" });
            setoresPadrao.Add(new Setor() { NomeSetor = "CP" });
            setoresPadrao.Add(new Setor() { NomeSetor = "RH" });

            context.Setores.AddRange(setoresPadrao);

            base.Seed(context);
        }
    }
}
