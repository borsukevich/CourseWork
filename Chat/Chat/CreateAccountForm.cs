using System;
using System.Windows.Forms;

namespace Chat
{
    public partial class CreateAccountForm : MetroFramework.Forms.MetroForm
    {
        private System.Drawing.Bitmap agreePicturePath = new System.Drawing.Bitmap(@"D:\CourseWork\Pictures\agree.png");
        private System.Drawing.Bitmap disagreePicturePath = new System.Drawing.Bitmap(@"D:\CourseWork\Pictures\disagree.png");
        private SignInForm signInForm = new SignInForm();
        //private UserLogic user;

        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SignInForm sif = new SignInForm();
            this.Hide();
            sif.Show();
        }

        private void NameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (this.NameTextBox.Text.Length < 3)
            {
                this.NamePictureBox.Image = this.disagreePicturePath;
            }
            else
            {
                this.NamePictureBox.Image = null;
                this.NamePictureBox.Image = this.agreePicturePath;
            }
        }

        private void SurnameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (this.SurnameTextBox.Text.Length < 3)
            {
                this.SurnamePictureBox.Image = this.disagreePicturePath;
            }
            else
            {
                this.SurnamePictureBox.Image = null;
                this.SurnamePictureBox.Image = this.agreePicturePath;
            }
        }

        private void LoginTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (this.LoginTextBox.Text.Length < 3 || this.LoginTextBox.Text == System.String.Empty)
            {
                this.LoginPictureBox.Image = this.disagreePicturePath;
            }
            else
            {
                this.LoginPictureBox.Image = null;
                this.LoginPictureBox.Image = this.agreePicturePath;
            }
        }

        private void PasswordTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (this.PasswordTextBox.Text.Length < 3)
            {
                this.PasswordPictureBox.Image = this.disagreePicturePath;
            }
            else
            {
                this.PasswordPictureBox.Image = null;
                this.PasswordPictureBox.Image = this.agreePicturePath;
            }
        }

        private void RepeatPasswordTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (this.RepeatPasswordTextBox.Text.Length < 3)
            {
                this.RepeatPasswordPictureBox.Image = this.disagreePicturePath;
            }
            else
            {
                this.RepeatPasswordPictureBox.Image = null;
                this.RepeatPasswordPictureBox.Image = this.agreePicturePath;
            }
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            this.Close();
            signInForm.Show();
        }
    }
}
