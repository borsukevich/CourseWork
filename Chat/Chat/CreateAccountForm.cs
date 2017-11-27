using System;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Chat
{
    public partial class CreateAccountForm : MetroFramework.Forms.MetroForm
    {
        private System.Drawing.Bitmap agreePicturePath = new System.Drawing.Bitmap(@"..\..\Resources\agree.png");
        private System.Drawing.Bitmap disagreePicturePath = new System.Drawing.Bitmap(@"..\..\Resources\disagree.png");
        private SignInForm signInForm = new SignInForm();   
        private UserLogic user;
        private MySqlConnectionStringBuilder connectStr;
        private MySqlConnection connection;

        public CreateAccountForm()
        {
            InitializeComponent();
            this.connectStr = new MySqlConnectionStringBuilder()
            {
                Server = "sql11.freesqldatabase.com",
                UserID = "sql11207497",
                Password = "2HiZXJPPNj",
                Database = "sql11207497"
            };
            this.connection = new MySqlConnection(this.connectStr.ToString());
        }
        
        public static String MD5Hash(String text)
        {
            System.Text.StringBuilder hash = new System.Text.StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new System.Text.UTF8Encoding().GetBytes(text));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
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

        private async void CreateAccountButton_Click(object sender, EventArgs e)
        {
            System.String birthday = System.String.Empty;
            if (this.userDayBirth.SelectedIndex != -1 && this.userMonthBirth.SelectedIndex != -1 && this.userYearBirth.SelectedIndex != -1)
            {
                birthday = $"{this.userYearBirth.SelectedIndex + 1975}-{this.userMonthBirth.SelectedIndex + 1}-{this.userDayBirth.SelectedIndex + 1}";
            }
            String salt = ForgotPasswordForm.GeneratePassword();
            String hashPassword = MD5Hash(this.PasswordTextBox.Text + salt);
            this.user = new UserLogic(this.LoginTextBox.Text, hashPassword, this.NameTextBox.Text, this.SurnameTextBox.Text, birthday, salt, DateTime.Now.ToString("s"));
            
            MySqlCommand command = this.connection.CreateCommand();
            command.CommandText = $"INSERT INTO User(login,password,name,surname,birthday,salt,registry) VALUES('{this.user.Login}', '{this.user.Password}', '{this.user.Name}', '{this.user.Surname}', '{this.user.Birthday}',' {this.user.Salt}', '{this.user.Registry}')";
            await command.ExecuteNonQueryAsync();
            this.Close();
            signInForm.Show();
        }

        private async void CreateAccountForm_Load(object sender, EventArgs e)
        {
            await this.connection.OpenAsync();
        }

        private void CreateAccountForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (this.connection != null && this.connection.State != System.Data.ConnectionState.Closed)
            {
                this.connection.Close();
            }
        }
    }
}