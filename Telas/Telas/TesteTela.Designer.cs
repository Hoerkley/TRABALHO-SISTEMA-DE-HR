namespace Telas
{
    partial class TesteTela
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
            components = new System.ComponentModel.Container();
            sadebarConteiner = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            menuButton = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            btnSettings = new Button();
            panel4 = new Panel();
            btnQuestions = new Button();
            panel5 = new Panel();
            btnInfo = new Button();
            sadebarTime = new System.Windows.Forms.Timer(components);
            sadebarConteiner.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // sadebarConteiner
            // 
            sadebarConteiner.BackColor = Color.FromArgb(0, 64, 64);
            sadebarConteiner.Controls.Add(panel1);
            sadebarConteiner.Controls.Add(panel2);
            sadebarConteiner.Controls.Add(panel3);
            sadebarConteiner.Controls.Add(panel4);
            sadebarConteiner.Controls.Add(panel5);
            sadebarConteiner.Dock = DockStyle.Left;
            sadebarConteiner.Location = new Point(0, 0);
            sadebarConteiner.MaximumSize = new Size(245, 550);
            sadebarConteiner.MinimumSize = new Size(53, 550);
            sadebarConteiner.Name = "sadebarConteiner";
            sadebarConteiner.Size = new Size(245, 550);
            sadebarConteiner.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 102);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(62, 39);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = Properties.Resources.icons8_menu_96;
            menuButton.Location = new Point(0, 29);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(42, 31);
            menuButton.SizeMode = PictureBoxSizeMode.Zoom;
            menuButton.TabIndex = 1;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 43);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = Properties.Resources.icons8_home_301;
            button1.ImageAlign = ContentAlignment.BottomLeft;
            button1.Location = new Point(2, 0);
            button1.Name = "button1";
            button1.Size = new Size(240, 36);
            button1.TabIndex = 2;
            button1.Text = "          Home";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSettings);
            panel3.Location = new Point(3, 160);
            panel3.Name = "panel3";
            panel3.Size = new Size(242, 43);
            panel3.TabIndex = 3;
            // 
            // btnSettings
            // 
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = SystemColors.ActiveCaptionText;
            btnSettings.Image = Properties.Resources.icons8_settings_30;
            btnSettings.ImageAlign = ContentAlignment.BottomLeft;
            btnSettings.Location = new Point(2, 0);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(240, 36);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "          Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnQuestions);
            panel4.Location = new Point(3, 209);
            panel4.Name = "panel4";
            panel4.Size = new Size(242, 43);
            panel4.TabIndex = 3;
            // 
            // btnQuestions
            // 
            btnQuestions.FlatStyle = FlatStyle.Flat;
            btnQuestions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuestions.ForeColor = SystemColors.ActiveCaptionText;
            btnQuestions.Image = Properties.Resources.icons8_questions_30;
            btnQuestions.ImageAlign = ContentAlignment.TopLeft;
            btnQuestions.Location = new Point(2, 0);
            btnQuestions.Name = "btnQuestions";
            btnQuestions.Size = new Size(240, 36);
            btnQuestions.TabIndex = 2;
            btnQuestions.Text = "          Questions";
            btnQuestions.TextAlign = ContentAlignment.MiddleLeft;
            btnQuestions.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnInfo);
            panel5.Location = new Point(3, 258);
            panel5.Name = "panel5";
            panel5.Size = new Size(242, 43);
            panel5.TabIndex = 3;
            // 
            // btnInfo
            // 
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInfo.ForeColor = SystemColors.ActiveCaptionText;
            btnInfo.Image = Properties.Resources.icons8_info_30;
            btnInfo.ImageAlign = ContentAlignment.BottomLeft;
            btnInfo.Location = new Point(2, 0);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(240, 36);
            btnInfo.TabIndex = 2;
            btnInfo.Text = "          About";
            btnInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // sadebarTime
            // 
            sadebarTime.Tick += sadebarTime_Tick;
            // 
            // TesteTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 550);
            Controls.Add(sadebarConteiner);
            ForeColor = SystemColors.ButtonFace;
            Name = "TesteTela";
            Text = "TesteTela";
            sadebarConteiner.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Button btnSettings;
        private Panel panel4;
        private Button btnQuestions;
        private Panel panel5;
        private Button btnInfo;
        private PictureBox menuButton;
        private Label label1;
        public FlowLayoutPanel sadebarConteiner;
        private System.Windows.Forms.Timer sadebarTime;
    }
}