using Infraestructure.Data;
using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new AppDataContext();

            Console.WriteLine("Listando setores.");
            Console.WriteLine("-----------------");

            var _setores = db.Setores.OrderBy(s => s.NomeSetor);

            foreach (var s in _setores)
                Console.WriteLine("ID: " + s.ID.ToString() + " / " + s.NomeSetor);

            Console.WriteLine();
            Console.WriteLine("Listando Pessoas.");
            Console.WriteLine("-----------------");

            foreach (var p in db.Pessoas.OrderBy(p => p.NomePessoa))
            {
                Console.WriteLine("ID: " + p.ID.ToString() + " / Nome: " +
                    p.NomePessoa + " / Setor: " + p.Setor.NomeSetor +
                    " / Data: " + p.Data);
            }

            Console.WriteLine();
            Console.WriteLine("Listando Ramais");
            Console.WriteLine("---------------");

            foreach (var r in db.Ramais)
            {
                Console.WriteLine("ID: " + r.ID.ToString() + " - Nro: " +
                    r.NumeroRamal + " / Tipo: " + r.TipoRamal.ToString() + 
                    " / Data: " + r.Data);
            }

            Console.ReadKey();
        }
    }
}
