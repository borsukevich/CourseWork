using System;
namespace Chat
{
    public partial class ChangePasswordForm : MetroFramework.Forms.MetroForm
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void changeButton_Click(object sender, System.EventArgs e)
        {
            if(this.passwordTextBox.Text.Equals(this.repeatTextBox.Text) && (!String.IsNullOrEmpty(this.passwordTextBox.Text) || !String.IsNullOrWhiteSpace(this.passwordTextBox.Text)))
            {
                SignInForm sif = new SignInForm();
                this.Hide();
                sif.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Passwords are different", "Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
