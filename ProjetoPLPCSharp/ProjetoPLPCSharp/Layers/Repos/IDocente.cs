using ProjetoPLPCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPLPCSharp.Layers.Repos
{
    interface IDocente
    {
        void insert(DocModel p_obj);
        void Update(DocModel p_obj);
        void Remove(DocModel p_obj);
        List<DocModel> Select(DocModel p_obj);
        List<DocModel> selectAll();
    }
}
