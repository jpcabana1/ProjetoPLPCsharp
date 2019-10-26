using ProjetoPLPCSharp.Layers.Controllers;
using ProjetoPLPCSharp.Layers.Views;
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

namespace ProjetoPLPCSharp
{
    public partial class TelaLogin : Form
    {
        private DocenteController CtrlDocente;
        public TelaLogin()
        {
            InitializeComponent();
            CtrlDocente = new DocenteController();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DocModel objLogin;
            DocenteView tela;
            frmADM  telaADM;
            try
            {
                objLogin = new DocModel();
                objLogin.Usuario = txtLogin.Text;
                objLogin.Senha = txtSenha.Text;
                objLogin = CtrlDocente.ConsultarDocente(objLogin).First();

                if (objLogin.UserStatus == "DOC")
                {
                    Visible = false;
                    tela = new DocenteView(objLogin);                 
                    tela.ShowDialog();
                    tela = null;
                    Visible = true;
                }else{
                    Visible = false;
                    telaADM = new frmADM(objLogin);
                    telaADM.ShowDialog();
                    telaADM = null;
                    Visible = true;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }
        }
        
    }
}
