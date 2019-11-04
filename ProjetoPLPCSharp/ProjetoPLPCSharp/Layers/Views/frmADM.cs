using ProjetoPLPCSharp.Layers.Controllers;
using ProjetoPLPCSharp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoPLPCSharp.Layers.Views
{
    public partial class frmADM : Form
    {
        #region Atributos

        private DocModel docModel;
        private DocenteController CtrlDoc;
        private AtividadeController CtrlAtiv;
        private List<DocModel> ListaGrid;
        private List<AtivModel> ListaAtiv;
        private int atualDoc;

        #endregion

        #region Construtor
        public frmADM(DocModel p_obj)
        {
            InitializeComponent();
            this.docModel = p_obj;
            CtrlAtiv = new AtividadeController();
            CtrlDoc = new DocenteController();
        }
        #endregion

        #region Eventos

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
        private void frmADM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
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
        private void frmADM_Load(object sender, EventArgs e)
        {
            try
            {
                MontaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao carregar tela!");
            }
        }
        private void grdDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                atualDoc = Convert.ToInt32(grdDoc.Rows[e.RowIndex].Cells[0].Value);
                CarregarAtiv(atualDoc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!");
            }
        }
        private void btnAtivOK_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarStatus();
                CarregarAtiv(atualDoc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!");
            }
        }

        #endregion

        #region Métodos

        private void PromoverDocente()
        {
            Visible = false;
            frmPomoverDoc frmPomoverDoc = new frmPomoverDoc();
            frmPomoverDoc.ShowDialog();
            frmPomoverDoc = null;
            Visible = true;
        }
        private void CadastrarDocente()
        {
            Visible = false;
            frmCadDocente frmCadDocente = new frmCadDocente();
            frmCadDocente.ShowDialog();
            Visible = true;
        }
        private void MontaGrid()
        {
            try
            {
                ListaGrid = CtrlDoc.ConsultarTodos();
                grdDoc.Rows.Clear();
                foreach (DocModel item in ListaGrid)
                {
                    if (item.UserStatus == "DOC")
                    {
                        grdDoc.Rows.Add(item.Id, item.Nome, item.Titulo, item.TempoXP, item.Cargo);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!");
            }
        }
        private void CarregarAtiv(int CodProf)
        {
            DocModel docModel;
            grdAtiv.Rows.Clear();
            docModel = ListaGrid.Find(e => e.Id == CodProf);
            
            ListaAtiv = CtrlAtiv.ConsultarAtividadePorID(docModel.Id);
            foreach (AtivModel item in ListaAtiv)
            {
                if (item.Status != "PENDENTE")
                {
                    grdAtiv.Rows.Add(item.CodAtiv, item.Descricao,item.Pontuacao,item.Status,item.CodProf);
                }
            }
        }
        private void AtualizarStatus()
        {
            //se grid não está vazia
            if (grdAtiv.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in grdAtiv.Rows)
                {
                    //se está selecionado
                    if (item.Selected)
                    {
                        CtrlAtiv.AtualizarStatus("OK", Convert.ToInt32(item.Cells[0].Value));
                    }
                }
            }
        }

        #endregion    
    }
}

    