using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Chat
{
    partial class MainChatForm : MetroFramework.Forms.MetroForm
    {
        private UserLogic user;
        private MySqlConnectionStringBuilder connectStr;
        private MySqlConnection connection;

        public MainChatForm()
        {
            InitializeComponent();
        }

        public MainChatForm(UserLogic user)
        {
            InitializeComponent();

            this.connectStr = new MySqlConnectionStringBuilder()
            {
                Server = "sql11.freesqldatabase.com",
                UserID = "sql11206175",
                Password = "2jLNEpmQd5",
                Database = "sql11206175"
            };
            this.connection = new MySqlConnection(this.connectStr.ToString());

            this.user = user;
            this.userName.Text = this.user.Name;
            this.userSurname.Text = this.user.Surname;
        }
 
        private async void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                InitialDirectory = @"C:\Users\Work\Pictures\Saved Pictures",
                Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png"
            };
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try 
                {
                     this.user.PicturePath = System.IO.Path.GetFullPath(dialog.FileName);
                     MySqlCommand command = this.connection.CreateCommand();
                     command.CommandText = $"UPDATE User SET image='{this.user.PicturePath}' WHERE login='{this.user.Login}';";
                     this.userPhoto.Image = new System.Drawing.Bitmap(this.user.PicturePath);
                     this.userPhoto.SizeMode = PictureBoxSizeMode.Zoom;                        

                    await command.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void MainChatForm_Load(object sender, EventArgs e)
        {
            await this.connection.OpenAsync();
        }

        private void MainChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.connection != null && this.connection.State != System.Data.ConnectionState.Closed)
            {
                this.connection.Close();
            }
        }
    }
}
