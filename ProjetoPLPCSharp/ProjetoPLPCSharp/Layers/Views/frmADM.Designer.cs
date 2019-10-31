namespace ProjetoPLPCSharp.Layers.Views
{
    partial class frmADM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAtivOK = new System.Windows.Forms.Button();
            this.grdDocente = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdAtiv = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPromo = new System.Windows.Forms.Button();
            this.btnCadDocente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAtiv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAtivOK);
            this.groupBox1.Controls.Add(this.btnPromo);
            this.groupBox1.Controls.Add(this.btnCadDocente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(217, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1069, 142);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ferramentas:";
            // 
            // btnAtivOK
            // 
            this.btnAtivOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivOK.ForeColor = System.Drawing.Color.Black;
            this.btnAtivOK.Image = global::ProjetoPLPCSharp.Properties.Resources.Confirmar;
            this.btnAtivOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtivOK.Location = new System.Drawing.Point(751, 52);
            this.btnAtivOK.Name = "btnAtivOK";
            this.btnAtivOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAtivOK.Size = new System.Drawing.Size(250, 56);
            this.btnAtivOK.TabIndex = 2;
            this.btnAtivOK.Text = "Concluir Atividade";
            this.btnAtivOK.UseVisualStyleBackColor = true;
            this.btnAtivOK.Click += new System.EventHandler(this.btnAtivOK_Click);
            // 
            // grdDocente
            // 
            this.grdDocente.AllowUserToAddRows = false;
            this.grdDocente.AllowUserToDeleteRows = false;
            this.grdDocente.BackgroundColor = System.Drawing.Color.White;
            this.grdDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grdDocente.Location = new System.Drawing.Point(746, 240);
            this.grdDocente.Name = "grdDocente";
            this.grdDocente.RowHeadersWidth = 51;
            this.grdDocente.RowTemplate.Height = 24;
            this.grdDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDocente.ShowEditingIcon = false;
            this.grdDocente.Size = new System.Drawing.Size(676, 512);
            this.grdDocente.TabIndex = 4;
            this.grdDocente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDocente_CellContentClick);
            this.grdDocente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDocente_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Titulo";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tempo Exp.";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cargo";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // grdAtiv
            // 
            this.grdAtiv.AllowUserToAddRows = false;
            this.grdAtiv.AllowUserToDeleteRows = false;
            this.grdAtiv.BackgroundColor = System.Drawing.Color.White;
            this.grdAtiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAtiv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.S,
            this.Column9});
            this.grdAtiv.Location = new System.Drawing.Point(31, 240);
            this.grdAtiv.Name = "grdAtiv";
            this.grdAtiv.RowHeadersWidth = 51;
            this.grdAtiv.RowTemplate.Height = 24;
            this.grdAtiv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAtiv.Size = new System.Drawing.Size(678, 512);
            this.grdAtiv.TabIndex = 5;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Codigo";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Descrição";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Pontuação";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // S
            // 
            this.S.HeaderText = "Status";
            this.S.MinimumWidth = 6;
            this.S.Name = "S";
            this.S.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Cod. Docente";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // btnPromo
            // 
            this.btnPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromo.ForeColor = System.Drawing.Color.Black;
            this.btnPromo.Image = global::ProjetoPLPCSharp.Properties.Resources.Up;
            this.btnPromo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromo.Location = new System.Drawing.Point(385, 52);
            this.btnPromo.Name = "btnPromo";
            this.btnPromo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPromo.Size = new System.Drawing.Size(269, 56);
            this.btnPromo.TabIndex = 1;
            this.btnPromo.Text = "Promover Docente";
            this.btnPromo.UseVisualStyleBackColor = true;
            this.btnPromo.Click += new System.EventHandler(this.btnPromo_Click);
            // 
            // btnCadDocente
            // 
            this.btnCadDocente.ForeColor = System.Drawing.Color.Black;
            this.btnCadDocente.Image = global::ProjetoPLPCSharp.Properties.Resources.Create;
            this.btnCadDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadDocente.Location = new System.Drawing.Point(18, 52);
            this.btnCadDocente.Name = "btnCadDocente";
            this.btnCadDocente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCadDocente.Size = new System.Drawing.Size(272, 56);
            this.btnCadDocente.TabIndex = 0;
            this.btnCadDocente.Text = "Cadastrar Docente";
            this.btnCadDocente.UseVisualStyleBackColor = true;
            this.btnCadDocente.Click += new System.EventHandler(this.btnCadDocente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Atividades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(742, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Docentes";
            // 
            // frmADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1453, 764);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdAtiv);
            this.Controls.Add(this.grdDocente);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmADM";
            this.Text = "frmADM";
            this.Load += new System.EventHandler(this.frmADM_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmADM_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAtiv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadDocente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAtivOK;
        private System.Windows.Forms.Button btnPromo;
        private System.Windows.Forms.DataGridView grdDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView grdAtiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}