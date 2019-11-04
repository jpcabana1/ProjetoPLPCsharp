using ProjetoPLPCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPLPCSharp.Layers.Repos
{
    interface ICargo
    {
        List<CargoModel> Select(string cargo);
        List<CargoModel> SelectAll();
        void Update(CargoModel cargoModel);

    }
}
