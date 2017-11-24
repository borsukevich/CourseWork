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
            this.showMessageTextBox.Enabled = false;
        }
        
        private void sendMessagePictureBox_MouseEnter(object sender, System.EventArgs e)
        {
            this.sendMessagePictureBox.Cursor = Cursors.Hand;
            this.sendMessagePictureBox.BackColor = System.Drawing.Color.Gray;
        }

        private void userInfoPictureBox_Click(object sender, System.EventArgs e)
        {
            System.String info = System.String.Format("Name: {0} {1}Surname: {2} {1}Birthday: {3} {1}E-mail: {4}{1}Registry: {5}{1}",this.user.Name,System.Environment.NewLine,this.user.Surname,this.user.Birthday,this.user.Login, this.user.Registry.Replace('T', ' '));
            MessageBox.Show(info,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private async void sendMessagePictureBox_Click(object sender, System.EventArgs e)
        {
            if (!(System.String.IsNullOrEmpty(this.messageTextBox.Text) || System.String.IsNullOrWhiteSpace(this.messageTextBox.Text)))
            {
                System.String message = this.user.Name + "-> " + this.messageTextBox.Text + System.Environment.NewLine;
                this.showMessageTextBox.Text += message;
                MySqlCommand command = this.connection.CreateCommand();
                command.CommandText = $"INSERT INTO Message(message) VALUES('{message}')";
                await command.ExecuteNonQueryAsync();
                this.messageTextBox.Text = System.String.Empty;
            }
        }

        private void sendMessagePictureBox_MouseLeave(object sender, System.EventArgs e)
        {
            this.sendMessagePictureBox.BackColor = System.Drawing.Color.Transparent;
        }

        private void userInfoPictureBox_MouseEnter(object sender, System.EventArgs e)
        {
            this.userInfoPictureBox.Cursor = Cursors.Hand;
        }

        private async void MainChatForm_Load(object sender, System.EventArgs e)
        {
            await this.connection.OpenAsync();
        }

        private void MainChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.connection.State != System.Data.ConnectionState.Closed)
            {
                this.connection.Close();
            }
        }
    }
}