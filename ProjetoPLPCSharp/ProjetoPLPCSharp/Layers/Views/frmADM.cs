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
<<<<<<< HEAD
        private void btnPromo_Click(object sender, EventArgs e)
        {
            try
            {
                PromoverDocente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao Promover docente!");
            }
        }

        private void btnAtivOK_Click(object sender, EventArgs e)
        {
            try
            {
                ConcluirAtividade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void grdDocente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MontaGridAtiv(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao selecionar docente!");
            }
        }
        private void frmADM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void frmADM_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao carregar a tela!");
            }
        }
=======
>>>>>>> parent of 5b0831d... Faltando Foto e Promoção
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
<<<<<<< HEAD

        private void PromoverDocente()
        {
            Visible = false;
            frmPomoverDoc frmPomoverDoc = new frmPomoverDoc();
            frmPomoverDoc.ShowDialog();
            frmPomoverDoc = null;
            Visible = true;
        }
=======
>>>>>>> parent of 5b0831d... Faltando Foto e Promoção
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
<<<<<<< HEAD
            AtivModel ativModel;
            int idAux;
            foreach (DataGridViewRow item in grdAtiv.Rows)
            {
                if (item.Selected)
                {
                    ativModel = new AtivModel();
                    ativModel = ListaAtiv.Find(p => p.CodAtiv == Convert.ToInt32(item.Cells[0].Value));
                    ativModel.Status = "OK";
                    ControllerAtiv.AtualizarAtividade(ativModel);
                }
            }
            if (grdAtiv.Rows.Count != 0)
=======
            if (e.KeyCode == Keys.Escape)
>>>>>>> parent of 5b0831d... Faltando Foto e Promoção
            {
                Close();
            }
        }
<<<<<<< HEAD



        #endregion

        private void grdDocente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
=======
    }
}
>>>>>>> parent of 5b0831d... Faltando Foto e Promoção
