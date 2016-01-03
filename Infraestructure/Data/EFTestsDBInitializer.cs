using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class EFTestsDBInitializer : DropCreateDatabaseAlways<AppDataContext>
    {
        protected override void Seed(AppDataContext context)
        {
            IList<Setor> setoresPadrao = new List<Setor>();
            setoresPadrao.Add(new Setor() { NomeSetor = "AM" });
            setoresPadrao.Add(new Setor() { NomeSetor = "CP" });
            setoresPadrao.Add(new Setor() { NomeSetor = "RH" });

            context.Setores.AddRange(setoresPadrao);

            IList<Ramal> ramais = new List<Ramal>();

            ramais.Add(new Ramal() { NumeroRamal = 334, TipoRamal = TipoRamal.Fixo });
            ramais.Add(new Ramal() { NumeroRamal = 346, TipoRamal = TipoRamal.Fixo });
            ramais.Add(new Ramal() { NumeroRamal = 220, TipoRamal = TipoRamal.Fixo });
            ramais.Add(new Ramal() { NumeroRamal = 546, TipoRamal = TipoRamal.Opticlient });

            context.Ramais.AddRange(ramais);

            IList<Pessoa> pessoasSetor = new List<Pessoa>();
            pessoasSetor.Add(new Pessoa() { NomePessoa = "Ederson", Setor = setoresPadrao[2] });
            pessoasSetor.Add(new Pessoa() { NomePessoa = "Carlos", Setor = setoresPadrao[1] });
            pessoasSetor.Add(new Pessoa() { NomePessoa = "Matheus", Setor = setoresPadrao[0] });

            pessoasSetor[0].Ramais.Add(ramais[0]);
            
            context.Pessoas.AddRange(pessoasSetor);


            context.SaveChanges();

            base.Seed(context);
        }
    }
}
