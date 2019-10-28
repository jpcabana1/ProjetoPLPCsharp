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
    class RepoAtiv : IAtividade
    {

       private IBanco objDados;
       private string Comando;
        public RepoAtiv(string tipoDados)
        {
            this.objDados = new FacBanco().CriarBanco(tipoDados);
        }
            
        public void insert(AtivModel p_obj)
        {
            try
            {
                Comando = "insert into tbAtividade" +
                    "(Descricao, " +
                    "Pontuacao, " +
                    "Status, " +
                    "CodProf)" +               
                    "values (" +
                     "'" + p_obj.Descricao + "'," +
                      "" + p_obj.Pontuacao + "," +
                      "'" + p_obj.Status + "'," +
                      "" + p_obj.CodProf + ")";
                objDados.ExecutaComando(Comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Remove(AtivModel p_obj)
        {
            try
            {
                Comando = "delete from tbAtividade where CodAtiv = " + p_obj.CodAtiv;
                objDados.ExecutaComando(Comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<AtivModel> Select(AtivModel p_obj)
        {
            List<AtivModel> retorno;
            try
            {
                retorno = new List<AtivModel>();
                Comando = "Select * From tbAtividade";

                if (p_obj.CodAtiv != 0)
                {
                    Comando = Comando + " where CodAtiv = " + p_obj.CodAtiv;
                }

                if (p_obj.CodProf != 0)
                {
                    if (Comando.IndexOf("where") == -1)
                    {
                        Comando = Comando + " where CodProf = '" + p_obj.CodProf + "' ";
                    }
                    else
                    {
                        Comando = Comando + " and CodProf = '" + p_obj.CodProf + "' ";
                    }
                }
                if (p_obj.Status != "")
                {
                    if (Comando.IndexOf("where") == -1)
                    {
                        Comando = Comando + " where Status = '" + p_obj.Status + "' ";
                    }
                    else
                    {
                        Comando = Comando + " and Status = '" + p_obj.Status + "' ";
                    }
                }
                if (p_obj.Pontuacao != 0)
                {
                    if (Comando.IndexOf("where") == -1)
                    {
                        Comando = Comando + " where Pontuacao = '" + p_obj.Pontuacao + "' ";
                    }
                    else
                    {
                        Comando = Comando + " and Pontuacao = '" + p_obj.Pontuacao + "' ";
                    }
                }
                retorno = MontaRetorno(objDados.ExecutaSelect(Comando));
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<AtivModel> selectAll()
        {
            List<AtivModel> retorno;
            try
            {
                retorno = new List<AtivModel>();
                Comando = "Select top 100 * From tbAtividade";
                retorno = MontaRetorno(objDados.ExecutaSelect(Comando));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }
        public void Update(AtivModel p_obj)
        {
            try
            {
                Comando = "update tbAtividade " +
                    "set " +
                    "Descricao = '" + p_obj.Descricao + "', " +
                    "Pontuacao = " + p_obj.Pontuacao + ", " +
                    "Status = '" + p_obj.Status + "' " +
                    "where CodAtiv = " + p_obj.CodAtiv;
                objDados.ExecutaComando(Comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        List<AtivModel> MontaRetorno(DataSet data)
        {
            List<AtivModel> retorno;
            AtivModel objAux;
            try
            {
                retorno = new List<AtivModel>();

                for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                {
                    objAux = new AtivModel();
                    objAux.CodAtiv = Convert.ToInt32(data.Tables[0].Rows[i]["CodAtiv"]);
                    objAux.Descricao = data.Tables[0].Rows[i]["Descricao"].ToString();
                    objAux.Pontuacao = Convert.ToInt32(data.Tables[0].Rows[i]["Pontuacao"]);
                    objAux.Status = data.Tables[0].Rows[i]["Status"].ToString();
                    objAux.CodProf = Convert.ToInt32(data.Tables[0].Rows[i]["CodProf"]);
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

       public void testeSQLite(string Comand)
        {
            IBanco SQLiteBanco;
            try
            {
                SQLiteBanco = new FacBanco().CriarBanco("SQLite");               
                foreach (AtivModel item in MontaRetornoSQLite(SQLiteBanco.ExecutaSelect(Comand)))
                {
                    Console.WriteLine(item.CodAtiv);
                    Console.WriteLine(item.Descricao);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        List<AtivModel> MontaRetornoSQLite(DataSet data)
        {
            List<AtivModel> retorno;
            AtivModel objAux;
            try
            {
                retorno = new List<AtivModel>();

                for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                {
                    objAux = new AtivModel();
                    objAux.CodAtiv = Convert.ToInt32(data.Tables[0].Rows[i]["id"]);
                    objAux.Descricao = data.Tables[0].Rows[i]["nome"].ToString();             
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
