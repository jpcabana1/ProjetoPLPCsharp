using ProjetoPLPCSharp.Layers.Repos;
using ProjetoPLPCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPLPCSharp.Layers.Controllers
{
    class AtividadeController
    {
        RepoAtiv objRepo;

        public AtividadeController()
        {
            this.objRepo = new RepoAtiv("SQLServer");
        }

        public void InserirAtividade(AtivModel p_obj)
        {
            try
            {
                objRepo.insert(p_obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AtualizarAtividade(AtivModel p_obj)
        {
            try
            {
                objRepo.Update(p_obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RemoverAtividade(AtivModel p_obj)
        {
            try
            {
                objRepo.Remove(p_obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<AtivModel> ConsultarAtividade(AtivModel p_obj)
        {
            try
            {
                return objRepo.Select(p_obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<AtivModel> ConsultarTodos(AtivModel p_obj)
        {
            try
            {
                return objRepo.selectAll(p_obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void teste()
        {
            objRepo.testeSQLite("Select * from tbTeste");
        }
    }
}
