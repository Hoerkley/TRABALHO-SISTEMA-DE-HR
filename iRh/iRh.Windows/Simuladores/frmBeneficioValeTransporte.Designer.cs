namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioValeTransporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioValeTransporte));
            this.label1 = new System.Windows.Forms.Label();
            this.lblSalarioValeTransporte = new System.Windows.Forms.Label();
            this.txtSalarioValeTRansporte = new System.Windows.Forms.TextBox();
            this.lblResultadoVAleTransporte = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo ao calculo do Vale Transporte";
            // 
            // lblSalarioValeTransporte
            // 
            this.lblSalarioValeTransporte.AutoSize = true;
            this.lblSalarioValeTransporte.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioValeTransporte.Location = new System.Drawing.Point(25, 67);
            this.lblSalarioValeTransporte.Name = "lblSalarioValeTransporte";
            this.lblSalarioValeTransporte.Size = new System.Drawing.Size(182, 20);
            this.lblSalarioValeTransporte.TabIndex = 1;
            this.lblSalarioValeTransporte.Text = "Informe seu salário";
            // 
            // txtSalarioValeTRansporte
            // 
            this.txtSalarioValeTRansporte.Location = new System.Drawing.Point(29, 90);
            this.txtSalarioValeTRansporte.Name = "txtSalarioValeTRansporte";
            this.txtSalarioValeTRansporte.Size = new System.Drawing.Size(177, 20);
            this.txtSalarioValeTRansporte.TabIndex = 2;
            // 
            // lblResultadoVAleTransporte
            // 
            this.lblResultadoVAleTransporte.AutoSize = true;
            this.lblResultadoVAleTransporte.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoVAleTransporte.Location = new System.Drawing.Point(25, 290);
            this.lblResultadoVAleTransporte.Name = "lblResultadoVAleTransporte";
            this.lblResultadoVAleTransporte.Size = new System.Drawing.Size(102, 20);
            this.lblResultadoVAleTransporte.TabIndex = 3;
            this.lblResultadoVAleTransporte.Text = "Resultado ";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculo.Image = global::iRh.Windows.Properties.Resources.icons8_parte_traseira_de_cartão_de_banco_100;
            this.btnCalculo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCalculo.Location = new System.Drawing.Point(29, 133);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(116, 69);
            this.btnCalculo.TabIndex = 4;
            this.btnCalculo.Text = "Calculo";
            this.btnCalculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalculo.UseVisualStyleBackColor = true;
            // 
            // frmBeneficioValeTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.lblResultadoVAleTransporte);
            this.Controls.Add(this.txtSalarioValeTRansporte);
            this.Controls.Add(this.lblSalarioValeTransporte);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeneficioValeTransporte";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBeneficioValeTransporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSalarioValeTransporte;
        private System.Windows.Forms.TextBox txtSalarioValeTRansporte;
        private System.Windows.Forms.Label lblResultadoVAleTransporte;
        private System.Windows.Forms.Button btnCalculo;
    }
}