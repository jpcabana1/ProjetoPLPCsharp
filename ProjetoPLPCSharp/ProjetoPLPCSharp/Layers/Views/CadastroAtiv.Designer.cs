namespace ProjetoPLPCSharp.Layers.Views
{
    partial class CadastroAtiv
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAnexo = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.lblDocCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Atividade:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(16, 64);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(656, 28);
            this.cmbStatus.TabIndex = 3;
            // 
            // btnAnexo
            // 
            this.btnAnexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnexo.ForeColor = System.Drawing.Color.Black;
            this.btnAnexo.Image = global::ProjetoPLPCSharp.Properties.Resources.OpenFile;
            this.btnAnexo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnexo.Location = new System.Drawing.Point(16, 122);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(207, 51);
            this.btnAnexo.TabIndex = 4;
            this.btnAnexo.Text = "Anexar arquivos";
            this.btnAnexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnexo.UseVisualStyleBackColor = true;
            this.btnAnexo.Click += new System.EventHandler(this.btnAnexo_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.Black;
            this.btnCadastro.Image = global::ProjetoPLPCSharp.Properties.Resources.Create;
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(248, 280);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(202, 56);
            this.btnCadastro.TabIndex = 5;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // lblDocCount
            // 
            this.lblDocCount.AutoSize = true;
            this.lblDocCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocCount.Location = new System.Drawing.Point(229, 122);
            this.lblDocCount.Name = "lblDocCount";
            this.lblDocCount.Size = new System.Drawing.Size(205, 20);
            this.lblDocCount.TabIndex = 6;
            this.lblDocCount.Text = "Documentos anexados:";
            // 
            // CadastroAtiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(697, 375);
            this.Controls.Add(this.lblDocCount);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnAnexo);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "CadastroAtiv";
            this.Text = "Cadastro de Atividades:";
            this.Load += new System.EventHandler(this.CadastroAtiv_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CadastroAtiv_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAnexo;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Label lblDocCount;
    }
}