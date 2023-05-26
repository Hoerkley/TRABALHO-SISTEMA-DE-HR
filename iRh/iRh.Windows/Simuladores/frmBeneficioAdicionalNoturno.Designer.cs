namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioAdicionalNoturno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioAdicionalNoturno));
            this.lblSalarioAdicionalNoturno = new System.Windows.Forms.Label();
            this.txtSalarioAdicionalNoturno = new System.Windows.Forms.TextBox();
            this.btnCalcularAdicionalNoturno = new System.Windows.Forms.Button();
            this.lblHorasTrabalhadas = new System.Windows.Forms.Label();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.lblResultadoAdicionalNoturno = new System.Windows.Forms.Label();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalarioAdicionalNoturno
            // 
            this.lblSalarioAdicionalNoturno.AutoSize = true;
            this.lblSalarioAdicionalNoturno.BackColor = System.Drawing.Color.Transparent;
            this.lblSalarioAdicionalNoturno.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioAdicionalNoturno.Location = new System.Drawing.Point(12, 9);
            this.lblSalarioAdicionalNoturno.Name = "lblSalarioAdicionalNoturno";
            this.lblSalarioAdicionalNoturno.Size = new System.Drawing.Size(371, 37);
            this.lblSalarioAdicionalNoturno.TabIndex = 0;
            this.lblSalarioAdicionalNoturno.Text = "Informe seu salário abaixo  ";
            // 
            // txtSalarioAdicionalNoturno
            // 
            this.txtSalarioAdicionalNoturno.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioAdicionalNoturno.Location = new System.Drawing.Point(19, 49);
            this.txtSalarioAdicionalNoturno.Name = "txtSalarioAdicionalNoturno";
            this.txtSalarioAdicionalNoturno.Size = new System.Drawing.Size(339, 33);
            this.txtSalarioAdicionalNoturno.TabIndex = 1;
            // 
            // btnCalcularAdicionalNoturno
            // 
            this.btnCalcularAdicionalNoturno.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcularAdicionalNoturno.BackgroundImage = global::iRh.Windows.Properties.Resources.calculator_android_system_blue_smartphone_icon_252259;
            this.btnCalcularAdicionalNoturno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalcularAdicionalNoturno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularAdicionalNoturno.Location = new System.Drawing.Point(19, 203);
            this.btnCalcularAdicionalNoturno.Name = "btnCalcularAdicionalNoturno";
            this.btnCalcularAdicionalNoturno.Size = new System.Drawing.Size(184, 75);
            this.btnCalcularAdicionalNoturno.TabIndex = 2;
            this.btnCalcularAdicionalNoturno.Text = "Calcular";
            this.btnCalcularAdicionalNoturno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcularAdicionalNoturno.UseVisualStyleBackColor = false;
            this.btnCalcularAdicionalNoturno.Click += new System.EventHandler(this.btnCalcularAdicionalNoturno_Click);
            // 
            // lblHorasTrabalhadas
            // 
            this.lblHorasTrabalhadas.AutoSize = true;
            this.lblHorasTrabalhadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabalhadas.Location = new System.Drawing.Point(15, 103);
            this.lblHorasTrabalhadas.Name = "lblHorasTrabalhadas";
            this.lblHorasTrabalhadas.Size = new System.Drawing.Size(253, 21);
            this.lblHorasTrabalhadas.TabIndex = 3;
            this.lblHorasTrabalhadas.Text = "Informe a quabtidade de horas  ";
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(19, 148);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(339, 33);
            this.txtHorasTrabalhadas.TabIndex = 4;
            // 
            // lblResultadoAdicionalNoturno
            // 
            this.lblResultadoAdicionalNoturno.AutoSize = true;
            this.lblResultadoAdicionalNoturno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoAdicionalNoturno.Location = new System.Drawing.Point(14, 33);
            this.lblResultadoAdicionalNoturno.Name = "lblResultadoAdicionalNoturno";
            this.lblResultadoAdicionalNoturno.Size = new System.Drawing.Size(86, 21);
            this.lblResultadoAdicionalNoturno.TabIndex = 5;
            this.lblResultadoAdicionalNoturno.Text = "Resultado";
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.lblResultadoAdicionalNoturno);
            this.panelResultado.Location = new System.Drawing.Point(19, 338);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(339, 100);
            this.panelResultado.TabIndex = 6;
            this.panelResultado.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::iRh.Windows.Properties.Resources.adicional_noturnoteste2;
            this.pictureBox1.Location = new System.Drawing.Point(364, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmBeneficioAdicionalNoturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.lblHorasTrabalhadas);
            this.Controls.Add(this.btnCalcularAdicionalNoturno);
            this.Controls.Add(this.txtSalarioAdicionalNoturno);
            this.Controls.Add(this.lblSalarioAdicionalNoturno);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBeneficioAdicionalNoturno";
            this.Text = "frmBeneficioAdicionalNoturno";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioAdicionalNoturno;
        private System.Windows.Forms.TextBox txtSalarioAdicionalNoturno;
        private System.Windows.Forms.Button btnCalcularAdicionalNoturno;
        private System.Windows.Forms.Label lblHorasTrabalhadas;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.Label lblResultadoAdicionalNoturno;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}