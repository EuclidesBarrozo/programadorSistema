namespace CheckBox
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
            this.cbxCSharp = new System.Windows.Forms.CheckBox();
            this.cbxSQL = new System.Windows.Forms.CheckBox();
            this.cbxC = new System.Windows.Forms.CheckBox();
            this.cbxPython = new System.Windows.Forms.CheckBox();
            this.btnCursosEscolhidos = new System.Windows.Forms.Button();
            this.cbxHTML = new System.Windows.Forms.CheckBox();
            this.clbCursos = new System.Windows.Forms.CheckedListBox();
            this.btnMostrarSelecionados = new System.Windows.Forms.Button();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.btnAdicionarCurso = new System.Windows.Forms.Button();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxCSharp
            // 
            this.cbxCSharp.AutoSize = true;
            this.cbxCSharp.Location = new System.Drawing.Point(12, 12);
            this.cbxCSharp.Name = "cbxCSharp";
            this.cbxCSharp.Size = new System.Drawing.Size(40, 17);
            this.cbxCSharp.TabIndex = 0;
            this.cbxCSharp.Text = "C#";
            this.cbxCSharp.UseVisualStyleBackColor = true;
            // 
            // cbxSQL
            // 
            this.cbxSQL.AutoSize = true;
            this.cbxSQL.Location = new System.Drawing.Point(12, 44);
            this.cbxSQL.Name = "cbxSQL";
            this.cbxSQL.Size = new System.Drawing.Size(47, 17);
            this.cbxSQL.TabIndex = 1;
            this.cbxSQL.Text = "SQL";
            this.cbxSQL.UseVisualStyleBackColor = true;
            this.cbxSQL.CheckedChanged += new System.EventHandler(this.cbxSQL_CheckedChanged);
            // 
            // cbxC
            // 
            this.cbxC.AutoSize = true;
            this.cbxC.Location = new System.Drawing.Point(12, 80);
            this.cbxC.Name = "cbxC";
            this.cbxC.Size = new System.Drawing.Size(33, 17);
            this.cbxC.TabIndex = 2;
            this.cbxC.Text = "C";
            this.cbxC.UseVisualStyleBackColor = true;
            // 
            // cbxPython
            // 
            this.cbxPython.AutoSize = true;
            this.cbxPython.Location = new System.Drawing.Point(12, 116);
            this.cbxPython.Name = "cbxPython";
            this.cbxPython.Size = new System.Drawing.Size(59, 17);
            this.cbxPython.TabIndex = 3;
            this.cbxPython.Text = "Python";
            this.cbxPython.UseVisualStyleBackColor = true;
            // 
            // btnCursosEscolhidos
            // 
            this.btnCursosEscolhidos.Location = new System.Drawing.Point(130, 6);
            this.btnCursosEscolhidos.Name = "btnCursosEscolhidos";
            this.btnCursosEscolhidos.Size = new System.Drawing.Size(186, 23);
            this.btnCursosEscolhidos.TabIndex = 4;
            this.btnCursosEscolhidos.Text = "Cursos Escolhidos";
            this.btnCursosEscolhidos.UseVisualStyleBackColor = true;
            this.btnCursosEscolhidos.Click += new System.EventHandler(this.btnCursosEscolhidos_Click);
            // 
            // cbxHTML
            // 
            this.cbxHTML.AutoSize = true;
            this.cbxHTML.Location = new System.Drawing.Point(12, 184);
            this.cbxHTML.Name = "cbxHTML";
            this.cbxHTML.Size = new System.Drawing.Size(56, 17);
            this.cbxHTML.TabIndex = 5;
            this.cbxHTML.Text = "HTML";
            this.cbxHTML.UseVisualStyleBackColor = true;
            this.cbxHTML.CheckedChanged += new System.EventHandler(this.cbxHTML_CheckedChanged);
            // 
            // clbCursos
            // 
            this.clbCursos.FormattingEnabled = true;
            this.clbCursos.Items.AddRange(new object[] {
            "C#",
            "SQL",
            "C",
            "Python"});
            this.clbCursos.Location = new System.Drawing.Point(360, 6);
            this.clbCursos.Name = "clbCursos";
            this.clbCursos.Size = new System.Drawing.Size(147, 154);
            this.clbCursos.TabIndex = 6;
            // 
            // btnMostrarSelecionados
            // 
            this.btnMostrarSelecionados.Location = new System.Drawing.Point(523, 6);
            this.btnMostrarSelecionados.Name = "btnMostrarSelecionados";
            this.btnMostrarSelecionados.Size = new System.Drawing.Size(162, 23);
            this.btnMostrarSelecionados.TabIndex = 7;
            this.btnMostrarSelecionados.Text = "Mostrar Selecionados";
            this.btnMostrarSelecionados.UseVisualStyleBackColor = true;
            this.btnMostrarSelecionados.Click += new System.EventHandler(this.btnMostrarSelecionados_Click);
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.Location = new System.Drawing.Point(523, 44);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(162, 23);
            this.btnLimparLista.TabIndex = 8;
            this.btnLimparLista.Text = "Limpar Lista";
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // btnAdicionarCurso
            // 
            this.btnAdicionarCurso.Location = new System.Drawing.Point(523, 137);
            this.btnAdicionarCurso.Name = "btnAdicionarCurso";
            this.btnAdicionarCurso.Size = new System.Drawing.Size(162, 23);
            this.btnAdicionarCurso.TabIndex = 9;
            this.btnAdicionarCurso.Text = "Adicionar Curso";
            this.btnAdicionarCurso.UseVisualStyleBackColor = true;
            this.btnAdicionarCurso.Click += new System.EventHandler(this.btnAdicionarCurso_Click);
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(523, 111);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(162, 20);
            this.txtCurso.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 380);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.btnAdicionarCurso);
            this.Controls.Add(this.btnLimparLista);
            this.Controls.Add(this.btnMostrarSelecionados);
            this.Controls.Add(this.clbCursos);
            this.Controls.Add(this.cbxHTML);
            this.Controls.Add(this.btnCursosEscolhidos);
            this.Controls.Add(this.cbxPython);
            this.Controls.Add(this.cbxC);
            this.Controls.Add(this.cbxSQL);
            this.Controls.Add(this.cbxCSharp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxCSharp;
        private System.Windows.Forms.CheckBox cbxSQL;
        private System.Windows.Forms.CheckBox cbxC;
        private System.Windows.Forms.CheckBox cbxPython;
        private System.Windows.Forms.Button btnCursosEscolhidos;
        private System.Windows.Forms.CheckBox cbxHTML;
        private System.Windows.Forms.CheckedListBox clbCursos;
        private System.Windows.Forms.Button btnMostrarSelecionados;
        private System.Windows.Forms.Button btnLimparLista;
        private System.Windows.Forms.Button btnAdicionarCurso;
        private System.Windows.Forms.TextBox txtCurso;
    }
}

