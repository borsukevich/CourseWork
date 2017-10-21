using System;
using System.Windows.Forms;

namespace Chat
{
    public partial class ForgotPasswordForm : MetroFramework.Forms.MetroForm
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SignInForm reg = new SignInForm();
            this.Close();
            reg.Show();
        }

        private void SendCodeButton_Click(object sender, EventArgs e)
        {
            CodeFromEmailForm pfm = new CodeFromEmailForm();
            this.Close();
            pfm.Show();
        }
    }
}
