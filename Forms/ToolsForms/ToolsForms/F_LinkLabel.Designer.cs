namespace ToolsForms
{
    partial class F_LinkLabel
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
            this.llGoogle = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.llCalculadora = new System.Windows.Forms.LinkLabel();
            this.llMultiplosLinks = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // llGoogle
            // 
            this.llGoogle.AutoSize = true;
            this.llGoogle.Location = new System.Drawing.Point(53, 66);
            this.llGoogle.Name = "llGoogle";
            this.llGoogle.Size = new System.Drawing.Size(41, 13);
            this.llGoogle.TabIndex = 0;
            this.llGoogle.TabStop = true;
            this.llGoogle.Text = "Google";
            this.llGoogle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGoogle_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Links relevantes";
            // 
            // llCalculadora
            // 
            this.llCalculadora.AutoSize = true;
            this.llCalculadora.Location = new System.Drawing.Point(53, 95);
            this.llCalculadora.Name = "llCalculadora";
            this.llCalculadora.Size = new System.Drawing.Size(63, 13);
            this.llCalculadora.TabIndex = 2;
            this.llCalculadora.TabStop = true;
            this.llCalculadora.Text = "Calculadora";
            this.llCalculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCalculadora_LinkClicked);
            // 
            // llMultiplosLinks
            // 
            this.llMultiplosLinks.AutoSize = true;
            this.llMultiplosLinks.Location = new System.Drawing.Point(53, 130);
            this.llMultiplosLinks.Name = "llMultiplosLinks";
            this.llMultiplosLinks.Size = new System.Drawing.Size(90, 13);
            this.llMultiplosLinks.TabIndex = 3;
            this.llMultiplosLinks.TabStop = true;
            this.llMultiplosLinks.Text = "Google - Youtube";
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llMultiplosLinks);
            this.Controls.Add(this.llCalculadora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llGoogle);
            this.Name = "F_LinkLabel";
            this.Text = "F_LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llGoogle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llCalculadora;
        private System.Windows.Forms.LinkLabel llMultiplosLinks;
    }
}