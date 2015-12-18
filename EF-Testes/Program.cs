using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Testes.Modelos;
using EF_Testes.Modelos.Context;

namespace EF_Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TestesEFContext())
            {
                Setor _set = new Setor() { NomeSetor = "RH" };
                Setor _set2 = new Setor() { NomeSetor = "CP" };

                db.Setores.Add(_set);
                db.Setores.Add(_set2);
                db.SaveChanges();

                Console.WriteLine("Setor incluído com sucesso!");

                Console.WriteLine("Listando setores.");
                Console.WriteLine("-----------------");
                var _setores = db.Setores;

                foreach (var s in _setores)
                    Console.WriteLine("ID: " + s.ID.ToString() + " / " + s.NomeSetor);

                Pessoa _pes = new Pessoa() { NomePessoa = "Ederson", Setor = _set };
                Pessoa _pes2 = new Pessoa() { NomePessoa = "Carlos", Setor = _set2 };

                db.Pessoas.Add(_pes);
                db.Pessoas.Add(_pes2);
                db.SaveChanges();

                Console.WriteLine("Listando Pessoas.");
                Console.WriteLine("-----------------");

                foreach (var p in db.Pessoas)
                {
                    Console.WriteLine("ID: " + p.ID.ToString() + " / Nome: " +
                        p.NomePessoa + " / Setor: " + p.Setor.NomeSetor +
                        " / Data: " + p.Data);
                }

                Console.ReadKey();
            }
        }
    }
}
