using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Chat
{ 
    public partial class ForgotPasswordForm : MetroFramework.Forms.MetroForm
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SignInForm reg = new SignInForm();
            this.Close();
            reg.Show();
        }

        private void SendCodeButton_Click(object sender, EventArgs e)
        {
            String pass  = this.GeneratePassword();
            String login = this.EmailBox.Text;
            SendToEmailAsync(pass,login).GetAwaiter();
            
            CodeFromEmailForm pfm = new CodeFromEmailForm(pass);
            this.Close();
            pfm.Show();
        }

        private async Task SendToEmailAsync(String password,String login)
        {
            MailAddress from = new MailAddress("fromMail", "Team Dev");
            MailAddress to = new MailAddress(login);
            MailMessage message = new MailMessage(from, to)
            {
                Subject = "Forgot password ?",
                Body = "Here is your code that you should use to create new password: " + Environment.NewLine + "Password: " + password
            };
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("fromMail", "fromPass"),
                EnableSsl = true
            };
            await smtp.SendMailAsync(message);
        }

        private String GeneratePassword()
        {
            Random rnd = new Random();
            Int32 number = rnd.Next(0, 10);

            number = number <= 2 ? 2 : 3;

            String answer = String.Empty;

            if (number == 2)
            {
                Char[] chrArr = new Char[6];
                Int32 p1 = rnd.Next(0, 6);
                Int32 p2 = rnd.Next(0, 6);
                p2 = p1 == p2 ? p1++ : p2;

                for (int i = 0; i < chrArr.Length; i++)
                {
                    if (i == p1)
                    {
                        chrArr[p1] = (Char)rnd.Next(65, 91);
                    }
                    else if (i == p2)
                    {
                        chrArr[p2] = (Char)rnd.Next(65, 91);
                    }
                    else
                    {
                        chrArr[i] = rnd.Next(0, 10).ToString().ToCharArray()[0];
                    }
                }
                answer = new String(chrArr);
            }
            else if (number == 3)
            {
                Char[] chrArr = new Char[6];
                Int32 p1 = rnd.Next(0, 6);
                Int32 p2 = rnd.Next(0, 6);
                Int32 p3 = rnd.Next(0, 6);

                p2 = p1 == p2 ? p1++ : p2;
                p3 = p2 == p3 ? p2++ : p3;

                for (int i = 0; i < chrArr.Length; i++)
                {
                    if (i == p1)
                    {
                        chrArr[p1] = (Char)rnd.Next(65, 91);
                    }
                    else if (i == p2)
                    {
                        chrArr[p2] = (Char)rnd.Next(65, 91);
                    }
                    else if (i == p3)
                    {
                        chrArr[p3] = (Char)rnd.Next(65, 91);
                    }
                    else
                    {
                        chrArr[i] = rnd.Next(0, 10).ToString().ToCharArray()[0];
                    }
                }
                answer = new String(chrArr);
            }

            return answer;
        }
    }
}
