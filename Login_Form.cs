namespace Evaluation_Management
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void lblRegisterHere_Click(object sender, EventArgs e)
        {
            RegisterForm Form = new RegisterForm();
            Form.Show();
            this.Hide();
        }

        private void lblLoginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
