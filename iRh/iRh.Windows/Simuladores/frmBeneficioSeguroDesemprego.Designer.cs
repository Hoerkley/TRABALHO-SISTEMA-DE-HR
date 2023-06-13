namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioSeguroDesemprego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioSeguroDesemprego));
            this.chkJustaCausa = new System.Windows.Forms.CheckBox();
            this.txtMesesEmpregado = new System.Windows.Forms.TextBox();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.chkRendaPropria = new System.Windows.Forms.CheckBox();
            this.lblBeneficio = new System.Windows.Forms.Label();
            this.chkBeneficio = new System.Windows.Forms.CheckBox();
            this.lblSolicitacao = new System.Windows.Forms.Label();
            this.lblMesesEmpregado = new System.Windows.Forms.Label();
            this.rbSolicitacao1 = new System.Windows.Forms.RadioButton();
            this.rbSolicitacao2 = new System.Windows.Forms.RadioButton();
            this.rbSolicitacao3 = new System.Windows.Forms.RadioButton();
            this.panelSolicitacao = new System.Windows.Forms.Panel();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.pictureBoxSeguroDesemprego = new System.Windows.Forms.PictureBox();
            this.panelResultado.SuspendLayout();
            this.panelSolicitacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeguroDesemprego)).BeginInit();
            this.SuspendLayout();
            // 
            // chkJustaCausa
            // 
            this.chkJustaCausa.AutoSize = true;
            this.chkJustaCausa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJustaCausa.Location = new System.Drawing.Point(15, 33);
            this.chkJustaCausa.Name = "chkJustaCausa";
            this.chkJustaCausa.Size = new System.Drawing.Size(314, 21);
            this.chkJustaCausa.TabIndex = 1;
            this.chkJustaCausa.Text = "O trabalhador foi despensado por justa causa?";
            this.chkJustaCausa.UseVisualStyleBackColor = true;
            // 
            // txtMesesEmpregado
            // 
            this.txtMesesEmpregado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesesEmpregado.Location = new System.Drawing.Point(3, 199);
            this.txtMesesEmpregado.Name = "txtMesesEmpregado";
            this.txtMesesEmpregado.Size = new System.Drawing.Size(94, 25);
            this.txtMesesEmpregado.TabIndex = 2;
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(344, 449);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(449, 78);
            this.panelResultado.TabIndex = 3;
            this.panelResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(3, 19);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(110, 30);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.Text = "Resultado";
            // 
            // chkRendaPropria
            // 
            this.chkRendaPropria.AutoSize = true;
            this.chkRendaPropria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRendaPropria.Location = new System.Drawing.Point(15, 60);
            this.chkRendaPropria.Name = "chkRendaPropria";
            this.chkRendaPropria.Size = new System.Drawing.Size(251, 21);
            this.chkRendaPropria.TabIndex = 5;
            this.chkRendaPropria.Text = "o colaborador possui renda propria?";
            this.chkRendaPropria.UseVisualStyleBackColor = true;
            // 
            // lblBeneficio
            // 
            this.lblBeneficio.AutoSize = true;
            this.lblBeneficio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficio.Location = new System.Drawing.Point(11, 9);
            this.lblBeneficio.Name = "lblBeneficio";
            this.lblBeneficio.Size = new System.Drawing.Size(316, 21);
            this.lblBeneficio.TabIndex = 6;
            this.lblBeneficio.Text = "Informe abixo as opções que se encaixa ";
            // 
            // chkBeneficio
            // 
            this.chkBeneficio.AutoSize = true;
            this.chkBeneficio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBeneficio.Location = new System.Drawing.Point(15, 87);
            this.chkBeneficio.Name = "chkBeneficio";
            this.chkBeneficio.Size = new System.Drawing.Size(550, 21);
            this.chkBeneficio.TabIndex = 7;
            this.chkBeneficio.Text = "o colaborador está recebendo beneficio de prestação continua da previdência socia" +
    "l?";
            this.chkBeneficio.UseVisualStyleBackColor = true;
            // 
            // lblSolicitacao
            // 
            this.lblSolicitacao.AutoSize = true;
            this.lblSolicitacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitacao.Location = new System.Drawing.Point(3, 8);
            this.lblSolicitacao.Name = "lblSolicitacao";
            this.lblSolicitacao.Size = new System.Drawing.Size(312, 21);
            this.lblSolicitacao.TabIndex = 8;
            this.lblSolicitacao.Text = "informe qual a solitação do funcionário";
            // 
            // lblMesesEmpregado
            // 
            this.lblMesesEmpregado.AutoSize = true;
            this.lblMesesEmpregado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesesEmpregado.Location = new System.Drawing.Point(3, 163);
            this.lblMesesEmpregado.Name = "lblMesesEmpregado";
            this.lblMesesEmpregado.Size = new System.Drawing.Size(592, 21);
            this.lblMesesEmpregado.TabIndex = 12;
            this.lblMesesEmpregado.Text = "informe a quantidade de tempo do colaborador está na empresa (em meses)\r\n";
            // 
            // rbSolicitacao1
            // 
            this.rbSolicitacao1.AutoSize = true;
            this.rbSolicitacao1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSolicitacao1.Location = new System.Drawing.Point(3, 42);
            this.rbSolicitacao1.Name = "rbSolicitacao1";
            this.rbSolicitacao1.Size = new System.Drawing.Size(306, 21);
            this.rbSolicitacao1.TabIndex = 13;
            this.rbSolicitacao1.TabStop = true;
            this.rbSolicitacao1.Text = "Caso seja primeira solicitação do colaborador";
            this.rbSolicitacao1.UseVisualStyleBackColor = true;
            // 
            // rbSolicitacao2
            // 
            this.rbSolicitacao2.AutoSize = true;
            this.rbSolicitacao2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSolicitacao2.Location = new System.Drawing.Point(3, 78);
            this.rbSolicitacao2.Name = "rbSolicitacao2";
            this.rbSolicitacao2.Size = new System.Drawing.Size(333, 21);
            this.rbSolicitacao2.TabIndex = 14;
            this.rbSolicitacao2.TabStop = true;
            this.rbSolicitacao2.Text = "Caso seja segunda solicitação do colabolaborador";
            this.rbSolicitacao2.UseVisualStyleBackColor = true;
            // 
            // rbSolicitacao3
            // 
            this.rbSolicitacao3.AutoSize = true;
            this.rbSolicitacao3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSolicitacao3.Location = new System.Drawing.Point(3, 115);
            this.rbSolicitacao3.Name = "rbSolicitacao3";
            this.rbSolicitacao3.Size = new System.Drawing.Size(380, 21);
            this.rbSolicitacao3.TabIndex = 15;
            this.rbSolicitacao3.TabStop = true;
            this.rbSolicitacao3.Text = "Caso seja terceira ou mais solicitação do colabolaborador";
            this.rbSolicitacao3.UseVisualStyleBackColor = true;
            // 
            // panelSolicitacao
            // 
            this.panelSolicitacao.Controls.Add(this.btnSimular);
            this.panelSolicitacao.Controls.Add(this.lblSolicitacao);
            this.panelSolicitacao.Controls.Add(this.lblMesesEmpregado);
            this.panelSolicitacao.Controls.Add(this.rbSolicitacao1);
            this.panelSolicitacao.Controls.Add(this.rbSolicitacao2);
            this.panelSolicitacao.Controls.Add(this.rbSolicitacao3);
            this.panelSolicitacao.Controls.Add(this.txtMesesEmpregado);
            this.panelSolicitacao.Location = new System.Drawing.Point(12, 161);
            this.panelSolicitacao.Name = "panelSolicitacao";
            this.panelSolicitacao.Size = new System.Drawing.Size(652, 282);
            this.panelSolicitacao.TabIndex = 14;
            this.panelSolicitacao.Visible = false;
            // 
            // btnSimular
            // 
            this.btnSimular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSimular.Location = new System.Drawing.Point(3, 239);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(108, 31);
            this.btnSimular.TabIndex = 16;
            this.btnSimular.Text = "Simular -->";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuar.Location = new System.Drawing.Point(15, 114);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(108, 31);
            this.btnContinuar.TabIndex = 15;
            this.btnContinuar.Text = "Continuar -->";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // pictureBoxSeguroDesemprego
            // 
       
            this.pictureBoxSeguroDesemprego.Location = new System.Drawing.Point(494, 146);
            this.pictureBoxSeguroDesemprego.Name = "pictureBoxSeguroDesemprego";
            this.pictureBoxSeguroDesemprego.Size = new System.Drawing.Size(357, 175);
            this.pictureBoxSeguroDesemprego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSeguroDesemprego.TabIndex = 16;
            this.pictureBoxSeguroDesemprego.TabStop = false;
            // 
            // frmBeneficioSeguroDesemprego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(849, 530);
            this.Controls.Add(this.pictureBoxSeguroDesemprego);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.panelSolicitacao);
            this.Controls.Add(this.chkBeneficio);
            this.Controls.Add(this.lblBeneficio);
            this.Controls.Add(this.chkRendaPropria);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.chkJustaCausa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBeneficioSeguroDesemprego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBeneficioSeguroDesemprego";

            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.panelSolicitacao.ResumeLayout(false);
            this.panelSolicitacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeguroDesemprego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkJustaCausa;
        private System.Windows.Forms.TextBox txtMesesEmpregado;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.CheckBox chkRendaPropria;
        private System.Windows.Forms.Label lblBeneficio;
        private System.Windows.Forms.CheckBox chkBeneficio;
        private System.Windows.Forms.Label lblSolicitacao;
        private System.Windows.Forms.Label lblMesesEmpregado;
        private System.Windows.Forms.RadioButton rbSolicitacao1;
        private System.Windows.Forms.RadioButton rbSolicitacao2;
        private System.Windows.Forms.RadioButton rbSolicitacao3;
        private System.Windows.Forms.Panel panelSolicitacao;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.PictureBox pictureBoxSeguroDesemprego;
    }
}