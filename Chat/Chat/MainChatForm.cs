using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Chat
{
    partial class MainChatForm : MetroFramework.Forms.MetroForm
    {
        private UserLogic user;
        private SqlConnection connection;

        public MainChatForm()
        {
            InitializeComponent();
        }

        public MainChatForm(UserLogic user)
        {
            InitializeComponent();
            this.user = user;
            this.userName.Text = this.user.Name;
            this.userSurname.Text = this.user.Surname;
            //Task.Factory.StartNew(() =>
            //{
            //    SqlDataReader sqlReader = null;
            //    SqlCommand command = new SqlCommand(@"SELECT Image FROM userData WHERE Login='" + this.user.Login + @"'", this.connection);
            //    try
            //    {
            //        sqlReader = command.ExecuteReaderAsync().Result;
            //        while (sqlReader.ReadAsync().Result)
            //        {
            //                this.user.PicturePath = sqlReader["Image"].ToString();
                           
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    finally
            //    {
            //        if (sqlReader != null)
            //        {
            //            sqlReader.Close();
            //        }
            //    }
            //});
            //this.userPhoto.Image = new System.Drawing.Bitmap(this.user.PicturePath ?? @"C:\Users\Work\Pictures\Saved Pictures\background.png");
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
                    SqlCommand command = new SqlCommand("UPDATE [userData] SET [Image]=@Image WHERE Login='" + this.user.Login + @"'", this.connection);
                    command.Parameters.AddWithValue("Image", this.user.PicturePath);
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
            this.connection = new SqlConnection(@"Data Source=desktop-v0dibpt;Initial Catalog=courseWorkDB;User id=sa;Password=123456;");
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
