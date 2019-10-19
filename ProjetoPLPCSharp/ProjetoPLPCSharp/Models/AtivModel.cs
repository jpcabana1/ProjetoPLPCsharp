using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPLPCSharp.Models
{
    class AtivModel
    {
        public int CodAtiv { get; set; }
        public string Descricao { get; set; }
        public int Pontuacao { get; set; }
        public string Status { get; set; }
        public int CodProf { get; set; }

        public AtivModel()
        {
            CodAtiv = 0;
            Descricao = "";
            Pontuacao = 0;
            Status = "";
            CodProf = 0;
        }
    }
}
