using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AnimalModel
    {
        public string Nome { get; set; }
        public string Dono { get; set; }
        public int Idade { get; set; }

        public static List<AnimalModel> CriarAnimal()
        {
            var lista = new List<AnimalModel>();

            lista.Add(new AnimalModel() { Nome = "Fifi", Dono = "Fernanda", Idade = 1 });
            lista.Add(new AnimalModel() { Nome = "Max", Dono = "Rafael", Idade = 5 });
            lista.Add(new AnimalModel() { Nome = "Leão", Dono = "Gabriel", Idade = 3 });

            return lista;
        }
    }
}
