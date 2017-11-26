
namespace Chat
{
    partial class PersonalInformationForm : MetroFramework.Forms.MetroForm
    {
        private UserLogic user;

        public PersonalInformationForm()
        {
            InitializeComponent();
        }

        public PersonalInformationForm(UserLogic user)
        {
            InitializeComponent();
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
    }
}
