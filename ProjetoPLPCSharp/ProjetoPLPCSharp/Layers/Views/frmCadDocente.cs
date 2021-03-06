﻿using System;
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
    public partial class frmCadDocente : Form
    {
        #region Atributos
        DocenteController CtrlDocente;
        #endregion

        #region Construtores
        public frmCadDocente()
        {
            InitializeComponent();
            CtrlDocente = new DocenteController();
        }
        #endregion

        #region Eventos
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

        //Carregar Combo
        /*
       private void CarregaComboBox()
        {
            try
            {
                DataTable dataTable = new DataTable("tbAtividade");

                dataTable.Columns.Add("Pontuacao");
                dataTable.Columns.Add("Descricao");
                dataTable.Rows.Add(16, "Livros publicados");
                dataTable.Rows.Add(4, "Capítulo de livro");
                dataTable.Rows.Add(3, "Publicação em revistas indexadas de circulação" +
                    " internacional");
                dataTable.Rows.Add(2, "Publicação em revistas indexadas de circulação" +
                    " nacional");
                dataTable.Rows.Add(1, "Trabalho completo publicado em anais de eventos " +
                    "nacionais e internacionais");
                dataTable.Rows.Add(10, "Orientação de doutorado em programa reconhecido" +
                    "pelo MEC");
                dataTable.Rows.Add(5, "Co-orientação de doutorado em programa reconhecido" +
                    "pelo MEC");
                dataTable.Rows.Add(6, "Orientação de mestrado em programa reconhecido " +
                    "pelo MEC");
                dataTable.Rows.Add(3, "Co-Orientação de mestrado em programa reconhecido" +
                    " pelo MEC");
                dataTable.Rows.Add(2, "Liderança de grupos de pesquisa credenciados pelo " +
                    "CNPJ");
                dataTable.Rows.Add(3, "Participação em eventos técnico-científicos no exterior" +
                    "com apresentação de trabalho");
                dataTable.Rows.Add(2, "Participação em eventos técnico-científicos no país com " +
                    "com apresentação de trabalho");
                dataTable.Rows.Add(3, "Tradução de livro");
                dataTable.Rows.Add(1, "Tradução de artigo, capítulo de livro ou de trabalho" +
                    "técnico-científico");
                dataTable.Rows.Add(1, "Tradução de artigo, capítulo de livro ou de " +
                    "trabalho técnico");
                dataTable.Rows.Add(5, "Produção de filme e vídeo de curta e longa duração");
                dataTable.Rows.Add(5, "Elaboração de Softwares(Programas)");
                dataTable.Rows.Add(3, "Organização de compêndios");
                dataTable.Rows.Add(1, "Orientação de bolsista de iniciação Científica");
                dataTable.Rows.Add(1, "Participação em Órgãos Colegiados, na condição de" +
                    "titular, ou em comissões nomeadas pelo Diretor-Prec   ");
                dataTable.Rows.Add(3, "Particição em banca examinadora de doutorado");
                dataTable.Rows.Add(2, "Participação em banca examinadora de mestrado");
                dataTable.Rows.Add(2, "Participação em banca examinadora de concurso" +
                    "público em IES");
                dataTable.Rows.Add(1, "Participação em banca examinadora de seleção");
                dataTable.Rows.Add(1, "Coordenação de projetos de pesquisa aprovados" +
                    "por órgãos de fomento à pesquisa");
                dataTable.Rows.Add(10, "Pós-doutorado ou equivalente");
                dataTable.Rows.Add(5, "Prêmios conferidos por trabalhos técnicos" +
                    "ou científicos");

                cmbStatus.DataSource = dataTable;
                cmbStatus.ValueMember = "Pontuacao";
                cmbStatus.DisplayMember = "Descricao";

                cmbStatus.SelectedIndex = 0;
                cmbStatus.Refresh();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        */

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cadastrar();
                MessageBox.Show("Cadastro Concluído! \nDepois Lembrar de alterar senha!","Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro!");    
            }

        }

        #endregion

        #region Métodos
        private void Cadastrar()
        {
            DocModel docModel;
            if (txtCargo.Text != "" || txtNome.Text != "" || txtTitulo.Text != "" || txtUsuario.Text != "" || txtXP.Text != "" || txtUsuario.Text != "")
            {
                docModel = new DocModel();
                docModel.Cargo = txtCargo.Text;
                docModel.Nome = txtNome.Text;
                docModel.Titulo = txtTitulo.Text;
                docModel.TempoXP = Convert.ToInt32(txtXP.Text);
                docModel.Usuario = txtUsuario.Text;
                docModel.Senha = "123";
                docModel.UserStatus = "DOC";
                
                CtrlDocente.InserirDocente(docModel);
            }
            else
            {
                throw new Exception("Todos os campos devem ser preenchidos para realizar o cadastro/");
            }
            
            
        }
        #endregion

        
    }
}
