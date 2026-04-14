namespace Evaluation_Management
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void lblLoginHere_Click(object sender, EventArgs e)
        {
            Login_Form Form = new Login_Form();
            Form.Show();
            this.Hide();
        }

        private void lblRegisterClose_Click(object sender, EventArgs e)
        {
Application.Exit();
        }
    }
}
