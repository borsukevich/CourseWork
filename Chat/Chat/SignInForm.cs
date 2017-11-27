using System;
using MySql.Data.MySqlClient;

namespace Chat
{
    public partial class SignInForm : MetroFramework.Forms.MetroForm
    {
        private MySqlConnectionStringBuilder connectStr;
        private MySqlConnection connection;

        public SignInForm()
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

        private async void SignInButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.LoginBox.Text) && !String.IsNullOrWhiteSpace(this.LoginBox.Text) && !String.IsNullOrWhiteSpace(this.PasswordBox.Text) && !String.IsNullOrEmpty(this.PasswordBox.Text))
            {
                MySqlCommand command = this.connection.CreateCommand();
                command.CommandText = @"SELECT * FROM User WHERE login = '" + this.LoginBox.Text + @"'";
                System.Data.Common.DbDataReader dataReader = null;
                dataReader = command.ExecuteReaderAsync().Result;
                UserLogic user = null;

                try
                {
                    while (await dataReader.ReadAsync())
                    {
                        String hash = CreateAccountForm.MD5Hash(this.PasswordBox.Text + dataReader["salt"].ToString().Substring(1));
                        if (hash.Equals(dataReader["password"].ToString()))
                        {
                            String login = dataReader["login"].ToString();
                            String password = dataReader["password"].ToString();
                            String name = dataReader["name"].ToString();
                            String surname = dataReader["surname"].ToString();
                            String birthday = dataReader["birthday"].ToString();
                            String salt = dataReader["salt"].ToString();
                            String registry = dataReader["registry"].ToString();
                            user = new UserLogic(login, password, name, surname, birthday, salt, registry);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, ex.Source, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                finally
                {
                    if (dataReader != null)
                    {
                        dataReader.Close();
                    }
                }
                if(user != null)
                {
                    MainChatForm mcf = new MainChatForm(user);
                    this.Hide();
                    mcf.Show();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Wrong login or password", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private async void SignInForm_Load(object sender, EventArgs e)
        {
            await this.connection.OpenAsync();
        }

        private void SignInForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (this.connection != null && this.connection.State != System.Data.ConnectionState.Closed)
            {
                this.connection.Close();
                System.Windows.Forms.Application.Exit();
            }
        }

    }
}