using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Chat
{
    partial class MainChatForm : MetroFramework.Forms.MetroForm
    {
        private UserLogic user;
        private MySqlConnectionStringBuilder connectStr;
        private MySqlConnection connection;
        private String baseInfo;

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

        private async Task<String> ReadFromDataBaseAsync()
        {
            MySqlCommand command = this.connection.CreateCommand();
            command.CommandText = $"SELECT * FROM Message";
            MySqlDataReader reader = null;
            reader =  (MySqlDataReader)command.ExecuteReaderAsync().Result;
            String result = String.Empty;

            try
            {
                while (await reader.ReadAsync())
                {
                    result += reader["message"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
            }
            return result;
        }

        private void sendMessagePictureBox_MouseEnter(object sender, EventArgs e)
        {
            this.sendMessagePictureBox.Cursor = Cursors.Hand;
            this.sendMessagePictureBox.BackColor = System.Drawing.Color.Gray;
        }

        private void userInfoPictureBox_Click(object sender, EventArgs e)
        {
            PersonalInformationForm pif = new PersonalInformationForm(user);
            pif.ShowDialog();
        }

        private async void sendMessagePictureBox_Click(object sender, EventArgs e)
        {
            if (!(System.String.IsNullOrEmpty(this.messageTextBox.Text) || String.IsNullOrWhiteSpace(this.messageTextBox.Text)))
            {
                String message = this.user.Name + " -> " + this.messageTextBox.Text + Environment.NewLine;
                this.showMessageTextBox.Text += message;
                MySqlCommand command = this.connection.CreateCommand();
                command.CommandText = $"INSERT INTO Message(message) VALUES('{message}')";
                await command.ExecuteNonQueryAsync();
                this.messageTextBox.Text = System.String.Empty;
            }
        }

        private void sendMessagePictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.sendMessagePictureBox.BackColor = System.Drawing.Color.Transparent;
        }

        private void userInfoPictureBox_MouseEnter(object sender, EventArgs e)
        {
            this.userInfoPictureBox.Cursor = Cursors.Hand;
        }

        private async void MainChatForm_Load(object sender, EventArgs e)
        {
            await this.connection.OpenAsync();
        }

        private void MainChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.connection.State != System.Data.ConnectionState.Closed || this.connection != null)
            {
                this.connection.Close();
                Application.Exit();
            }
        }

        private void showMessageTextBox_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private async void MainChatForm_Activated(object sender, EventArgs e)
        {
            this.baseInfo = await this.ReadFromDataBaseAsync();
            this.showMessageTextBox.Text = this.baseInfo;
            this.showMessageTextBox.Update();
            System.Threading.Thread.Sleep(100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           this.MainChatForm_Activated(sender, e);
        }
    }
}