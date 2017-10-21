using System;

namespace Chat
{
    public partial class SignInForm : MetroFramework.Forms.MetroForm
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void ForgotPasswordLabel_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgot = new ForgotPasswordForm();
            this.Hide();
            forgot.Show();
        }

        private void CreateAccountLabel_Click(object sender, EventArgs e)
        {
            CreateAccountForm userInputForm = new CreateAccountForm();
            this.Hide();
            userInputForm.Show();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            MainChatForm mcf = new MainChatForm();
            this.Hide();
            mcf.Show();
        }
    }
}
