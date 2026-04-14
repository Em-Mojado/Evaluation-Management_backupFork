namespace Evaluation_Management
{
    partial class Login_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblLoginClose = new Label();
            lblRegisterHere = new Label();
            label4 = new Label();
            CheckBoxLoginShowPass = new CheckBox();
            btnLogin = new Button();
            txtLoginPass = new TextBox();
            label3 = new Label();
            txtLoginUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblLoginClose);
            panel1.Controls.Add(lblRegisterHere);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CheckBoxLoginShowPass);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtLoginPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtLoginUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 500);
            panel1.TabIndex = 0;
            // 
            // lblLoginClose
            // 
            lblLoginClose.AutoSize = true;
            lblLoginClose.BackColor = Color.Transparent;
            lblLoginClose.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginClose.Location = new Point(668, 9);
            lblLoginClose.Name = "lblLoginClose";
            lblLoginClose.Size = new Size(20, 20);
            lblLoginClose.TabIndex = 10;
            lblLoginClose.Text = "X";
            lblLoginClose.Click += lblLoginClose_Click;
            // 
            // lblRegisterHere
            // 
            lblRegisterHere.AutoSize = true;
            lblRegisterHere.BackColor = Color.Transparent;
            lblRegisterHere.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegisterHere.Location = new Point(534, 452);
            lblRegisterHere.Name = "lblRegisterHere";
            lblRegisterHere.Size = new Size(89, 17);
            lblRegisterHere.TabIndex = 9;
            lblRegisterHere.Text = "Register here";
            lblRegisterHere.Click += lblRegisterHere_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(388, 452);
            label4.Name = "label4";
            label4.Size = new Size(146, 17);
            label4.TabIndex = 8;
            label4.Text = "Dont have an account?";
            // 
            // CheckBoxLoginShowPass
            // 
            CheckBoxLoginShowPass.AutoSize = true;
            CheckBoxLoginShowPass.BackColor = Color.Transparent;
            CheckBoxLoginShowPass.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckBoxLoginShowPass.Location = new Point(569, 258);
            CheckBoxLoginShowPass.Name = "CheckBoxLoginShowPass";
            CheckBoxLoginShowPass.Size = new Size(121, 21);
            CheckBoxLoginShowPass.TabIndex = 7;
            CheckBoxLoginShowPass.Text = "Show password";
            CheckBoxLoginShowPass.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Silver;
            btnLogin.FlatAppearance.BorderColor = Color.White;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(333, 284);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(99, 32);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtLoginPass
            // 
            txtLoginPass.Location = new Point(333, 210);
            txtLoginPass.Multiline = true;
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.Size = new Size(355, 30);
            txtLoginPass.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(333, 186);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Location = new Point(333, 150);
            txtLoginUsername.Multiline = true;
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(355, 30);
            txtLoginUsername.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(333, 126);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(452, 66);
            label1.Name = "label1";
            label1.Size = new Size(119, 26);
            label1.TabIndex = 1;
            label1.Text = "Welcome!";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 511);
            panel2.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(110, 200);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 0;
            label6.Text = "TITLE HERE";
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 500);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtLoginUsername;
        private Label label2;
        private Label label1;
        private CheckBox CheckBoxLoginShowPass;
        private Button btnLogin;
        private TextBox txtLoginPass;
        private Label label3;
        private Label label4;
        private Label lblRegisterHere;
        private Label label6;
        private Label lblLoginClose;
    }
}
