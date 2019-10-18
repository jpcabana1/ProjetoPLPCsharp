using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoPLPCSharp.Layers.DataBases
{
    class SQLserver : IBanco
    {
       private string SqlData = "Data Source = 'localhost'; Initial Catalog = 'testeDB'; User='sa'; Password = 'otis2016'";
       private SqlConnection Connection;
       private SqlCommand comando;
       private SqlDataAdapter Adapter;
       
       
        public SQLserver()
        {
            this.Connection = new SqlConnection(SqlData);
            this.Connection.Open();
        }
        public void ExecutaComando(string p_comando)
        {
            comando = new SqlCommand(p_comando, Connection);
            comando.ExecuteNonQuery();
        }

        public DataSet ExecutaSelect(string p_comando)
        {
            DataSet Retorno;
            try {             
                Adapter = new SqlDataAdapter(p_comando, Connection);
                Retorno = new DataSet();
                Adapter.Fill(Retorno);
                return Retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
            
        }
    }
}
