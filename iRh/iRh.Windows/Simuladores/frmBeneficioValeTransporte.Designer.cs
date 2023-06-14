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
            this.panelValeTransporte = new System.Windows.Forms.Panel();
            this.panelValeTransporte.SuspendLayout();
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
            this.txtSalarioValeTRansporte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalarioValeTRansporte_KeyDown);
            // 
            // lblResultadoVAleTransporte
            // 
            this.lblResultadoVAleTransporte.AutoSize = true;
            this.lblResultadoVAleTransporte.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoVAleTransporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblResultadoVAleTransporte.Location = new System.Drawing.Point(31, 28);
            this.lblResultadoVAleTransporte.Name = "lblResultadoVAleTransporte";
            this.lblResultadoVAleTransporte.Size = new System.Drawing.Size(130, 25);
            this.lblResultadoVAleTransporte.TabIndex = 3;
            this.lblResultadoVAleTransporte.Text = "Resultado ";
            // 
            // btnCalculo
            // 
            this.btnCalculo.BackgroundImage = global::iRh.Windows.Properties.Resources.calculator_android_system_blue_smartphone_icon_252259;
            this.btnCalculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculo.Location = new System.Drawing.Point(29, 129);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(126, 73);
            this.btnCalculo.TabIndex = 4;
            this.btnCalculo.Text = "Calculo";
            this.btnCalculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // panelValeTransporte
            // 
            this.panelValeTransporte.Controls.Add(this.lblResultadoVAleTransporte);
            this.panelValeTransporte.Location = new System.Drawing.Point(6, 338);
            this.panelValeTransporte.Name = "panelValeTransporte";
            this.panelValeTransporte.Size = new System.Drawing.Size(227, 100);
            this.panelValeTransporte.TabIndex = 5;
            this.panelValeTransporte.Visible = false;
            // 
            // frmBeneficioValeTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.bus_icon_icons_com_76529;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelValeTransporte);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.txtSalarioValeTRansporte);
            this.Controls.Add(this.lblSalarioValeTransporte);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBeneficioValeTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBeneficioValeTransporte";
            this.panelValeTransporte.ResumeLayout(false);
            this.panelValeTransporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSalarioValeTransporte;
        private System.Windows.Forms.TextBox txtSalarioValeTRansporte;
        private System.Windows.Forms.Label lblResultadoVAleTransporte;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Panel panelValeTransporte;
    }
}