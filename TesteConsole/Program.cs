﻿using Infraestructure.Data;
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

            /*
            Setor _set = new Setor() { NomeSetor = "RH" };
            Setor _set2 = new Setor() { NomeSetor = "CP" };


            db.Setores.Add(_set);
            db.Setores.Add(_set2);
            db.SaveChanges();
            
            Console.WriteLine("Setor incluído com sucesso!");
            */

            Console.WriteLine("Listando setores.");
            Console.WriteLine("-----------------");

            var _setores = db.Setores;

                foreach (var s in _setores)
                    Console.WriteLine("ID: " + s.ID.ToString() + " / " + s.NomeSetor);

                Pessoa _pes = new Pessoa() { NomePessoa = "Ederson", Setor = _setores.FirstOrDefault() };
                Pessoa _pes2 = new Pessoa() { NomePessoa = "Carlos", Setor = _setores.FirstOrDefault() };

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
