namespace iRh.Windows.Simuladores
{
    partial class frmDescontoIrpf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescontoIrpf));
            this.lblSalarioIrrf = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalarioIrrf = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSeuDescontoEstáAbaixo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioIrrf
            // 
            this.lblSalarioIrrf.AutoSize = true;
            this.lblSalarioIrrf.BackColor = System.Drawing.Color.Transparent;
            this.lblSalarioIrrf.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioIrrf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSalarioIrrf.Location = new System.Drawing.Point(12, 9);
            this.lblSalarioIrrf.Name = "lblSalarioIrrf";
            this.lblSalarioIrrf.Size = new System.Drawing.Size(371, 37);
            this.lblSalarioIrrf.TabIndex = 0;
            this.lblSalarioIrrf.Text = "Informe seu salário abaixo  ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.BackgroundImage = global::iRh.Windows.Properties.Resources.calculator_android_system_blue_smartphone_icon_252259;
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcular.Location = new System.Drawing.Point(12, 119);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(164, 86);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalarioIrrf
            // 
            this.txtSalarioIrrf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioIrrf.Location = new System.Drawing.Point(19, 61);
            this.txtSalarioIrrf.Name = "txtSalarioIrrf";
            this.txtSalarioIrrf.Size = new System.Drawing.Size(136, 29);
            this.txtSalarioIrrf.TabIndex = 2;
            this.txtSalarioIrrf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalarioIrrf_KeyDown);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Black;
            this.lblResultado.Location = new System.Drawing.Point(3, 30);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(110, 30);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblSeuDescontoEstáAbaixo);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Location = new System.Drawing.Point(12, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 72);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // lblSeuDescontoEstáAbaixo
            // 
            this.lblSeuDescontoEstáAbaixo.AutoSize = true;
            this.lblSeuDescontoEstáAbaixo.BackColor = System.Drawing.Color.Transparent;
            this.lblSeuDescontoEstáAbaixo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeuDescontoEstáAbaixo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSeuDescontoEstáAbaixo.Location = new System.Drawing.Point(3, 0);
            this.lblSeuDescontoEstáAbaixo.Name = "lblSeuDescontoEstáAbaixo";
            this.lblSeuDescontoEstáAbaixo.Size = new System.Drawing.Size(317, 30);
            this.lblSeuDescontoEstáAbaixo.TabIndex = 5;
            this.lblSeuDescontoEstáAbaixo.Text = "Seu desconto aparecera abaixo";
            // 
            // frmDescontoIrpf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSalarioIrrf);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSalarioIrrf);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDescontoIrpf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDescontoIrpf";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioIrrf;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalarioIrrf;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSeuDescontoEstáAbaixo;
    }
}