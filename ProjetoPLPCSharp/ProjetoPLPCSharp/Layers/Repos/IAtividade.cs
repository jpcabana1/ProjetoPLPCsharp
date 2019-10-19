using ProjetoPLPCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPLPCSharp.Layers.Repos
{
    interface IAtividade
    {
        void insert(AtivModel p_obj);
        void Update(AtivModel p_obj);
        void Remove(AtivModel p_obj);
        List<AtivModel> Select(AtivModel p_obj);
        List<AtivModel> selectAll(AtivModel p_obj);
    }
}
