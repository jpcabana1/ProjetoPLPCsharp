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
    public partial class frmCadDocente : Form
    {
        #region Atributos

        #endregion

        #region Construtores
        public frmCadDocente()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        private void btnCadastrar_KeyDown(object sender, KeyEventArgs e)
        {

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



    }
}
