namespace Evaluation_Management
{
    partial class RegisterForm
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
            label6 = new Label();
            panel1 = new Panel();
            lblRegisterClose = new Label();
            txtRegisterConfirmPass = new TextBox();
            label7 = new Label();
            lblLoginHere = new Label();
            label4 = new Label();
            CheckBoxRegisterShowPass = new CheckBox();
            btnSignUp = new Button();
            txtRegisterPass = new TextBox();
            label3 = new Label();
            txtRegisterUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblRegisterClose);
            panel1.Controls.Add(txtRegisterConfirmPass);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblLoginHere);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CheckBoxRegisterShowPass);
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(txtRegisterPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtRegisterUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 500);
            panel1.TabIndex = 1;
            // 
            // lblRegisterClose
            // 
            lblRegisterClose.AutoSize = true;
            lblRegisterClose.BackColor = Color.Transparent;
            lblRegisterClose.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegisterClose.Location = new Point(670, 9);
            lblRegisterClose.Name = "lblRegisterClose";
            lblRegisterClose.Size = new Size(20, 20);
            lblRegisterClose.TabIndex = 12;
            lblRegisterClose.Text = "X";
            lblRegisterClose.Click += lblRegisterClose_Click;
            // 
            // txtRegisterConfirmPass
            // 
            txtRegisterConfirmPass.Location = new Point(333, 267);
            txtRegisterConfirmPass.Multiline = true;
            txtRegisterConfirmPass.Name = "txtRegisterConfirmPass";
            txtRegisterConfirmPass.Size = new Size(355, 30);
            txtRegisterConfirmPass.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(333, 243);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 10;
            label7.Text = "Confirm password:";
            // 
            // lblLoginHere
            // 
            lblLoginHere.AutoSize = true;
            lblLoginHere.BackColor = Color.Transparent;
            lblLoginHere.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginHere.Location = new Point(555, 452);
            lblLoginHere.Name = "lblLoginHere";
            lblLoginHere.Size = new Size(73, 17);
            lblLoginHere.TabIndex = 9;
            lblLoginHere.Text = "Login here";
            lblLoginHere.Click += lblLoginHere_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(388, 452);
            label4.Name = "label4";
            label4.Size = new Size(161, 17);
            label4.TabIndex = 8;
            label4.Text = "Already have an account?";
            // 
            // CheckBoxRegisterShowPass
            // 
            CheckBoxRegisterShowPass.AutoSize = true;
            CheckBoxRegisterShowPass.BackColor = Color.Transparent;
            CheckBoxRegisterShowPass.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckBoxRegisterShowPass.Location = new Point(569, 331);
            CheckBoxRegisterShowPass.Name = "CheckBoxRegisterShowPass";
            CheckBoxRegisterShowPass.Size = new Size(121, 21);
            CheckBoxRegisterShowPass.TabIndex = 7;
            CheckBoxRegisterShowPass.Text = "Show password";
            CheckBoxRegisterShowPass.UseVisualStyleBackColor = false;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Silver;
            btnSignUp.FlatAppearance.BorderColor = Color.White;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = SystemColors.ActiveCaptionText;
            btnSignUp.Location = new Point(333, 357);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(99, 32);
            btnSignUp.TabIndex = 6;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // txtRegisterPass
            // 
            txtRegisterPass.Location = new Point(333, 210);
            txtRegisterPass.Multiline = true;
            txtRegisterPass.Name = "txtRegisterPass";
            txtRegisterPass.Size = new Size(355, 30);
            txtRegisterPass.TabIndex = 5;
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
            // txtRegisterUsername
            // 
            txtRegisterUsername.Location = new Point(333, 150);
            txtRegisterUsername.Multiline = true;
            txtRegisterUsername.Name = "txtRegisterUsername";
            txtRegisterUsername.Size = new Size(355, 30);
            txtRegisterUsername.TabIndex = 3;
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
            label1.Size = new Size(127, 26);
            label1.TabIndex = 1;
            label1.Text = "Get Started";
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
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 500);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Panel panel1;
        private Label lblLoginHere;
        private Label label4;
        private CheckBox CheckBoxRegisterShowPass;
        private Button btnSignUp;
        private TextBox txtRegisterPass;
        private Label label3;
        private TextBox txtRegisterUsername;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox txtRegisterConfirmPass;
        private Label label7;
        private Label lblRegisterClose;
    }
}