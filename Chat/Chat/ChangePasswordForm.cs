using System;
using MySql.Data.MySqlClient;

namespace Chat
{
    public partial class ChangePasswordForm : MetroFramework.Forms.MetroForm
    {
        private String login;
        private MySqlConnectionStringBuilder connectStr;
        private MySqlConnection connection;

        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        public ChangePasswordForm(String login)
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
            this.login = login;
        }

        private async void changeButton_Click(object sender, EventArgs e)
        {
            if (this.repeatTextBox.Text.Equals(this.passwordTextBox.Text) && (!String.IsNullOrEmpty(this.repeatTextBox.Text) || !String.IsNullOrWhiteSpace(this.repeatTextBox.Text)))
            {
                MySqlCommand command = this.connection.CreateCommand();            
                command.CommandText = @"SELECT salt FROM User WHERE login = '" + this.login + @"'";
                System.Data.Common.DbDataReader dataReader = null;
                MySqlCommand updateCommand = this.connection.CreateCommand();
                
                try
                {
                    dataReader = await command.ExecuteReaderAsync();

                    while (await dataReader.ReadAsync())
                    {
                        String hash = CreateAccountForm.MD5Hash(this.passwordTextBox.Text + dataReader["Salt"].ToString().Substring(1));
                        updateCommand.CommandText = $"UPDATE User SET password='{hash}' WHERE login='{this.login}';";
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, ex.Source, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                finally
                {
                    if(dataReader != null)
                    {
                        dataReader.Close();
                    }
                    if (updateCommand != null)
                    {
                        await updateCommand.ExecuteNonQueryAsync();
                    }
                }
                SignInForm sif = new SignInForm();
                this.Hide();
                sif.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Different passwords", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private async void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            await this.connection.OpenAsync();
        }

        private void ChangePasswordForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (this.connection != null && this.connection.State != System.Data.ConnectionState.Closed)
            {
                this.connection.Close();
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}