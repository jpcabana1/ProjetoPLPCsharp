using ProjetoPLPCSharp.Layers.Controllers;
using ProjetoPLPCSharp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPLPCSharp.Layers.Views
{
    public partial class frmAlterarDados : Form
    {

        #region Atributos
        DocModel DocModel;
        #endregion


        #region Construtor
        public frmAlterarDados(DocModel p_obj)
        {
            InitializeComponent();
            this.DocModel = p_obj;
        }
        #endregion


        #region Eventos
        private void frmAlterarDados_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro inesperado!");
            }

        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            try
            {
                AlterarDados();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao alterar Dados!");
            }
        }

        #endregion

        #region Métodos
            private void AlterarDados()
        {
            DocenteController controller;
            try
            {
                if (txtNome.Text != "" || txtUsuario.Text != "" || txtSenha.Text != "")
                {
                    controller = new DocenteController();
                    if (txtNome.Text != "")
                        DocModel.Nome = txtNome.Text;

                    if (txtUsuario.Text != "")
                        DocModel.Usuario = txtUsuario.Text;

                    if (txtSenha.Text != "")
                    {
                        if (txtSenha.Text != txtConfirmaSenha.Text)
                        {
                            MessageBox.Show("Senhas precisam ser iguais");
                            return;
                        }
                        else
                        {
                            DocModel.Senha = txtSenha.Text;                         
                        }
                    }
                    controller.AtualizarDocente(DocModel);
                    MessageBox.Show("Atualização concluída!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Propriedades

        #endregion

    }
}
