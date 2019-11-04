using ProjetoPLPCSharp.Layers.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPLPCSharp.Models
{
    class CargoModel
    {
        public string Cargo { get; set; }
        public int Pontuacao { get; set; }
        public int Tempo { get; set; }
        public int Vagas { get; set; }

        public CargoModel()
        {
            Cargo = "";
            Pontuacao = 0;
            Tempo = 0;
            Vagas = 0;
        }
    }
}
