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

namespace ProjetoPLPCSharp.Layers.Views
{
    public partial class frmPomoverDoc : Form
    {

        #region Atributos
        DocenteController DocenteController;
        #endregion

        #region Construtores

        public frmPomoverDoc()
        {
            InitializeComponent();
            DocenteController = new DocenteController();
        }
        #endregion

        #region Eventos

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmPomoverDoc_Load(object sender, EventArgs e)
        {

        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Pesquisar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro na pesquisa!");
            }
        }
        #endregion

        #region Métodos
        private void Pesquisar()
        {

        }
        #endregion




    }
}
