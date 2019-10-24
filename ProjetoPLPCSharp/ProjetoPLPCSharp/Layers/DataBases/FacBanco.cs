using System;

namespace ProjetoPLPCSharp.Layers.DataBases
{
    class FacBanco
    {
        public IBanco CriarBanco(string tipoBanco)
        {
            IBanco retorno = null;
            try
            {
                switch (tipoBanco)
                {
                    case "SQLServer":
                        retorno = new SQLserver();
                        break;                   
                    case "SQLite":
                        retorno = new SQLite();
                        break;
                    default:
                        break;                     
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
