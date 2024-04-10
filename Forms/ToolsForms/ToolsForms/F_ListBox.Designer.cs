namespace ToolsForms
{
    partial class F_ListBox
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
            this.lbxCursos = new System.Windows.Forms.ListBox();
            this.tbxCurso = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnObter = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxCursos
            // 
            this.lbxCursos.FormattingEnabled = true;
            this.lbxCursos.Location = new System.Drawing.Point(12, 12);
            this.lbxCursos.Name = "lbxCursos";
            this.lbxCursos.Size = new System.Drawing.Size(188, 147);
            this.lbxCursos.TabIndex = 0;
            // 
            // tbxCurso
            // 
            this.tbxCurso.Location = new System.Drawing.Point(229, 38);
            this.tbxCurso.Name = "tbxCurso";
            this.tbxCurso.Size = new System.Drawing.Size(233, 20);
            this.tbxCurso.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(229, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(310, 77);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnObter
            // 
            this.btnObter.Location = new System.Drawing.Point(391, 77);
            this.btnObter.Name = "btnObter";
            this.btnObter.Size = new System.Drawing.Size(75, 23);
            this.btnObter.TabIndex = 4;
            this.btnObter.Text = "Obter";
            this.btnObter.UseVisualStyleBackColor = true;
            this.btnObter.Click += new System.EventHandler(this.btnObter_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(229, 106);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(237, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnObter);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxCurso);
            this.Controls.Add(this.lbxCursos);
            this.Name = "F_ListBox";
            this.Text = "F_ListBox";
            this.Load += new System.EventHandler(this.lbxCursos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCursos;
        private System.Windows.Forms.TextBox tbxCurso;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnObter;
        private System.Windows.Forms.Button btnLimpar;
    }
}