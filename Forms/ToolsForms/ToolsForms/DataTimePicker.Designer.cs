namespace ToolsForms
{
    partial class DataTimePicker
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
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnObterData = new System.Windows.Forms.Button();
            this.tbxData = new System.Windows.Forms.TextBox();
            this.tbxDia = new System.Windows.Forms.TextBox();
            this.tbxMes = new System.Windows.Forms.TextBox();
            this.tbxAno = new System.Windows.Forms.TextBox();
            this.btnSetarData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(0, 12);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(524, 20);
            this.dtpData.TabIndex = 0;
            // 
            // btnObterData
            // 
            this.btnObterData.Location = new System.Drawing.Point(530, 9);
            this.btnObterData.Name = "btnObterData";
            this.btnObterData.Size = new System.Drawing.Size(274, 23);
            this.btnObterData.TabIndex = 1;
            this.btnObterData.Text = "Obter Data";
            this.btnObterData.UseVisualStyleBackColor = true;
            this.btnObterData.Click += new System.EventHandler(this.btnObterData_Click);
            // 
            // tbxData
            // 
            this.tbxData.Location = new System.Drawing.Point(0, 52);
            this.tbxData.Name = "tbxData";
            this.tbxData.Size = new System.Drawing.Size(524, 20);
            this.tbxData.TabIndex = 2;
            // 
            // tbxDia
            // 
            this.tbxDia.Location = new System.Drawing.Point(0, 99);
            this.tbxDia.Name = "tbxDia";
            this.tbxDia.Size = new System.Drawing.Size(167, 20);
            this.tbxDia.TabIndex = 3;
            // 
            // tbxMes
            // 
            this.tbxMes.Location = new System.Drawing.Point(173, 99);
            this.tbxMes.Name = "tbxMes";
            this.tbxMes.Size = new System.Drawing.Size(178, 20);
            this.tbxMes.TabIndex = 4;
            // 
            // tbxAno
            // 
            this.tbxAno.Location = new System.Drawing.Point(357, 99);
            this.tbxAno.Name = "tbxAno";
            this.tbxAno.Size = new System.Drawing.Size(167, 20);
            this.tbxAno.TabIndex = 5;
            // 
            // btnSetarData
            // 
            this.btnSetarData.Location = new System.Drawing.Point(530, 99);
            this.btnSetarData.Name = "btnSetarData";
            this.btnSetarData.Size = new System.Drawing.Size(274, 23);
            this.btnSetarData.TabIndex = 9;
            this.btnSetarData.Text = "Setar Data";
            this.btnSetarData.UseVisualStyleBackColor = true;
            this.btnSetarData.Click += new System.EventHandler(this.btnSetarData_Click);
            // 
            // DataTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSetarData);
            this.Controls.Add(this.tbxAno);
            this.Controls.Add(this.tbxMes);
            this.Controls.Add(this.tbxDia);
            this.Controls.Add(this.tbxData);
            this.Controls.Add(this.btnObterData);
            this.Controls.Add(this.dtpData);
            this.Name = "DataTimePicker";
            this.Text = "DataTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnObterData;
        private System.Windows.Forms.TextBox tbxData;
        private System.Windows.Forms.TextBox tbxDia;
        private System.Windows.Forms.TextBox tbxMes;
        private System.Windows.Forms.TextBox tbxAno;
        private System.Windows.Forms.Button btnSetarData;
    }
}