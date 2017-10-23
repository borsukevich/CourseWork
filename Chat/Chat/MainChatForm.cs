using System;
using System.Windows.Forms;

namespace Chat
{
    public partial class MainChatForm : MetroFramework.Forms.MetroForm
    {
        public MainChatForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
         
            /* When Миша пишет nice код  */
            //dialog.InitialDirectory = @"D:\CourseWork\Pictures";

            /* When я пишу bad код */
            dialog.InitialDirectory = @"D:\gitRepository\NewCourseWork\Pictures";

            dialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jped; *.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String path = dialog.FileName;

                this.userPhoto.Image = new System.Drawing.Bitmap(path);
                this.userPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
