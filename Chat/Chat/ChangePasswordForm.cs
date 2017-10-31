using System;
using System.Data.SqlClient;

namespace Chat
{
    public partial class ChangePasswordForm : MetroFramework.Forms.MetroForm
    {
        private String login;
        private SqlConnection connection;

        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        public ChangePasswordForm(String login)
        {
            InitializeComponent();
            this.login = login;
        }

        private async void changeButton_Click(object sender, EventArgs e)
        {
            if (this.repeatTextBox.Text.Equals(this.passwordTextBox.Text) && (!String.IsNullOrEmpty(this.repeatTextBox.Text) || !String.IsNullOrWhiteSpace(this.repeatTextBox.Text)))
            {
                //    SqlCommand command = new SqlCommand("SELECT Salt FROM userData WHERE Login ='" + this.login + "'", this.connection);
                //    SqlDataReader sqlReader = null;

                //    try
                //    {
                //        sqlReader = await command.ExecuteReaderAsync();
                //        while (await sqlReader.ReadAsync())
                //        {
                //            String hash = CreateAccountForm.MD5Hash(this.repeatTextBox.Text + sqlReader["Salt"].ToString());
                //            SqlCommand insertCommand = new SqlCommand("INSERT INTO [userData] (Password) VALUES(@Password) WHERE Login ='" + this.login + "'", this.connection);
                //            insertCommand.Parameters.AddWithValue("Password", hash);
                //            await insertCommand.ExecuteNonQueryAsync();
                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        System.Windows.Forms.MessageBox.Show(ex.Message, ex.Source, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                //    }
                //    finally
                //    {
                //        if(sqlReader != null)
                //        {
                //            sqlReader.Close();
                //        }
                //    }
                //    SignInForm sif = new SignInForm();
                //    this.Hide();
                //    sif.Show();
                //}
                //else
                //{
                //    System.Windows.Forms.MessageBox.Show("Passwords are different", "Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                //}
            }
        }

        private async void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            this.connection = new SqlConnection(@"Data Source=DESKTOP-V0DIBPT;Initial Catalog=courseWorkDB;Integrated Security=True");
            await this.connection.OpenAsync();
        }

        private void ChangePasswordForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (this.connection != null && this.connection.State != System.Data.ConnectionState.Closed)
            {
                this.connection.Close();
            }
        }
    }
}