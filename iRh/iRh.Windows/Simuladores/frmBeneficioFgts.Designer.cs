namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioFgts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficioFgts));
            this.txtSalarioFgts = new System.Windows.Forms.TextBox();
            this.btnCalcularFgts = new System.Windows.Forms.Button();
            this.panelResultadoFgts = new System.Windows.Forms.Panel();
            this.lblOValorDoSeuFgts = new System.Windows.Forms.Label();
            this.lblResultadoFgts = new System.Windows.Forms.Label();
            this.lblSalarioFsgts = new System.Windows.Forms.Label();
            this.panelResultadoFgts.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSalarioFgts
            // 
            this.txtSalarioFgts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioFgts.Location = new System.Drawing.Point(19, 66);
            this.txtSalarioFgts.Name = "txtSalarioFgts";
            this.txtSalarioFgts.Size = new System.Drawing.Size(206, 25);
            this.txtSalarioFgts.TabIndex = 1;
            this.txtSalarioFgts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalarioFgts_KeyDown);
            // 
            // btnCalcularFgts
            // 
            this.btnCalcularFgts.BackgroundImage = global::iRh.Windows.Properties.Resources.calculate_FILL0_wght400_GRAD0_opsz48;
            this.btnCalcularFgts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalcularFgts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularFgts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularFgts.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularFgts.ForeColor = System.Drawing.Color.White;
            this.btnCalcularFgts.Location = new System.Drawing.Point(19, 107);
            this.btnCalcularFgts.Name = "btnCalcularFgts";
            this.btnCalcularFgts.Size = new System.Drawing.Size(147, 64);
            this.btnCalcularFgts.TabIndex = 2;
            this.btnCalcularFgts.Text = "Calacular";
            this.btnCalcularFgts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcularFgts.UseVisualStyleBackColor = true;
            this.btnCalcularFgts.Click += new System.EventHandler(this.btnCalcularFgts_Click);
            // 
            // panelResultadoFgts
            // 
            this.panelResultadoFgts.Controls.Add(this.lblOValorDoSeuFgts);
            this.panelResultadoFgts.Controls.Add(this.lblResultadoFgts);
            this.panelResultadoFgts.Location = new System.Drawing.Point(3, 338);
            this.panelResultadoFgts.Name = "panelResultadoFgts";
            this.panelResultadoFgts.Size = new System.Drawing.Size(358, 100);
            this.panelResultadoFgts.TabIndex = 3;
            this.panelResultadoFgts.Visible = false;
            // 
            // lblOValorDoSeuFgts
            // 
            this.lblOValorDoSeuFgts.AutoSize = true;
            this.lblOValorDoSeuFgts.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOValorDoSeuFgts.ForeColor = System.Drawing.Color.White;
            this.lblOValorDoSeuFgts.Location = new System.Drawing.Point(3, 13);
            this.lblOValorDoSeuFgts.Name = "lblOValorDoSeuFgts";
            this.lblOValorDoSeuFgts.Size = new System.Drawing.Size(228, 30);
            this.lblOValorDoSeuFgts.TabIndex = 5;
            this.lblOValorDoSeuFgts.Text = "O valor do seu FGTS é";
            // 
            // lblResultadoFgts
            // 
            this.lblResultadoFgts.AutoSize = true;
            this.lblResultadoFgts.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoFgts.ForeColor = System.Drawing.Color.White;
            this.lblResultadoFgts.Location = new System.Drawing.Point(3, 43);
            this.lblResultadoFgts.Name = "lblResultadoFgts";
            this.lblResultadoFgts.Size = new System.Drawing.Size(110, 30);
            this.lblResultadoFgts.TabIndex = 4;
            this.lblResultadoFgts.Text = "Resultado";
            // 
            // lblSalarioFsgts
            // 
            this.lblSalarioFsgts.AutoSize = true;
            this.lblSalarioFsgts.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFsgts.ForeColor = System.Drawing.Color.White;
            this.lblSalarioFsgts.Location = new System.Drawing.Point(12, 9);
            this.lblSalarioFsgts.Name = "lblSalarioFsgts";
            this.lblSalarioFsgts.Size = new System.Drawing.Size(489, 37);
            this.lblSalarioFsgts.TabIndex = 0;
            this.lblSalarioFsgts.Text = "Por favor informe abaixo seu salário ";
            // 
            // frmBeneficioFgts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::iRh.Windows.Properties.Resources.FGTS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelResultadoFgts);
            this.Controls.Add(this.btnCalcularFgts);
            this.Controls.Add(this.txtSalarioFgts);
            this.Controls.Add(this.lblSalarioFsgts);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBeneficioFgts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBeneficioFgts";
            this.panelResultadoFgts.ResumeLayout(false);
            this.panelResultadoFgts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSalarioFgts;
        private System.Windows.Forms.Button btnCalcularFgts;
        private System.Windows.Forms.Panel panelResultadoFgts;
        private System.Windows.Forms.Label lblResultadoFgts;
        private System.Windows.Forms.Label lblSalarioFsgts;
        private System.Windows.Forms.Label lblOValorDoSeuFgts;
    }
}