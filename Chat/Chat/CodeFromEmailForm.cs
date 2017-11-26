using System;

namespace Chat
{
    public partial class CodeFromEmailForm : MetroFramework.Forms.MetroForm
    {
        private String password;
        private String login;
      
        public CodeFromEmailForm()
        {
            InitializeComponent();
        }
         
        public CodeFromEmailForm(String login, String pass)
        {
            InitializeComponent();
            this.login = login;
            this.password = pass;

        }
        
        private void SubmitCodeButton_Click(object sender, EventArgs e)
        {
            if((!String.IsNullOrEmpty(this.EmailBox.Text) || !String.IsNullOrWhiteSpace(this.EmailBox.Text)) &&  this.password.Equals(this.EmailBox.Text))
            {
                ChangePasswordForm cpf = new ChangePasswordForm(this.login);
                this.Hide();
                cpf.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Wrong code", "Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void CodeFromEmailForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
