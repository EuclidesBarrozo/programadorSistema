namespace BancoDeTalentos
{
    partial class GestaoCurrículos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxTelefone = new System.Windows.Forms.TextBox();
            this.cbxEscolaridade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxProfissao2 = new System.Windows.Forms.TextBox();
            this.tbxProfissao1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxCurso2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxCurso1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvCurriculos = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurriculos)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Gestão de Currículo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxNome);
            this.groupBox3.Controls.Add(this.tbxTelefone);
            this.groupBox3.Controls.Add(this.cbxEscolaridade);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtpDataNascimento);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(21, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(601, 139);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Pessoais";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(21, 42);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(234, 20);
            this.tbxNome.TabIndex = 0;
            // 
            // tbxTelefone
            // 
            this.tbxTelefone.Location = new System.Drawing.Point(21, 101);
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.Size = new System.Drawing.Size(234, 20);
            this.tbxTelefone.TabIndex = 1;
            // 
            // cbxEscolaridade
            // 
            this.cbxEscolaridade.FormattingEnabled = true;
            this.cbxEscolaridade.Items.AddRange(new object[] {
            "Ensino Médio",
            "Ensino Técnico",
            "Ensino Superior"});
            this.cbxEscolaridade.Location = new System.Drawing.Point(349, 101);
            this.cbxEscolaridade.Name = "cbxEscolaridade";
            this.cbxEscolaridade.Size = new System.Drawing.Size(234, 21);
            this.cbxEscolaridade.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data de Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(349, 42);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(234, 20);
            this.dtpDataNascimento.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Escolaridade";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxProfissao2);
            this.groupBox2.Controls.Add(this.tbxProfissao1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(21, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preferências Profissionais";
            // 
            // tbxProfissao2
            // 
            this.tbxProfissao2.Location = new System.Drawing.Point(349, 43);
            this.tbxProfissao2.Name = "tbxProfissao2";
            this.tbxProfissao2.Size = new System.Drawing.Size(234, 20);
            this.tbxProfissao2.TabIndex = 11;
            // 
            // tbxProfissao1
            // 
            this.tbxProfissao1.Location = new System.Drawing.Point(21, 43);
            this.tbxProfissao1.Name = "tbxProfissao1";
            this.tbxProfissao1.Size = new System.Drawing.Size(234, 20);
            this.tbxProfissao1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "2ª Opção";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "1ª Opção";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxCurso2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxCurso1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(21, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Principais Cursos";
            // 
            // tbxCurso2
            // 
            this.tbxCurso2.Location = new System.Drawing.Point(349, 42);
            this.tbxCurso2.Name = "tbxCurso2";
            this.tbxCurso2.Size = new System.Drawing.Size(234, 20);
            this.tbxCurso2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "2ª Curso";
            // 
            // tbxCurso1
            // 
            this.tbxCurso1.Location = new System.Drawing.Point(21, 42);
            this.tbxCurso1.Name = "tbxCurso1";
            this.tbxCurso1.Size = new System.Drawing.Size(234, 20);
            this.tbxCurso1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "1ª Curso";
            // 
            // dgvCurriculos
            // 
            this.dgvCurriculos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurriculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurriculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurriculos.EnableHeadersVisualStyles = false;
            this.dgvCurriculos.Location = new System.Drawing.Point(663, 60);
            this.dgvCurriculos.MultiSelect = false;
            this.dgvCurriculos.Name = "dgvCurriculos";
            this.dgvCurriculos.ReadOnly = true;
            this.dgvCurriculos.RowHeadersVisible = false;
            this.dgvCurriculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurriculos.Size = new System.Drawing.Size(465, 374);
            this.dgvCurriculos.TabIndex = 24;
            this.dgvCurriculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurriculos_CellContentClick);
            this.dgvCurriculos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurriculos_CellDoubleClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(23, 440);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(113, 440);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 26;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // GestaoCurrículos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 481);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvCurriculos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestaoCurrículos";
            this.Text = "Gestao de Currículos";
            this.Load += new System.EventHandler(this.GestaoCurrículos_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurriculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxTelefone;
        private System.Windows.Forms.ComboBox cbxEscolaridade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxProfissao2;
        private System.Windows.Forms.TextBox tbxProfissao1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxCurso2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxCurso1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvCurriculos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
    }
}