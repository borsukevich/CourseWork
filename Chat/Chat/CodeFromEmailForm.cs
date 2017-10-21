using System;
using System.Windows.Forms;

namespace Chat
{
    public partial class CodeFromEmailForm : MetroFramework.Forms.MetroForm
    {
        public CodeFromEmailForm()
        {
            InitializeComponent();
        }

        private void SubmitCodeButton_Click(object sender, EventArgs e)
        {
            SignInForm sif = new SignInForm();
            this.Hide();
            sif.Show();
        }
    }
}
