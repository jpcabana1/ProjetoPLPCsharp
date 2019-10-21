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
    public partial class Form1 : Form
    {
        private DocenteController CtrlDocente;
        public Form1()
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
            DocenteView tela1;
            try
            {
                objLogin = new DocModel();
                objLogin.Usuario = txtLogin.Text;
                objLogin.Senha = txtSenha.Text;
                objLogin = CtrlDocente.ConsultarDocente(objLogin).First();
                if (objLogin.UserStatus == "DOC")
                {
                    Visible = false;
                    tela1 = new DocenteView();
                    tela1.ShowDialog();
                    tela1 = null;
                    Visible = true;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
    }
}
