namespace ToolsForms
{
    partial class F_CheckedListBox
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
            this.clbCursos = new System.Windows.Forms.CheckedListBox();
            this.btnMostrarSlecionados = new System.Windows.Forms.Button();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.btnAdicionarCurso = new System.Windows.Forms.Button();
            this.tbxAdicionarCurso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clbCursos
            // 
            this.clbCursos.FormattingEnabled = true;
            this.clbCursos.Items.AddRange(new object[] {
            "C#",
            "C",
            "SQL",
            "Python"});
            this.clbCursos.Location = new System.Drawing.Point(0, 0);
            this.clbCursos.Name = "clbCursos";
            this.clbCursos.Size = new System.Drawing.Size(222, 154);
            this.clbCursos.TabIndex = 0;
            // 
            // btnMostrarSlecionados
            // 
            this.btnMostrarSlecionados.Location = new System.Drawing.Point(246, 12);
            this.btnMostrarSlecionados.Name = "btnMostrarSlecionados";
            this.btnMostrarSlecionados.Size = new System.Drawing.Size(275, 23);
            this.btnMostrarSlecionados.TabIndex = 1;
            this.btnMostrarSlecionados.Text = "Mostrar Selecionados";
            this.btnMostrarSlecionados.UseVisualStyleBackColor = true;
            this.btnMostrarSlecionados.Click += new System.EventHandler(this.btnMostrarSlecionados_Click);
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.Location = new System.Drawing.Point(246, 52);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(275, 23);
            this.btnLimparLista.TabIndex = 2;
            this.btnLimparLista.Text = "Limpar Lista";
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // btnAdicionarCurso
            // 
            this.btnAdicionarCurso.Location = new System.Drawing.Point(246, 131);
            this.btnAdicionarCurso.Name = "btnAdicionarCurso";
            this.btnAdicionarCurso.Size = new System.Drawing.Size(275, 23);
            this.btnAdicionarCurso.TabIndex = 3;
            this.btnAdicionarCurso.Text = "AdicionarCurso";
            this.btnAdicionarCurso.UseVisualStyleBackColor = true;
            this.btnAdicionarCurso.Click += new System.EventHandler(this.btnAdicionarCurso_Click);
            // 
            // tbxAdicionarCurso
            // 
            this.tbxAdicionarCurso.Location = new System.Drawing.Point(246, 94);
            this.tbxAdicionarCurso.Name = "tbxAdicionarCurso";
            this.tbxAdicionarCurso.Size = new System.Drawing.Size(275, 20);
            this.tbxAdicionarCurso.TabIndex = 4;
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 186);
            this.Controls.Add(this.tbxAdicionarCurso);
            this.Controls.Add(this.btnAdicionarCurso);
            this.Controls.Add(this.btnLimparLista);
            this.Controls.Add(this.btnMostrarSlecionados);
            this.Controls.Add(this.clbCursos);
            this.Name = "F_CheckedListBox";
            this.Text = "F_CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbCursos;
        private System.Windows.Forms.Button btnMostrarSlecionados;
        private System.Windows.Forms.Button btnLimparLista;
        private System.Windows.Forms.Button btnAdicionarCurso;
        private System.Windows.Forms.TextBox tbxAdicionarCurso;
    }
}