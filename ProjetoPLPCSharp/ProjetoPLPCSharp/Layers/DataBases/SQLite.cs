using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPLPCSharp.Layers.DataBases
{
    class SQLite : IBanco
    {
        private string SqlData = "c:\\testeRemoto.db;Version=3;";
        private SQLiteConnection Connection;
        private SQLiteCommand comando;
        private SQLiteDataAdapter Adapter;

        public SQLite()
        {
        
            this.Connection = new SQLiteConnection("Data Source = " + SqlData);
            this.Connection.Open();
        }
        public void ExecutaComando(string p_comando)
        {
            try
            {
                comando = new SQLiteCommand(p_comando, Connection);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet ExecutaSelect(string p_comando)
        {
            DataSet Retorno;
            try
            {
                Adapter = new SQLiteDataAdapter(p_comando, Connection);
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
