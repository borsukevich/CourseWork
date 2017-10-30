using System;
namespace Chat
{
    public partial class ChangePasswordForm : MetroFramework.Forms.MetroForm
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if(this.repeatTextBox.Text.Equals(this.passwordTextBox.Text) && (!String.IsNullOrEmpty(this.repeatTextBox.Text) || !String.IsNullOrWhiteSpace(this.repeatTextBox.Text)))
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