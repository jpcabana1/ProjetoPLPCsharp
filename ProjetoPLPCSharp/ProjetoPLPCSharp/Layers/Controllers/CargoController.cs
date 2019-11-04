using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoPLPCSharp.Layers.Repos;
using ProjetoPLPCSharp.Models;
namespace ProjetoPLPCSharp.Layers.Controllers
{
    class CargoController
    {
        RepoCargo RepoCargo;

        public CargoController()
        {
            this.RepoCargo = new RepoCargo("SQLServer");
        }

        public List<CargoModel> SelecionarCargo(string Cargo)
        {
            try
            {
                return RepoCargo.Select(Cargo);
            }
            catch (Exception ex)
            {
                throw ex;
            }        
        }

        public List<CargoModel> SelecionarTodos()
        {
            try
            {
                return RepoCargo.SelectAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarCargo(CargoModel p_obj)
        {
            try
            {
                RepoCargo.Update(p_obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
