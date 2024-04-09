namespace DataTimePicker
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
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.tbxData = new System.Windows.Forms.TextBox();
            this.tbxDia = new System.Windows.Forms.TextBox();
            this.tbxMes = new System.Windows.Forms.TextBox();
            this.tbxAno = new System.Windows.Forms.TextBox();
            this.btnObterData = new System.Windows.Forms.Button();
            this.btnAlterarData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(1, 12);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(545, 20);
            this.dtpData.TabIndex = 0;
            // 
            // tbxData
            // 
            this.tbxData.Location = new System.Drawing.Point(1, 54);
            this.tbxData.Name = "tbxData";
            this.tbxData.Size = new System.Drawing.Size(545, 20);
            this.tbxData.TabIndex = 1;
            // 
            // tbxDia
            // 
            this.tbxDia.Location = new System.Drawing.Point(1, 107);
            this.tbxDia.Name = "tbxDia";
            this.tbxDia.Size = new System.Drawing.Size(166, 20);
            this.tbxDia.TabIndex = 2;
            // 
            // tbxMes
            // 
            this.tbxMes.Location = new System.Drawing.Point(190, 107);
            this.tbxMes.Name = "tbxMes";
            this.tbxMes.Size = new System.Drawing.Size(166, 20);
            this.tbxMes.TabIndex = 3;
            // 
            // tbxAno
            // 
            this.tbxAno.Location = new System.Drawing.Point(380, 107);
            this.tbxAno.Name = "tbxAno";
            this.tbxAno.Size = new System.Drawing.Size(166, 20);
            this.tbxAno.TabIndex = 4;
            // 
            // btnObterData
            // 
            this.btnObterData.Location = new System.Drawing.Point(567, 9);
            this.btnObterData.Name = "btnObterData";
            this.btnObterData.Size = new System.Drawing.Size(205, 23);
            this.btnObterData.TabIndex = 5;
            this.btnObterData.Text = "Obter Data";
            this.btnObterData.UseVisualStyleBackColor = true;
            this.btnObterData.Click += new System.EventHandler(this.btnObterData_Click);
            // 
            // btnAlterarData
            // 
            this.btnAlterarData.Location = new System.Drawing.Point(567, 105);
            this.btnAlterarData.Name = "btnAlterarData";
            this.btnAlterarData.Size = new System.Drawing.Size(205, 23);
            this.btnAlterarData.TabIndex = 6;
            this.btnAlterarData.Text = "Alterar Data";
            this.btnAlterarData.UseVisualStyleBackColor = true;
            this.btnAlterarData.Click += new System.EventHandler(this.btnAlterarData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 434);
            this.Controls.Add(this.btnAlterarData);
            this.Controls.Add(this.btnObterData);
            this.Controls.Add(this.tbxAno);
            this.Controls.Add(this.tbxMes);
            this.Controls.Add(this.tbxDia);
            this.Controls.Add(this.tbxData);
            this.Controls.Add(this.dtpData);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox tbxData;
        private System.Windows.Forms.TextBox tbxDia;
        private System.Windows.Forms.TextBox tbxMes;
        private System.Windows.Forms.TextBox tbxAno;
        private System.Windows.Forms.Button btnObterData;
        private System.Windows.Forms.Button btnAlterarData;
    }
}

