namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioHoraExtra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioHoraExtra));
            this.panelDomngosFeriados = new System.Windows.Forms.Panel();
            this.txtHoraDomingosFeriados = new System.Windows.Forms.TextBox();
            this.lblHoraDoingosFeriados = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSalrioFuncionarioHoraExtra = new System.Windows.Forms.Label();
            this.txtSalarioHoraExtra = new System.Windows.Forms.TextBox();
            this.lblDomingosFeriados = new System.Windows.Forms.Label();
            this.panelDiasUteis = new System.Windows.Forms.Panel();
            this.txtHoraDiasUteis = new System.Windows.Forms.TextBox();
            this.lblHoraDiasUteis = new System.Windows.Forms.Label();
            this.lblDiasUteis = new System.Windows.Forms.Label();
            this.panelResutado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rbDiasUteisNao = new System.Windows.Forms.RadioButton();
            this.rbDomingosFeriadosSim = new System.Windows.Forms.RadioButton();
            this.rbDomingosFeriadosNao = new System.Windows.Forms.RadioButton();
            this.rbDiasUteisSim = new System.Windows.Forms.RadioButton();
            this.groupDomingosFeriados = new System.Windows.Forms.GroupBox();
            this.groupDiasUteis = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDomngosFeriados.SuspendLayout();
            this.panelDiasUteis.SuspendLayout();
            this.panelResutado.SuspendLayout();
            this.groupDomingosFeriados.SuspendLayout();
            this.groupDiasUteis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDomngosFeriados
            // 
            this.panelDomngosFeriados.Controls.Add(this.txtHoraDomingosFeriados);
            this.panelDomngosFeriados.Controls.Add(this.lblHoraDoingosFeriados);
            this.panelDomngosFeriados.Location = new System.Drawing.Point(4, 184);
            this.panelDomngosFeriados.Name = "panelDomngosFeriados";
            this.panelDomngosFeriados.Size = new System.Drawing.Size(401, 79);
            this.panelDomngosFeriados.TabIndex = 0;
            this.panelDomngosFeriados.Visible = false;
            // 
            // txtHoraDomingosFeriados
            // 
            this.txtHoraDomingosFeriados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraDomingosFeriados.Location = new System.Drawing.Point(12, 43);
            this.txtHoraDomingosFeriados.Name = "txtHoraDomingosFeriados";
            this.txtHoraDomingosFeriados.Size = new System.Drawing.Size(100, 29);
            this.txtHoraDomingosFeriados.TabIndex = 7;
            // 
            // lblHoraDoingosFeriados
            // 
            this.lblHoraDoingosFeriados.AutoSize = true;
            this.lblHoraDoingosFeriados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraDoingosFeriados.Location = new System.Drawing.Point(8, 10);
            this.lblHoraDoingosFeriados.Name = "lblHoraDoingosFeriados";
            this.lblHoraDoingosFeriados.Size = new System.Drawing.Size(222, 21);
            this.lblHoraDoingosFeriados.TabIndex = 7;
            this.lblHoraDoingosFeriados.Text = "Informe as horas trabalhdas";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Location = new System.Drawing.Point(12, 287);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(184, 66);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSalrioFuncionarioHoraExtra
            // 
            this.lblSalrioFuncionarioHoraExtra.AutoSize = true;
            this.lblSalrioFuncionarioHoraExtra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalrioFuncionarioHoraExtra.Location = new System.Drawing.Point(12, 9);
            this.lblSalrioFuncionarioHoraExtra.Name = "lblSalrioFuncionarioHoraExtra";
            this.lblSalrioFuncionarioHoraExtra.Size = new System.Drawing.Size(257, 21);
            this.lblSalrioFuncionarioHoraExtra.TabIndex = 3;
            this.lblSalrioFuncionarioHoraExtra.Text = "Informe o salário do funcuinário";
            // 
            // txtSalarioHoraExtra
            // 
            this.txtSalarioHoraExtra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioHoraExtra.Location = new System.Drawing.Point(16, 44);
            this.txtSalarioHoraExtra.Name = "txtSalarioHoraExtra";
            this.txtSalarioHoraExtra.Size = new System.Drawing.Size(100, 29);
            this.txtSalarioHoraExtra.TabIndex = 4;

            // 
            // lblDomingosFeriados
            // 
            this.lblDomingosFeriados.AutoSize = true;
            this.lblDomingosFeriados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomingosFeriados.Location = new System.Drawing.Point(12, 96);
            this.lblDomingosFeriados.Name = "lblDomingosFeriados";
            this.lblDomingosFeriados.Size = new System.Drawing.Size(393, 21);
            this.lblDomingosFeriados.TabIndex = 5;
            this.lblDomingosFeriados.Text = "O funcionário trabalhou em domingos e feriados? ";
            // 
            // panelDiasUteis
            // 
            this.panelDiasUteis.Controls.Add(this.txtHoraDiasUteis);
            this.panelDiasUteis.Controls.Add(this.lblHoraDiasUteis);
            this.panelDiasUteis.Location = new System.Drawing.Point(426, 184);
            this.panelDiasUteis.Name = "panelDiasUteis";
            this.panelDiasUteis.Size = new System.Drawing.Size(401, 79);
            this.panelDiasUteis.TabIndex = 8;
            this.panelDiasUteis.Visible = false;
            // 
            // txtHoraDiasUteis
            // 
            this.txtHoraDiasUteis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraDiasUteis.Location = new System.Drawing.Point(12, 43);
            this.txtHoraDiasUteis.Name = "txtHoraDiasUteis";
            this.txtHoraDiasUteis.Size = new System.Drawing.Size(100, 29);
            this.txtHoraDiasUteis.TabIndex = 7;
            // 
            // lblHoraDiasUteis
            // 
            this.lblHoraDiasUteis.AutoSize = true;
            this.lblHoraDiasUteis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraDiasUteis.Location = new System.Drawing.Point(8, 10);
            this.lblHoraDiasUteis.Name = "lblHoraDiasUteis";
            this.lblHoraDiasUteis.Size = new System.Drawing.Size(222, 21);
            this.lblHoraDiasUteis.TabIndex = 7;
            this.lblHoraDiasUteis.Text = "Informe as horas trabalhdas";
            // 
            // lblDiasUteis
            // 
            this.lblDiasUteis.AutoSize = true;
            this.lblDiasUteis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasUteis.Location = new System.Drawing.Point(422, 96);
            this.lblDiasUteis.Name = "lblDiasUteis";
            this.lblDiasUteis.Size = new System.Drawing.Size(298, 21);
            this.lblDiasUteis.TabIndex = 9;
            this.lblDiasUteis.Text = "O funcionário trabalhou em dias uteis";
            // 
            // panelResutado
            // 
            this.panelResutado.Controls.Add(this.lblResultado);
            this.panelResutado.Location = new System.Drawing.Point(4, 368);
            this.panelResutado.Name = "panelResutado";
            this.panelResutado.Size = new System.Drawing.Size(330, 118);
            this.panelResutado.TabIndex = 12;
            this.panelResutado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(21, 22);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(110, 30);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // rbDiasUteisNao
            // 
            this.rbDiasUteisNao.AutoSize = true;
            this.rbDiasUteisNao.Location = new System.Drawing.Point(86, 29);
            this.rbDiasUteisNao.Name = "rbDiasUteisNao";
            this.rbDiasUteisNao.Size = new System.Drawing.Size(45, 17);
            this.rbDiasUteisNao.TabIndex = 13;
            this.rbDiasUteisNao.TabStop = true;
            this.rbDiasUteisNao.Text = "Não";
            this.rbDiasUteisNao.UseVisualStyleBackColor = true;
            this.rbDiasUteisNao.CheckedChanged += new System.EventHandler(this.rbDiasUteisNao_CheckedChanged);
            // 
            // rbDomingosFeriadosSim
            // 
            this.rbDomingosFeriadosSim.AutoSize = true;
            this.rbDomingosFeriadosSim.Location = new System.Drawing.Point(19, 29);
            this.rbDomingosFeriadosSim.Name = "rbDomingosFeriadosSim";
            this.rbDomingosFeriadosSim.Size = new System.Drawing.Size(42, 17);
            this.rbDomingosFeriadosSim.TabIndex = 15;
            this.rbDomingosFeriadosSim.TabStop = true;
            this.rbDomingosFeriadosSim.Text = "Sim";
            this.rbDomingosFeriadosSim.UseVisualStyleBackColor = true;
            this.rbDomingosFeriadosSim.CheckedChanged += new System.EventHandler(this.rbDomingosFeriadosSim_CheckedChanged);
            // 
            // rbDomingosFeriadosNao
            // 
            this.rbDomingosFeriadosNao.AutoSize = true;
            this.rbDomingosFeriadosNao.Location = new System.Drawing.Point(93, 29);
            this.rbDomingosFeriadosNao.Name = "rbDomingosFeriadosNao";
            this.rbDomingosFeriadosNao.Size = new System.Drawing.Size(45, 17);
            this.rbDomingosFeriadosNao.TabIndex = 16;
            this.rbDomingosFeriadosNao.TabStop = true;
            this.rbDomingosFeriadosNao.Text = "Não";
            this.rbDomingosFeriadosNao.UseVisualStyleBackColor = true;
            this.rbDomingosFeriadosNao.CheckedChanged += new System.EventHandler(this.rbDomingosFeriadosNao_CheckedChanged);
            // 
            // rbDiasUteisSim
            // 
            this.rbDiasUteisSim.AutoSize = true;
            this.rbDiasUteisSim.Location = new System.Drawing.Point(19, 29);
            this.rbDiasUteisSim.Name = "rbDiasUteisSim";
            this.rbDiasUteisSim.Size = new System.Drawing.Size(42, 17);
            this.rbDiasUteisSim.TabIndex = 17;
            this.rbDiasUteisSim.TabStop = true;
            this.rbDiasUteisSim.Text = "Sim";
            this.rbDiasUteisSim.UseVisualStyleBackColor = true;
            this.rbDiasUteisSim.CheckedChanged += new System.EventHandler(this.rbDiasUteisSim_CheckedChanged);
            // 
            // groupDomingosFeriados
            // 
            this.groupDomingosFeriados.Controls.Add(this.rbDomingosFeriadosSim);
            this.groupDomingosFeriados.Controls.Add(this.rbDomingosFeriadosNao);
            this.groupDomingosFeriados.Location = new System.Drawing.Point(16, 120);
            this.groupDomingosFeriados.Name = "groupDomingosFeriados";
            this.groupDomingosFeriados.Size = new System.Drawing.Size(151, 58);
            this.groupDomingosFeriados.TabIndex = 18;
            this.groupDomingosFeriados.TabStop = false;
            // 
            // groupDiasUteis
            // 
            this.groupDiasUteis.Controls.Add(this.rbDiasUteisSim);
            this.groupDiasUteis.Controls.Add(this.rbDiasUteisNao);
            this.groupDiasUteis.Location = new System.Drawing.Point(438, 120);
            this.groupDiasUteis.Name = "groupDiasUteis";
            this.groupDiasUteis.Size = new System.Drawing.Size(160, 58);
            this.groupDiasUteis.TabIndex = 19;
            this.groupDiasUteis.TabStop = false;
            // 
            // pictureBox1
            // 
        
            this.pictureBox1.Location = new System.Drawing.Point(376, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmBeneficioHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(952, 498);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupDiasUteis);
            this.Controls.Add(this.groupDomingosFeriados);
            this.Controls.Add(this.panelResutado);
            this.Controls.Add(this.lblDiasUteis);
            this.Controls.Add(this.panelDiasUteis);
            this.Controls.Add(this.lblDomingosFeriados);
            this.Controls.Add(this.txtSalarioHoraExtra);
            this.Controls.Add(this.lblSalrioFuncionarioHoraExtra);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panelDomngosFeriados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBeneficioHoraExtra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBeneficioHoraExtra";
            this.Load += new System.EventHandler(this.frmBeneficioHoraExtra_Load);

            this.panelDomngosFeriados.ResumeLayout(false);
            this.panelDomngosFeriados.PerformLayout();
            this.panelDiasUteis.ResumeLayout(false);
            this.panelDiasUteis.PerformLayout();
            this.panelResutado.ResumeLayout(false);
            this.panelResutado.PerformLayout();
            this.groupDomingosFeriados.ResumeLayout(false);
            this.groupDomingosFeriados.PerformLayout();
            this.groupDiasUteis.ResumeLayout(false);
            this.groupDiasUteis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDomngosFeriados;
        private System.Windows.Forms.TextBox txtHoraDomingosFeriados;
        private System.Windows.Forms.Label lblHoraDoingosFeriados;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSalrioFuncionarioHoraExtra;
        private System.Windows.Forms.TextBox txtSalarioHoraExtra;
        private System.Windows.Forms.Label lblDomingosFeriados;
        private System.Windows.Forms.Panel panelDiasUteis;
        private System.Windows.Forms.TextBox txtHoraDiasUteis;
        private System.Windows.Forms.Label lblHoraDiasUteis;
        private System.Windows.Forms.Label lblDiasUteis;
        private System.Windows.Forms.Panel panelResutado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RadioButton rbDiasUteisNao;
        private System.Windows.Forms.RadioButton rbDomingosFeriadosSim;
        private System.Windows.Forms.RadioButton rbDomingosFeriadosNao;
        private System.Windows.Forms.RadioButton rbDiasUteisSim;
        private System.Windows.Forms.GroupBox groupDomingosFeriados;
        private System.Windows.Forms.GroupBox groupDiasUteis;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}