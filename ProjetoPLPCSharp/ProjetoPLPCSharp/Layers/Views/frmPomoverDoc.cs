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
    public partial class frmPomoverDoc : Form
    {

        #region Atributos

        private DocenteController CtrlDocente;
        private AtividadeController CtrlAtividade;
        private CargoController CtrlCargo;
        private List<CargoModel> ListaCargo;
        private List<DocModel> ListaDoc;

        #endregion

        #region Construtores

        public frmPomoverDoc()
        {

            InitializeComponent();
            CtrlDocente = new DocenteController();
            CtrlCargo = new CargoController();
            CtrlAtividade = new AtividadeController();

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
            try
            {
                ListaDoc = CtrlDocente.ConsultarTodos();
                ListaCargo = CtrlCargo.SelecionarTodos();
                MontaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no carregamento da tela!");
            }       
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
        private void frmPomoverDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void btnPromover_Click(object sender, EventArgs e)
        {
            try
            {
                Promover();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!");
            }
        }

        #endregion

        #region Métodos

        private void Pesquisar()
        {
            DocModel aux;
            aux = new DocModel();
            if (txtID.Text != "" && txtNome.Text != ""){
                aux.Id = Convert.ToInt32(txtID.Text);
                aux.Nome = txtNome.Text;   
            }else if (txtID.Text != ""){
                aux.Id = Convert.ToInt32(txtID.Text);
            }
            else if (txtNome.Text != ""){
                aux.Nome = txtNome.Text;
            }
            else
            {
                ListaDoc = CtrlDocente.ConsultarTodos();
                MontaGrid(); ;
                return;
            }
           ListaDoc = CtrlDocente.ConsultarDocente(aux);
            MontaGrid();
        }
        private void MontaGrid()
        {
            grdDoc.Rows.Clear();
            foreach (DocModel item in ListaDoc)
            {
                if (item.UserStatus == "DOC")
                {
                    grdDoc.Rows.Add(item.Id, item.Nome, item.Cargo, item.TempoXP);
                }
            }
        }
        private void Promover()
        {

            DocModel ObjDoc;
            CargoModel ObjCargo;
            int ContagemPontosDocente;
            bool tempoValido;

            foreach (DataGridViewRow item in grdDoc.Rows)
            {
                if (item.Selected)
                {
                    ObjDoc = ListaDoc.Find(e => e.Id == Convert.ToInt32(item.Cells[0].Value));
                    ObjCargo = ListaCargo.Find(e => e.Cargo == ObjDoc.Cargo);
                    ContagemPontosDocente = ContaPontos(ObjDoc.Id);//Consulta pontuação total do docente
                    tempoValido = ValidaTempo(ObjCargo.ID, ObjDoc.TempoXP);//Se o tempo do docente estiver de acordo tempoValido = true
                    if (ContagemPontosDocente >= ObjCargo.Pontuacao && ObjCargo.Vagas > 0 && tempoValido)
                    {
                        //ID: 9 = Professor Titular(Cargo Máximo)
                        if (ObjCargo.ID < 9 )
                        {
                    
                            ObjCargo.Vagas = ObjCargo.Vagas + 1;//Libera vaga do cargo atual
                            CtrlCargo.AtualizarCargo(ObjCargo);
                            ObjCargo = ListaCargo.Find(e => e.ID == ObjCargo.ID + 1);
                            ObjCargo.Vagas = ObjCargo.Vagas - 1;//Ocupa uma vaga do cargo cargo novo
                            CtrlCargo.AtualizarCargo(ObjCargo);
                            ObjDoc.TempoXP = 0;
                            ObjDoc.Cargo = ObjCargo.Cargo;
                            CtrlDocente.AtualizarDocente(ObjDoc);
                            MessageBox.Show("Professor promovido!", "Promoção Concluída!");
                        }
                        else
                        {
                            MessageBox.Show("Professor titular não precisa ser promovido!","Promoção desnecessária!");
                        }   
                    }
                    else
                    {
                        MessageBox.Show("Usuário: "+ObjDoc.Nome+"\nNão cumpre requisitos para ser promovido","Erro!");
                    }
                }
            }

            MontaGrid();

        }

        private int ContaPontos(int id)
        {
            int contagem = 0;
            List<AtivModel> Lista;
            Lista = CtrlAtividade.ConsultarAtividadePorID(id);
            for (int i = 0; i < Lista.Count; i++)
            {
                contagem = contagem + Lista[i].Pontuacao;
            }
            return contagem;
        }

        private bool ValidaTempo(int idCargo, int tempo)
        {
            CargoModel cargoModel;
            cargoModel = ListaCargo.Find(e => e.ID == idCargo + 1) ;
            return tempo >= cargoModel.Tempo;
        }
       
        #endregion

        
    }
}
