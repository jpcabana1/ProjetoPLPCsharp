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
        private List<DocModel> ListaDoc;
        private List<AtivModel> ListaAtiv;
        private DocenteController ControllerDoc;
        private AtividadeController ControllerAtiv;
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
        private void btnCadDocente_Click(object sender, EventArgs e)
        {
            try
            {
                CadastrarDocente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no Cadastro");
            }
        }

        #endregion

        #region Métodos

        private void CadastrarDocente()
        {
            Visible = false;
            frmCadDocente frmCadDocente = new frmCadDocente();
            frmCadDocente.ShowDialog();
            MontaGridDoc();
            Visible = true;
        }
        private void CarregarTela()
        {
            MontaGridDoc();
        }
        private void MontaGridAtiv(int index)
        {
            AtivModel ativModel = new AtivModel();
            grdAtiv.Rows.Clear();
            ativModel.CodProf = Convert.ToInt32(grdDocente.Rows[index].Cells[0].Value);
            ListaAtiv = ControllerAtiv.ConsultarAtividade(ativModel);
            foreach (AtivModel item in ListaAtiv)
            {
                if (item.Status != "PENDENTE")
                {
                    grdAtiv.Rows.Add(item.CodAtiv, item.Descricao, item.Pontuacao, item.Status, item.CodProf);
                }
            }
        }
        private void atualizarGrid(int id)
        {
            grdAtiv.Rows.Clear();
            AtivModel ativModel = new AtivModel();
            ativModel.CodProf = id;
            ListaAtiv = ControllerAtiv.ConsultarAtividade(ativModel);
            foreach (AtivModel item in ListaAtiv)
            {
                if (item.Status != "PENDENTE")
                {
                    grdAtiv.Rows.Add(item.CodAtiv, item.Descricao, item.Pontuacao, item.Status, item.CodProf);
                }
            }
        }

        private void MontaGridDoc()
        {
            grdDocente.Rows.Clear();

            ListaDoc = ControllerDoc.ConsultarTodos();
            foreach (DocModel item in ListaDoc)
            {
                if (item.UserStatus == "DOC")
                {
                    grdDocente.Rows.Add(item.Id, item.Nome, item.Titulo, item.TempoXP, item.Cargo);
                }
            }
        }
        private void ConcluirAtividade()
        {
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
            if(grdAtiv.Rows.Count != 0)
            {
                ativModel = ListaAtiv.Find(e => e.CodProf == Convert.ToInt32(grdAtiv.Rows[0].Cells[4].Value));
                atualizarGrid(ativModel.CodProf);
            }
        }

        #endregion


    }    

}
