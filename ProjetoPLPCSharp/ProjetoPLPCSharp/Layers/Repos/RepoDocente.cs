using ProjetoPLPCSharp.Layers.DataBases;
using ProjetoPLPCSharp.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProjetoPLPCSharp.Layers.Repos
{
    class RepoDocente : IDocente
    {
        private IBanco objDados;
        private string Comando;
        public RepoDocente(string tipoBanco)
        {
            this.objDados = new FacBanco().CriarBanco(tipoBanco);
        }

        public void insert(DocModel p_obj)
        {
            try
            {
                Comando = "insert into tbUsuario" +
                    "(Nome, " +
                    "Titulo, " +
                    "TempoXP, " +
                    "Usuario," +
                    " Cargo, " +
                    " UserStatus, "+
                    "Senha) " +
                    "values (" +
                     "'" + p_obj.Nome + "'," +
                      "'" + p_obj.Titulo + "'," +
                      "" + p_obj.TempoXP + "," +
                      "'" + p_obj.Usuario + "'," +
                      "'" + p_obj.Cargo + "'," +
                      "'" + p_obj.UserStatus + "', " +
                      "'" + p_obj.Senha + "')";
                objDados.ExecutaComando(Comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Remove(DocModel p_obj)
        {
            try
            {
                Comando = "delete from tbUsuario where id = " + p_obj.Id;
                objDados.ExecutaComando(Comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<DocModel> Select(DocModel p_obj)
        {
            List<DocModel> retorno;
            try
            {
                retorno = new List<DocModel>();
                Comando = "Select * From tbUsuario";

                if (p_obj.Id != 0) {
                    Comando = Comando + " where id = " + p_obj.Id;
                }

                if(p_obj.Usuario != "")
                {
                    if (Comando.IndexOf("where") == -1)
                    {
                        Comando = Comando + " where Usuario =  '" + p_obj.Usuario +"' " ;
                    }else{
                        Comando = Comando + " and Usuario = '" + p_obj.Usuario + "' ";
                    }
                }
                if (p_obj.Senha != "")
                {
                    if (Comando.IndexOf("where") == -1)
                    {
                        Comando = Comando + " where Senha =  '" + p_obj.Senha + "' ";
                    }
                    else
                    {
                        Comando = Comando + " and Senha = '" + p_obj.Senha + "' ";
                    }
                }
                retorno = MontaRetornoSQLite(objDados.ExecutaSelect(Comando));
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<DocModel> selectAll(DocModel p_obj)
        {
            List<DocModel> retorno;
            try
            {          
                retorno = new List<DocModel>();
<<<<<<< HEAD
                Comando = "Select * From tbUsuario LIMIT 100";
                retorno = MontaRetornoSQLite(objDados.ExecutaSelect(Comando));
                return retorno;
=======
                Comando = "Select top 100 * From tbDocente";
                retorno = MontaRetorno(objDados.ExecutaSelect(Comando));
>>>>>>> parent of 5b0831d... Faltando Foto e Promoção
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }
        public void Update(DocModel p_obj)
        {
            try
            {
                Comando = "update tbDocente " +
                    " set " +
                    " Nome = '" + p_obj.Nome + "', " +
                    " Titulo = '" + p_obj.Titulo + "', " +
                    " TempoXP = " + p_obj.TempoXP + ", " +
                    " Usuario = '" + p_obj.Usuario + "', " +
                    " Cargo = '" + p_obj.Cargo + "', " +
                    " Senha = '" + p_obj.Senha +"', " +
                    " UserStatus = '" + p_obj.UserStatus + "' " +
                    " where id = " + p_obj.Id;
                objDados.ExecutaComando(Comando);
            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }
        List<DocModel> MontaRetorno(DataSet data)
        {
            List<DocModel> retorno;
            DocModel objAux;
            try
            {
                retorno = new List<DocModel>();

                for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                {
                    objAux = new DocModel();
                    objAux.Id = Convert.ToInt32(data.Tables[0].Rows[i]["id"]);
                    objAux.Nome = data.Tables[0].Rows[i]["Nome"].ToString();
                    objAux.Senha = data.Tables[0].Rows[i]["Senha"].ToString();
                    objAux.TempoXP = Convert.ToInt32(data.Tables[0].Rows[i]["TempoXP"]);
                    objAux.Titulo = data.Tables[0].Rows[i]["Titulo"].ToString();
                    objAux.Usuario = data.Tables[0].Rows[i]["Usuario"].ToString();
                    objAux.UserStatus = data.Tables[0].Rows[i]["UserStatus"].ToString();
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

        /*
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
    */

        List<DocModel> MontaRetornoSQLite(DataSet data)
        {
            List<DocModel> retorno;
            DocModel objAux;
            try
            {
                retorno = new List<DocModel>();

                for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                {
                    objAux = new DocModel();
                    objAux.Id = Convert.ToInt32(data.Tables[0].Rows[i]["id"]);
                    objAux.Nome = data.Tables[0].Rows[i]["nome"].ToString();
                    objAux.Senha = data.Tables[0].Rows[i]["senha"].ToString();
                    objAux.TempoXP = Convert.ToInt32(data.Tables[0].Rows[i]["tempoXP"]);
                    objAux.Titulo = data.Tables[0].Rows[i]["titulo"].ToString();
                    objAux.Usuario = data.Tables[0].Rows[i]["usuario"].ToString();
                    objAux.UserStatus = data.Tables[0].Rows[i]["tipo"].ToString();
                    //objAux.Cargo = data.Tables[0].Rows[i]["cargo"].ToString();
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
