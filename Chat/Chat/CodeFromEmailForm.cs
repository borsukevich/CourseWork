using System;

namespace Chat
{
    public partial class CodeFromEmailForm : MetroFramework.Forms.MetroForm
    {
        private String password;

        public CodeFromEmailForm()
        {
            InitializeComponent();
        }
         
        public CodeFromEmailForm(String pass)
        {
            InitializeComponent();
            this.password = pass;
        }
        
        private void SubmitCodeButton_Click(object sender, EventArgs e)
        {
            if((!String.IsNullOrEmpty(this.EmailBox.Text) || !String.IsNullOrWhiteSpace(this.EmailBox.Text)) &&  this.password.Equals(this.EmailBox.Text))
            {
                ChangePasswordForm cpf = new ChangePasswordForm();
                this.Hide();
                cpf.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Wrong code", "Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
