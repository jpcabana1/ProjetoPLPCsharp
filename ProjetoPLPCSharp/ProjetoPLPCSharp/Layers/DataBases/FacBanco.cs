using System;

namespace ProjetoPLPCSharp.Layers.DataBases
{
    class FacBanco
    {
        public IBanco CriarBanco(string tipoBanco)
        {
            IBanco retorno;
            try
            {
                switch (tipoBanco)
                {
                    case "SQLServer":
                        retorno = new SQLserver();
                        return retorno;                      
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }
    }
}
