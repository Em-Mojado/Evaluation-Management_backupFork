namespace Evaluation_Management
{
    partial class AdminPage
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
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tpHome = new TabPage();
            tpSubmitReport = new TabPage();
            panel1 = new Panel();
            panel2 = new Panel();
            tpHistory = new TabPage();
            materialTabControl1.SuspendLayout();
            tpSubmitReport.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tpHome);
            materialTabControl1.Controls.Add(tpSubmitReport);
            materialTabControl1.Controls.Add(tpHistory);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Location = new Point(0, 24);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(866, 527);
            materialTabControl1.TabIndex = 0;
            // 
            // tpHome
            // 
            tpHome.AccessibleDescription = "";
            tpHome.AccessibleName = "";
            tpHome.BackColor = Color.Transparent;
            tpHome.Location = new Point(4, 24);
            tpHome.Name = "tpHome";
            tpHome.Padding = new Padding(3);
            tpHome.Size = new Size(858, 499);
            tpHome.TabIndex = 0;
            tpHome.Text = "Home";
            // 
            // tpSubmitReport
            // 
            tpSubmitReport.Controls.Add(panel1);
            tpSubmitReport.Location = new Point(4, 24);
            tpSubmitReport.Name = "tpSubmitReport";
            tpSubmitReport.Padding = new Padding(3);
            tpSubmitReport.Size = new Size(858, 499);
            tpSubmitReport.TabIndex = 1;
            tpSubmitReport.Text = "Sumbit";
            tpSubmitReport.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 493);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(42, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 424);
            panel2.TabIndex = 0;
            // 
            // tpHistory
            // 
            tpHistory.Location = new Point(4, 24);
            tpHistory.Name = "tpHistory";
            tpHistory.Size = new Size(858, 499);
            tpHistory.TabIndex = 2;
            tpHistory.Text = "History";
            tpHistory.UseVisualStyleBackColor = true;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 554);
            Controls.Add(materialTabControl1);
            DrawerAutoShow = true;
            DrawerIsOpen = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            FormStyle = FormStyles.ActionBar_None;
            Name = "AdminPage";
            Padding = new Padding(0, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome!";
            materialTabControl1.ResumeLayout(false);
            tpSubmitReport.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tpHome;
        private TabPage tpSubmitReport;
        private TabPage tpHistory;
        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}