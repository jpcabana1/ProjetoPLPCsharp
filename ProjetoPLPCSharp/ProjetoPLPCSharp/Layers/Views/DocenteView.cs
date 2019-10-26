using ProjetoPLPCSharp.Layers.Controllers;
using ProjetoPLPCSharp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoPLPCSharp.Layers.Views
{
    public partial class DocenteView : Form
    {
        #region Declarações
        private DocenteController CtrlDoc;
        private AtividadeController CtrlAtiv;
        private DocModel objDOC;
        #endregion

        #region Construtores
        public DocenteView(DocModel docModel)
        {
            InitializeComponent();
            Width = 1391;
            Height = 730;
            CtrlDoc = new DocenteController();
            CtrlAtiv = new AtividadeController();
            this.objDOC = docModel;
        }
        #endregion

        #region Eventos
        private void DocenteView_Load(object sender, EventArgs e)
        {
            try
            {
                lblMensagem.Text = "Bem Vindo: " + objDOC.Nome;
                lblUser.Text = "Usuário: " + objDOC.Usuario;
                CarregarGrid();
                CarregaComboBox();
                timer1.Start();
                lblTempo.Text = DateTime.Now.ToLongTimeString();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Carregar Grid!");
            }
        }
        private void DocenteView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            lblTempo.Text = DateTime.Now.ToLongTimeString();
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {    
            try
            {
                enviar();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no envio");
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtivModel objAux;
            List<AtivModel> Lista;
            try
            {
                objAux = new AtivModel();
                objAux.Status = cmbStatus.Text;
                objAux.CodProf = objDOC.Id;
                if (txtCod.Text != "")
                    objAux.CodAtiv = Convert.ToInt32(txtCod.Text);
                if (txtPont.Text != "")
                    objAux.Pontuacao = Convert.ToInt32(txtPont.Text);
                Lista = CtrlAtiv.ConsultarAtividade(objAux);

                grdAtividade.Rows.Clear();
                foreach (AtivModel item in Lista)
                {
                    grdAtividade.Rows.Add(0, item.CodAtiv, item.Descricao, item.Pontuacao, item.Status, item.CodProf);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao pesquisar!");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            try
            {
                Remover();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao remover atividade");
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarTelaCadastro();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao carregar tela de cadastro");

            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                AlterarDados();
                lblAlteraDodos.Text = "Atenção: Atualização dos dados concluída, " +
                    "Talvez seja necessário realizar o login novamente para que seus dados ";
                    
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível alterar seus dados!");
            }
        }

        #endregion

        #region Funções
        private void CarregarTelaCadastro()
        {
            CadastroAtiv cadastroAtiv;
            try
            {
                Visible = false;
                cadastroAtiv = new CadastroAtiv(objDOC.Id);
                cadastroAtiv.ShowDialog();
                cadastroAtiv = null;
                Visible = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CarregaComboBox()
        {
            try
            {
                cmbStatus.Items.Add("PENDENTE");
                cmbStatus.Items.Add("AVALIANDO");
                cmbStatus.Items.Add("OK");
                cmbStatus.Items.Add("CANCELADA");
                cmbStatus.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CarregarGrid()
        {
            List<AtivModel> Lista;
            AtivModel objAux;
            try
            {
                grdAtividade.Rows.Clear();
                objAux = new AtivModel();
                objAux.CodProf = objDOC.Id;
                Lista = CtrlAtiv.ConsultarAtividade(objAux);
                foreach (AtivModel item in Lista)
                {
                    grdAtividade.Rows.Add(0, item.CodAtiv, item.Descricao, item.Pontuacao, item.Status, item.CodProf);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Remover()
        {
            AtivModel ativModel;
            try
            {
                ativModel = new AtivModel();
                foreach (DataGridViewRow item in grdAtividade.Rows)
                {
                    if (Convert.ToInt32(item.Cells[0].Value) == 1)
                    {
                        ativModel.CodAtiv = Convert.ToInt32(item.Cells[1].Value);
                        CtrlAtiv.RemoverAtividade(ativModel);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void AlterarDados()
        {
            frmAlterarDados frmAlterarDados;
            try
            {
                Visible = false;
                frmAlterarDados = new frmAlterarDados(objDOC);
                frmAlterarDados.ShowDialog();
                frmAlterarDados = null;
                Visible = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void enviar()
        {
            AtivModel objUpdate;
            try
            {
                objUpdate = new AtivModel();
                foreach (DataGridViewRow item in grdAtividade.Rows)
                {
                    if (Convert.ToInt32(item.Cells[0].Value) == 1)
                    {
                        item.Cells[4].Value = "AVALIANDO";
                        objUpdate.CodProf = objDOC.Id;
                        objUpdate.Status = "AVALIANDO";
                        objUpdate.CodAtiv = Convert.ToInt32(item.Cells[1].Value);
                        objUpdate.Descricao = item.Cells[2].Value.ToString();
                        objUpdate.Pontuacao = Convert.ToInt32(item.Cells[3].Value); ;
                        CtrlAtiv.AtualizarAtividade(objUpdate);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}