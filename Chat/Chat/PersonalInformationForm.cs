using MySql.Data.MySqlClient;

namespace Chat
{
    partial class PersonalInformationForm : MetroFramework.Forms.MetroForm
    {
        private UserLogic user;
        //private MySqlConnectionStringBuilder connectStr;
        //private MySqlConnection connection;

        public PersonalInformationForm()
        {
            InitializeComponent();            
        }

        public PersonalInformationForm(UserLogic user)
        {
            InitializeComponent();

            //this.connectStr = new MySqlConnectionStringBuilder()
            //{
            //    Server = "sql11.freesqldatabase.com",
            //    UserID = "sql11207497",
            //    Password = "2HiZXJPPNj",
            //    Database = "sql11207497"
            //};
            //this.connection = new MySqlConnection(this.connectStr.ToString());

            this.user = user;
            this.metroTextBox1.Text = this.user.Name;
            this.metroTextBox2.Text = this.user.Surname;
            this.metroTextBox3.Text = this.user.Birthday;
            this.metroTextBox4.Text = this.user.Login;
            this.metroTextBox5.Text = this.user.Registry.Replace('T',' ');
        }

        private void metroTextBox1_Enter(object sender, System.EventArgs e)
        {
            this.ActiveControl = null;
        }

        private /*async*/ void deleteButton_Click(object sender, System.EventArgs e)
        {
            //MySqlCommand command = this.connection.CreateCommand();
            //command.CommandText = $"DELETE FROM User WHERE login='{this.user.Login}'";
            //await command.ExecuteNonQueryAsync();
            //new SignInForm().Show();
            
        }

        private async void PersonalInformationForm_Load(object sender, System.EventArgs e)
        {
           // await this.connection.OpenAsync();
        }

        private void PersonalInformationForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            //if(this.connection.State != System.Data.ConnectionState.Closed || this.connection != null)
            //{
            //    this.connection.Close();
            //    System.Windows.Forms.Application.Exit();
            //}
        }
    }
}