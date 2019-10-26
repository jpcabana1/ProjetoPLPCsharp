using ProjetoPLPCSharp.Layers.Controllers;
using ProjetoPLPCSharp.Models;
using System;
using System.Windows.Forms;

namespace ProjetoPLPCSharp.Layers.Views
{
    public partial class frmADM : Form
    {
        #region Atributos
        DocModel docModel;
        DocenteController ControllerDoc;
        AtividadeController ControllerAtiv;
        #endregion

        #region Construtor
        public frmADM(DocModel p_obj)
        {
            InitializeComponent();
            this.docModel = p_obj;
            ControllerAtiv = new AtividadeController();
            ControllerDoc = new DocenteController();
        }
        #endregion

        #region Eventos
        private void btnCadDocente_Click(object sender, EventArgs e)
        {
            try
            {
                CadastrarDocente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro no Cadastro");
            }
        }
        #endregion

        #region Métodos
        private void CadastrarDocente()
        {
            Visible = false;
            frmCadDocente frmCadDocente = new frmCadDocente();
            frmCadDocente.ShowDialog();
            Visible = true;
        }

        #endregion

        private void frmADM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
