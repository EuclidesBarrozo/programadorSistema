namespace ToolsForms
{
    partial class F_CheckBox
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
            this.cbCSharp = new System.Windows.Forms.CheckBox();
            this.cbSQL = new System.Windows.Forms.CheckBox();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.cbPython = new System.Windows.Forms.CheckBox();
            this.btnLinguagensMarcadas = new System.Windows.Forms.Button();
            this.cbHTML = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbCSharp
            // 
            this.cbCSharp.AutoSize = true;
            this.cbCSharp.Location = new System.Drawing.Point(32, 33);
            this.cbCSharp.Name = "cbCSharp";
            this.cbCSharp.Size = new System.Drawing.Size(61, 17);
            this.cbCSharp.TabIndex = 0;
            this.cbCSharp.Text = "CSharp";
            this.cbCSharp.UseVisualStyleBackColor = true;
            // 
            // cbSQL
            // 
            this.cbSQL.AutoSize = true;
            this.cbSQL.Location = new System.Drawing.Point(32, 56);
            this.cbSQL.Name = "cbSQL";
            this.cbSQL.Size = new System.Drawing.Size(47, 17);
            this.cbSQL.TabIndex = 1;
            this.cbSQL.Text = "SQL";
            this.cbSQL.UseVisualStyleBackColor = true;
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.Location = new System.Drawing.Point(32, 79);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(33, 17);
            this.cbC.TabIndex = 2;
            this.cbC.Text = "C";
            this.cbC.UseVisualStyleBackColor = true;
            // 
            // cbPython
            // 
            this.cbPython.AutoSize = true;
            this.cbPython.Location = new System.Drawing.Point(32, 102);
            this.cbPython.Name = "cbPython";
            this.cbPython.Size = new System.Drawing.Size(59, 17);
            this.cbPython.TabIndex = 3;
            this.cbPython.Text = "Python";
            this.cbPython.UseVisualStyleBackColor = true;
            // 
            // btnLinguagensMarcadas
            // 
            this.btnLinguagensMarcadas.Location = new System.Drawing.Point(224, 33);
            this.btnLinguagensMarcadas.Name = "btnLinguagensMarcadas";
            this.btnLinguagensMarcadas.Size = new System.Drawing.Size(248, 23);
            this.btnLinguagensMarcadas.TabIndex = 4;
            this.btnLinguagensMarcadas.Text = "Linguagens Marcadas";
            this.btnLinguagensMarcadas.UseVisualStyleBackColor = true;
            this.btnLinguagensMarcadas.Click += new System.EventHandler(this.btnLinguagensMarcadas_Click);
            // 
            // cbHTML
            // 
            this.cbHTML.AutoSize = true;
            this.cbHTML.Location = new System.Drawing.Point(32, 166);
            this.cbHTML.Name = "cbHTML";
            this.cbHTML.Size = new System.Drawing.Size(56, 17);
            this.cbHTML.TabIndex = 5;
            this.cbHTML.Text = "HTML";
            this.cbHTML.UseVisualStyleBackColor = true;
            this.cbHTML.CheckedChanged += new System.EventHandler(this.cbHTML_CheckedChanged);
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 298);
            this.Controls.Add(this.cbHTML);
            this.Controls.Add(this.btnLinguagensMarcadas);
            this.Controls.Add(this.cbPython);
            this.Controls.Add(this.cbC);
            this.Controls.Add(this.cbSQL);
            this.Controls.Add(this.cbCSharp);
            this.Name = "F_CheckBox";
            this.Text = "F_CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbCSharp;
        private System.Windows.Forms.CheckBox cbSQL;
        private System.Windows.Forms.CheckBox cbC;
        private System.Windows.Forms.CheckBox cbPython;
        private System.Windows.Forms.Button btnLinguagensMarcadas;
        private System.Windows.Forms.CheckBox cbHTML;
    }
}