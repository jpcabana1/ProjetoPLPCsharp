using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPLPCSharp.Models
{
   public  class DocModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Titulo { get; set; }
        public int TempoXP { get; set; }
        public string Usuario { get; set; }
        public string Cargo { get; set; }
        public string Senha { get; set; }
        public string UserStatus { get; set; }

        public DocModel()
        {
            Id = 0;
            Nome = "";
            Titulo = "";
            TempoXP = 0;
            Usuario = "";
            Cargo = "";
            Senha = "";
            UserStatus = "";
        }
    }
}
