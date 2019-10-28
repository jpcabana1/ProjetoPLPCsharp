using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPLPCSharp.Layers.Controllers;
using ProjetoPLPCSharp.Models;

namespace ProjetoPLPCSharp.Layers.Views
{
    public partial class frmCadDocente : Form
    {
        #region Atributos
        DocenteController CtrlDoC;
        #endregion

        #region Construtores
        public frmCadDocente()
        {
            InitializeComponent();
            CtrlDoC = new DocenteController();
        }
        #endregion

        #region Eventos

        private void btnCadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Escape)
            {
                Close();
            }
        }
        private void frmCadDocente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void frmCadDocente_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Métodos
        private void CadastrarDocente()
        {

            DocModel objCadastro;
            if (txtNome.Text != "" && txtCargo.Text != "" && txtTitulo.Text != "" && txtUsuario.Text != ""
                && txtXP.Text != "" && txtSenha.Text != "" && txtConfimarSenha.Text != "")
            {
                if (txtSenha.Text == txtConfimarSenha.Text)
                {
                    objCadastro = new DocModel();
                    objCadastro.Cargo = txtCargo.Text;
                    objCadastro.Nome = txtNome.Text;
                    objCadastro.Usuario = txtUsuario.Text;
                    objCadastro.TempoXP =Convert.ToInt32(txtXP.Text);
                    objCadastro.Titulo = txtTitulo.Text;
                    objCadastro.Senha = txtSenha.Text;
                    objCadastro.UserStatus = "DOC";
                    CtrlDoC.InserirDocente(objCadastro);
                    MessageBox.Show("Cadastro Concluído!");
                }
                else
                {
                    MessageBox.Show("Senhas devem ser iguais");
                }              
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
            }
        }
        #endregion

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                CadastrarDocente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Um erro ocorreu no cadastro!");
            }
        }
    }
}
