using System;
using System.Data.SqlClient;

namespace Chat
{
    public partial class SignInForm : MetroFramework.Forms.MetroForm
    {
        private SqlConnection connection;

        public SignInForm()
        {
            InitializeComponent();
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

                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand(@"SELECT * FROM userData WHERE Login = '" + this.LoginBox.Text + @"'", this.connection);
                UserLogic user = null;
                try
                {
                    sqlReader = await command.ExecuteReaderAsync();
                    while (await sqlReader.ReadAsync())
                    {
                        String hash = CreateAccountForm.MD5Hash(this.PasswordBox.Text + sqlReader["Salt"].ToString());
                        if (hash == sqlReader["Password"].ToString())
                        {
                            String login = sqlReader["Login"].ToString();
                            String password = sqlReader["Password"].ToString();
                            String name = sqlReader["Name"].ToString();
                            String surname = sqlReader["Surname"].ToString();
                            DateTime birthday = Convert.ToDateTime(sqlReader["Birthday"].ToString());
                            String salt = sqlReader["Salt"].ToString();
                            DateTime registry = Convert.ToDateTime(sqlReader["Registry"].ToString());
                            
                            user = new UserLogic(login,password,name,surname,birthday,salt,registry);
                            
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Wrong e-mail or password", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {

                    System.Windows.Forms.MessageBox.Show(ex.Message, ex.Source, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlReader != null)
                    {
                        sqlReader.Close();
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
            this.connection = new SqlConnection(@"Data Source=desktop-v0dibpt;Initial Catalog=courseWorkDB;User id=sa;Password=123456;");
            //this.connection = new SqlConnection(@"Data Source=desktop-v0dibpt;Initial Catalog=courseWorkDB;User id=localhostserver;Password=localhost123");
            //this.connection = new SqlConnection(@"Data Source=DESKTOP-V0DIBPT;Initial Catalog=courseWorkDB;Integrated Security=True");
            await this.connection.OpenAsync();
        }

        private void SignInForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if(this.connection != null && this.connection.State != System.Data.ConnectionState.Closed)
            {
                this.connection.Close();
            }
        }
    }
}