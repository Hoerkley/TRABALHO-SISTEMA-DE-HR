namespace iRh.Windows.Cadastros
{
    partial class frmFuncionarios
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
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.rbTemFilhosSim = new System.Windows.Forms.RadioButton();
            this.rbTemFilhosNao = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilhoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.panelExibeDadosFilhos = new System.Windows.Forms.Panel();
            this.txtFilhoDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.panelExibeDadosFilhos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbGenero
            // 
            this.cmbGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Binário",
            "Polifractal de Genero",
            "Ceterogenero",
            "Trans masculino",
            "Trans feminino",
            "Não opinar"});
            this.cmbGenero.Location = new System.Drawing.Point(26, 12);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 0;
            // 
            // rbTemFilhosSim
            // 
            this.rbTemFilhosSim.AutoSize = true;
            this.rbTemFilhosSim.Location = new System.Drawing.Point(22, 103);
            this.rbTemFilhosSim.Name = "rbTemFilhosSim";
            this.rbTemFilhosSim.Size = new System.Drawing.Size(42, 17);
            this.rbTemFilhosSim.TabIndex = 1;
            this.rbTemFilhosSim.TabStop = true;
            this.rbTemFilhosSim.Text = "Sim";
            this.rbTemFilhosSim.UseVisualStyleBackColor = true;
            this.rbTemFilhosSim.CheckedChanged += new System.EventHandler(this.rbTemFilhosSim_CheckedChanged);
            // 
            // rbTemFilhosNao
            // 
            this.rbTemFilhosNao.AutoSize = true;
            this.rbTemFilhosNao.Location = new System.Drawing.Point(77, 103);
            this.rbTemFilhosNao.Name = "rbTemFilhosNao";
            this.rbTemFilhosNao.Size = new System.Drawing.Size(45, 17);
            this.rbTemFilhosNao.TabIndex = 2;
            this.rbTemFilhosNao.TabStop = true;
            this.rbTemFilhosNao.Text = "Não";
            this.rbTemFilhosNao.UseVisualStyleBackColor = true;
            this.rbTemFilhosNao.CheckedChanged += new System.EventHandler(this.rbTemFilhosNao_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Você possui filhos?";
            // 
            // txtFilhoNome
            // 
            this.txtFilhoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFilhoNome.Location = new System.Drawing.Point(3, 26);
            this.txtFilhoNome.Name = "txtFilhoNome";
            this.txtFilhoNome.Size = new System.Drawing.Size(100, 20);
            this.txtFilhoNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do seu filho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de nascimento";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(245, 29);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(44, 13);
            this.lblIdade.TabIndex = 8;
            this.lblIdade.Text = "lblIdade";
            this.lblIdade.Visible = false;
            // 
            // panelExibeDadosFilhos
            // 
            this.panelExibeDadosFilhos.Controls.Add(this.txtFilhoDataNascimento);
            this.panelExibeDadosFilhos.Controls.Add(this.label3);
            this.panelExibeDadosFilhos.Controls.Add(this.label2);
            this.panelExibeDadosFilhos.Controls.Add(this.lblIdade);
            this.panelExibeDadosFilhos.Controls.Add(this.txtFilhoNome);
            this.panelExibeDadosFilhos.Location = new System.Drawing.Point(2, 138);
            this.panelExibeDadosFilhos.Name = "panelExibeDadosFilhos";
            this.panelExibeDadosFilhos.Size = new System.Drawing.Size(302, 52);
            this.panelExibeDadosFilhos.TabIndex = 9;
            this.panelExibeDadosFilhos.Visible = false;
            // 
            // txtFilhoDataNascimento
            // 
            this.txtFilhoDataNascimento.Location = new System.Drawing.Point(129, 26);
            this.txtFilhoDataNascimento.Mask = "00/00/0000";
            this.txtFilhoDataNascimento.Name = "txtFilhoDataNascimento";
            this.txtFilhoDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtFilhoDataNascimento.TabIndex = 10;
            this.txtFilhoDataNascimento.ValidatingType = typeof(System.DateTime);
            this.txtFilhoDataNascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilhoDataNascimento_KeyDown);
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelExibeDadosFilhos);
            this.Controls.Add(this.rbTemFilhosNao);
            this.Controls.Add(this.rbTemFilhosSim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGenero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFuncionarios";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.panelExibeDadosFilhos.ResumeLayout(false);
            this.panelExibeDadosFilhos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.RadioButton rbTemFilhosSim;
        private System.Windows.Forms.RadioButton rbTemFilhosNao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilhoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Panel panelExibeDadosFilhos;
        private System.Windows.Forms.MaskedTextBox txtFilhoDataNascimento;
    }
}