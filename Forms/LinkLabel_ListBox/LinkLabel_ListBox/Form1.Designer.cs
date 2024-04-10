namespace LinkLabel_ListBox
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.llGoogle = new System.Windows.Forms.LinkLabel();
            this.llCalculadora = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxCursos = new System.Windows.Forms.ListBox();
            this.tbxCurso = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnObter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // llGoogle
            // 
            this.llGoogle.AutoSize = true;
            this.llGoogle.Location = new System.Drawing.Point(27, 412);
            this.llGoogle.Name = "llGoogle";
            this.llGoogle.Size = new System.Drawing.Size(41, 13);
            this.llGoogle.TabIndex = 0;
            this.llGoogle.TabStop = true;
            this.llGoogle.Text = "Google";
            this.llGoogle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGoogle_LinkClicked);
            // 
            // llCalculadora
            // 
            this.llCalculadora.AutoSize = true;
            this.llCalculadora.Location = new System.Drawing.Point(97, 412);
            this.llCalculadora.Name = "llCalculadora";
            this.llCalculadora.Size = new System.Drawing.Size(63, 13);
            this.llCalculadora.TabIndex = 1;
            this.llCalculadora.TabStop = true;
            this.llCalculadora.Text = "Calculadora";
            this.llCalculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCalculadora_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Links Úteis";
            // 
            // lbxCursos
            // 
            this.lbxCursos.FormattingEnabled = true;
            this.lbxCursos.Location = new System.Drawing.Point(12, 12);
            this.lbxCursos.Name = "lbxCursos";
            this.lbxCursos.Size = new System.Drawing.Size(160, 147);
            this.lbxCursos.TabIndex = 3;
            // 
            // tbxCurso
            // 
            this.tbxCurso.Location = new System.Drawing.Point(201, 12);
            this.tbxCurso.Name = "tbxCurso";
            this.tbxCurso.Size = new System.Drawing.Size(224, 20);
            this.tbxCurso.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(201, 50);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(224, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(201, 95);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(224, 23);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnObter
            // 
            this.btnObter.Location = new System.Drawing.Point(201, 138);
            this.btnObter.Name = "btnObter";
            this.btnObter.Size = new System.Drawing.Size(224, 23);
            this.btnObter.TabIndex = 7;
            this.btnObter.Text = "Obter";
            this.btnObter.UseVisualStyleBackColor = true;
            this.btnObter.Click += new System.EventHandler(this.btnObter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObter);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbxCurso);
            this.Controls.Add(this.lbxCursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llCalculadora);
            this.Controls.Add(this.llGoogle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llGoogle;
        private System.Windows.Forms.LinkLabel llCalculadora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxCursos;
        private System.Windows.Forms.TextBox tbxCurso;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnObter;
    }
}

