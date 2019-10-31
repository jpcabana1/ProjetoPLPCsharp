using ProjetoPLPCSharp.Layers.Repos;
using ProjetoPLPCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPLPCSharp.Layers.Controllers
{
    class DocenteController
    {
        RepoDocente objRepo;

        public DocenteController()
        {
            this.objRepo = new RepoDocente("SQLite");
        }

        public void InserirDocente(DocModel p_obj)
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
        public void AtualizarDocente(DocModel p_obj)
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
        public void RemoverDocente(DocModel p_obj)
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
        public List<DocModel> ConsultarDocente(DocModel p_obj)
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
        public List<DocModel> ConsultarTodos()
        {
            try
            {
                return objRepo.selectAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
