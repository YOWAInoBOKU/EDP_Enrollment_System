namespace EDP_Enrollment_System
{
    partial class frmMain
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
            panel4 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            panel3 = new Panel();
            panel7 = new Panel();
            CurrentStudentNo = new Label();
            label4 = new Label();
            panel9 = new Panel();
            MainPanel = new Panel();
            btnNext = new Button();
            btnPrevious = new Button();
            panel8 = new Panel();
            RegisterBtn = new Button();
            button2 = new Button();
            panel10 = new Panel();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.SkyBlue;
            panel4.Location = new Point(2, -7);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(36, 156);
            panel4.TabIndex = 94;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Location = new Point(1086, -9);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 684);
            panel2.TabIndex = 93;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(16, -9);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1188, 92);
            panel1.TabIndex = 92;
            // 
            // panel6
            // 
            panel6.Controls.Add(label1);
            panel6.Location = new Point(43, 17);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(420, 55);
            panel6.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Castellar", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Honeydew;
            label1.Location = new Point(-10, -3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(431, 58);
            label1.TabIndex = 35;
            label1.Text = "Registration";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.HotTrack;
            panel5.Location = new Point(-10, 46);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1086, 39);
            panel5.TabIndex = 63;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Controls.Add(panel7);
            panel3.Location = new Point(56, 88);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(378, 61);
            panel3.TabIndex = 91;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonHighlight;
            panel7.Controls.Add(CurrentStudentNo);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(panel9);
            panel7.Location = new Point(4, 3);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(368, 56);
            panel7.TabIndex = 0;
            // 
            // CurrentStudentNo
            // 
            CurrentStudentNo.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentStudentNo.Location = new Point(158, 7);
            CurrentStudentNo.Margin = new Padding(4, 0, 4, 0);
            CurrentStudentNo.Name = "CurrentStudentNo";
            CurrentStudentNo.Size = new Size(204, 40);
            CurrentStudentNo.TabIndex = 63;
            CurrentStudentNo.Text = "00000000000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Felix Titling", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(4, 16);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 23);
            label4.TabIndex = 36;
            label4.Text = "Student No.";
            // 
            // panel9
            // 
            panel9.BackColor = Color.SteelBlue;
            panel9.Location = new Point(8, 14);
            panel9.Name = "panel9";
            panel9.Size = new Size(145, 26);
            panel9.TabIndex = 64;
            // 
            // MainPanel
            // 
            MainPanel.Location = new Point(56, 162);
            MainPanel.Margin = new Padding(4, 3, 4, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1024, 411);
            MainPanel.TabIndex = 95;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(202, 34);
            btnNext.Margin = new Padding(4, 3, 4, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(186, 35);
            btnNext.TabIndex = 96;
            btnNext.Text = "Next>>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.Location = new Point(11, 34);
            btnPrevious.Margin = new Padding(4, 3, 4, 3);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(186, 35);
            btnPrevious.TabIndex = 97;
            btnPrevious.Text = "<<Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += Previous_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.SkyBlue;
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(btnPrevious);
            panel8.Controls.Add(button2);
            panel8.Controls.Add(btnNext);
            panel8.Location = new Point(621, 579);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(649, 96);
            panel8.TabIndex = 99;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Font = new Font("Castellar", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterBtn.Location = new Point(11, 2);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(216, 58);
            RegisterBtn.TabIndex = 99;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Turquoise;
            button2.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(16, 585);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(153, 80);
            button2.TabIndex = 98;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.SteelBlue;
            panel10.Controls.Add(RegisterBtn);
            panel10.Location = new Point(395, 14);
            panel10.Name = "panel10";
            panel10.Size = new Size(239, 63);
            panel10.TabIndex = 0;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 667);
            Controls.Add(panel8);
            Controls.Add(MainPanel);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel2;
        private Panel panel1;
        private Panel panel6;
        private Label label1;
        private Panel panel5;
        private Panel panel3;
        private Panel panel7;
        private Label CurrentStudentNo;
        private Label label4;
        private Panel MainPanel;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnRegister;
        private Panel panel8;
        private Button button2;
        private Panel panel9;
        private Button RegisterBtn;
        private Panel panel10;
    }
}