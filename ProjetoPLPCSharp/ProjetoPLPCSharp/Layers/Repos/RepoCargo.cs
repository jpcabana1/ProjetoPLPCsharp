using ProjetoPLPCSharp.Layers.DataBases;
using ProjetoPLPCSharp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPLPCSharp.Layers.Repos
{
    class RepoCargo : ICargo
    {
        private IBanco objDados;
        private string Comando;
        public RepoCargo(string tipoDados)
        {
            this.objDados = new FacBanco().CriarBanco(tipoDados);
        }
        public List<CargoModel> Select(string cargo)
        {
            List<CargoModel> Retorno;
            try
            {
                Comando = "Select * from tbCargo where Cargo = '"+ cargo + "'";
                Retorno = MontaRetorno(objDados.ExecutaSelect(Comando));
                return Retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<CargoModel> SelectAll()
        {
            List<CargoModel> Retorno;
            try
            {
                Comando = "Select * from tbCargo";
                Retorno = MontaRetorno(objDados.ExecutaSelect(Comando));
                return Retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(CargoModel cargoModel)
        {
            try
            {
                Comando = "Update tbCargo set ";
                Comando = Comando + " Vagas = " + cargoModel.Vagas;
                Comando = Comando + " Where Cargo = '" + cargoModel.Cargo + "'";
                objDados.ExecutaComando(Comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        List<CargoModel> MontaRetorno(DataSet data)
        {
            List<CargoModel> retorno;
            CargoModel objAux;
            try
            {
                retorno = new List<CargoModel>();

                for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                {
                    objAux = new CargoModel();
                    objAux.ID = Convert.ToInt32(data.Tables[0].Rows[i]["id"]);
                    objAux.Vagas = Convert.ToInt32(data.Tables[0].Rows[i]["Vagas"]);                  
                    objAux.Pontuacao = Convert.ToInt32(data.Tables[0].Rows[i]["Pontuacao"]);                 
                    objAux.Tempo = Convert.ToInt32(data.Tables[0].Rows[i]["Tempo"]);
                    objAux.Cargo = data.Tables[0].Rows[i]["Cargo"].ToString();
                    retorno.Add(objAux);
                    objAux = null;
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
