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
        DocenteController CtrlDocente;
        #endregion

        #region Construtores
        public frmCadDocente()
        {
            InitializeComponent();
            CtrlDocente = new DocenteController();
        }
        #endregion

        #region Eventos
        private void frmCadDocente_Load(object sender, EventArgs e)
        {

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cadastrar();
                MessageBox.Show("Cadastro Concluído! \nDepois Lembrar de alterar senha!","Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro!");    
            }

        }

        #endregion

        #region Métodos
        private void Cadastrar()
        {
            DocModel docModel;
            if (txtCargo.Text != "" || txtNome.Text != "" || txtTitulo.Text != "" || txtUsuario.Text != "" || txtXP.Text != "" || txtUsuario.Text != "")
            {
                docModel = new DocModel();
                docModel.Cargo = txtCargo.Text;
                docModel.Nome = txtNome.Text;
                docModel.Titulo = txtTitulo.Text;
                docModel.TempoXP = Convert.ToInt32(txtXP.Text);
                docModel.Usuario = txtUsuario.Text;
                docModel.Senha = "123";
                docModel.UserStatus = "DOC";
                
                CtrlDocente.InserirDocente(docModel);
            }
            else
            {
                throw new Exception("Todos os campos devem ser preenchidos para realizar o cadastro/");
            }
            
            
        }
        #endregion
    }
}
