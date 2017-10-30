namespace Chat
{
    partial class CreateAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountForm));
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.NameLabel = new MetroFramework.Controls.MetroLabel();
            this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NamePictureBox = new System.Windows.Forms.PictureBox();
            this.SurnameLabel = new MetroFramework.Controls.MetroLabel();
            this.SurnameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.BirthdayLabel = new MetroFramework.Controls.MetroLabel();
            this.userDayBirth = new MetroFramework.Controls.MetroComboBox();
            this.userMonthBirth = new MetroFramework.Controls.MetroComboBox();
            this.userYearBirth = new MetroFramework.Controls.MetroComboBox();
            this.LoginLabel = new MetroFramework.Controls.MetroLabel();
            this.LoginTextBox = new MetroFramework.Controls.MetroTextBox();
            this.LoginPictureBox = new System.Windows.Forms.PictureBox();
            this.SurnamePictureBox = new System.Windows.Forms.PictureBox();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordPictureBox = new System.Windows.Forms.PictureBox();
            this.RepeatPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.RepeatPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.RepeatPasswordPictureBox = new System.Windows.Forms.PictureBox();
            this.CreateAccountButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurnamePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatPasswordPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Location = new System.Drawing.Point(24, 28);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(40, 37);
            this.BackButton.TabIndex = 21;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(17, 87);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(69, 25);
            this.NameLabel.Style = MetroFramework.MetroColorStyle.Black;
            this.NameLabel.TabIndex = 22;
            this.NameLabel.Text = "Name: ";
            this.NameLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // NameTextBox
            // 
            // 
            // 
            // 
            this.NameTextBox.CustomButton.Image = null;
            this.NameTextBox.CustomButton.Location = new System.Drawing.Point(329, 1);
            this.NameTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.CustomButton.Name = "";
            this.NameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameTextBox.CustomButton.TabIndex = 1;
            this.NameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameTextBox.CustomButton.UseSelectable = true;
            this.NameTextBox.CustomButton.Visible = false;
            this.NameTextBox.Lines = new string[0];
            this.NameTextBox.Location = new System.Drawing.Point(24, 126);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.MaxLength = 20;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.SelectionLength = 0;
            this.NameTextBox.SelectionStart = 0;
            this.NameTextBox.ShortcutsEnabled = true;
            this.NameTextBox.Size = new System.Drawing.Size(351, 23);
            this.NameTextBox.TabIndex = 23;
            this.NameTextBox.UseSelectable = true;
            this.NameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // NamePictureBox
            // 
            this.NamePictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("NamePictureBox.ErrorImage")));
            this.NamePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("NamePictureBox.InitialImage")));
            this.NamePictureBox.Location = new System.Drawing.Point(348, 94);
            this.NamePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NamePictureBox.Name = "NamePictureBox";
            this.NamePictureBox.Size = new System.Drawing.Size(27, 25);
            this.NamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NamePictureBox.TabIndex = 24;
            this.NamePictureBox.TabStop = false;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SurnameLabel.Location = new System.Drawing.Point(17, 164);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(91, 25);
            this.SurnameLabel.Style = MetroFramework.MetroColorStyle.Black;
            this.SurnameLabel.TabIndex = 25;
            this.SurnameLabel.Text = "Surname: ";
            this.SurnameLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SurnameTextBox
            // 
            // 
            // 
            // 
            this.SurnameTextBox.CustomButton.Image = null;
            this.SurnameTextBox.CustomButton.Location = new System.Drawing.Point(329, 1);
            this.SurnameTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SurnameTextBox.CustomButton.Name = "";
            this.SurnameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SurnameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SurnameTextBox.CustomButton.TabIndex = 1;
            this.SurnameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SurnameTextBox.CustomButton.UseSelectable = true;
            this.SurnameTextBox.CustomButton.Visible = false;
            this.SurnameTextBox.Lines = new string[0];
            this.SurnameTextBox.Location = new System.Drawing.Point(24, 199);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SurnameTextBox.MaxLength = 30;
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.PasswordChar = '\0';
            this.SurnameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SurnameTextBox.SelectedText = "";
            this.SurnameTextBox.SelectionLength = 0;
            this.SurnameTextBox.SelectionStart = 0;
            this.SurnameTextBox.ShortcutsEnabled = true;
            this.SurnameTextBox.Size = new System.Drawing.Size(351, 23);
            this.SurnameTextBox.TabIndex = 26;
            this.SurnameTextBox.UseSelectable = true;
            this.SurnameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SurnameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTextBox_KeyPress);
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.BirthdayLabel.Location = new System.Drawing.Point(17, 235);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(87, 25);
            this.BirthdayLabel.Style = MetroFramework.MetroColorStyle.Black;
            this.BirthdayLabel.TabIndex = 27;
            this.BirthdayLabel.Text = "Birthday: ";
            this.BirthdayLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // userDayBirth
            // 
            this.userDayBirth.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userDayBirth.DropDownHeight = 100;
            this.userDayBirth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userDayBirth.FormattingEnabled = true;
            this.userDayBirth.IntegralHeight = false;
            this.userDayBirth.ItemHeight = 24;
            this.userDayBirth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.userDayBirth.Location = new System.Drawing.Point(24, 270);
            this.userDayBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userDayBirth.Name = "userDayBirth";
            this.userDayBirth.Size = new System.Drawing.Size(57, 30);
            this.userDayBirth.TabIndex = 28;
            this.userDayBirth.UseSelectable = true;
            // 
            // userMonthBirth
            // 
            this.userMonthBirth.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userMonthBirth.DropDownHeight = 100;
            this.userMonthBirth.FormattingEnabled = true;
            this.userMonthBirth.IntegralHeight = false;
            this.userMonthBirth.ItemHeight = 24;
            this.userMonthBirth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.userMonthBirth.Location = new System.Drawing.Point(103, 270);
            this.userMonthBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userMonthBirth.Name = "userMonthBirth";
            this.userMonthBirth.Size = new System.Drawing.Size(139, 30);
            this.userMonthBirth.TabIndex = 29;
            this.userMonthBirth.UseSelectable = true;
            // 
            // userYearBirth
            // 
            this.userYearBirth.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userYearBirth.DropDownHeight = 100;
            this.userYearBirth.FormattingEnabled = true;
            this.userYearBirth.IntegralHeight = false;
            this.userYearBirth.ItemHeight = 24;
            this.userYearBirth.Items.AddRange(new object[] {
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.userYearBirth.Location = new System.Drawing.Point(263, 270);
            this.userYearBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userYearBirth.Name = "userYearBirth";
            this.userYearBirth.Size = new System.Drawing.Size(111, 30);
            this.userYearBirth.TabIndex = 30;
            this.userYearBirth.UseSelectable = true;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LoginLabel.Location = new System.Drawing.Point(17, 314);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(66, 25);
            this.LoginLabel.Style = MetroFramework.MetroColorStyle.Black;
            this.LoginLabel.TabIndex = 31;
            this.LoginLabel.Text = "Login: ";
            this.LoginLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LoginTextBox
            // 
            // 
            // 
            // 
            this.LoginTextBox.CustomButton.Image = null;
            this.LoginTextBox.CustomButton.Location = new System.Drawing.Point(329, 1);
            this.LoginTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginTextBox.CustomButton.Name = "";
            this.LoginTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LoginTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LoginTextBox.CustomButton.TabIndex = 1;
            this.LoginTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LoginTextBox.CustomButton.UseSelectable = true;
            this.LoginTextBox.CustomButton.Visible = false;
            this.LoginTextBox.Lines = new string[0];
            this.LoginTextBox.Location = new System.Drawing.Point(24, 348);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginTextBox.MaxLength = 30;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PasswordChar = '\0';
            this.LoginTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LoginTextBox.SelectedText = "";
            this.LoginTextBox.SelectionLength = 0;
            this.LoginTextBox.SelectionStart = 0;
            this.LoginTextBox.ShortcutsEnabled = true;
            this.LoginTextBox.Size = new System.Drawing.Size(351, 23);
            this.LoginTextBox.TabIndex = 32;
            this.LoginTextBox.UseSelectable = true;
            this.LoginTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LoginTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.LoginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTextBox_KeyPress);
            // 
            // LoginPictureBox
            // 
            this.LoginPictureBox.ErrorImage = null;
            this.LoginPictureBox.InitialImage = null;
            this.LoginPictureBox.Location = new System.Drawing.Point(348, 318);
            this.LoginPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginPictureBox.Name = "LoginPictureBox";
            this.LoginPictureBox.Size = new System.Drawing.Size(27, 25);
            this.LoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginPictureBox.TabIndex = 33;
            this.LoginPictureBox.TabStop = false;
            // 
            // SurnamePictureBox
            // 
            this.SurnamePictureBox.ErrorImage = null;
            this.SurnamePictureBox.InitialImage = null;
            this.SurnamePictureBox.Location = new System.Drawing.Point(348, 167);
            this.SurnamePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SurnamePictureBox.Name = "SurnamePictureBox";
            this.SurnamePictureBox.Size = new System.Drawing.Size(27, 25);
            this.SurnamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SurnamePictureBox.TabIndex = 34;
            this.SurnamePictureBox.TabStop = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PasswordLabel.Location = new System.Drawing.Point(17, 385);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(94, 25);
            this.PasswordLabel.Style = MetroFramework.MetroColorStyle.Black;
            this.PasswordLabel.TabIndex = 35;
            this.PasswordLabel.Text = "Password: ";
            this.PasswordLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // PasswordTextBox
            // 
            // 
            // 
            // 
            this.PasswordTextBox.CustomButton.Image = null;
            this.PasswordTextBox.CustomButton.Location = new System.Drawing.Point(329, 1);
            this.PasswordTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTextBox.CustomButton.Name = "";
            this.PasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextBox.CustomButton.TabIndex = 1;
            this.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTextBox.CustomButton.UseSelectable = true;
            this.PasswordTextBox.CustomButton.Visible = false;
            this.PasswordTextBox.Lines = new string[0];
            this.PasswordTextBox.Location = new System.Drawing.Point(24, 421);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTextBox.MaxLength = 30;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.ShortcutsEnabled = false;
            this.PasswordTextBox.Size = new System.Drawing.Size(351, 23);
            this.PasswordTextBox.TabIndex = 36;
            this.PasswordTextBox.UseSelectable = true;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextBox_KeyPress);
            // 
            // PasswordPictureBox
            // 
            this.PasswordPictureBox.ErrorImage = null;
            this.PasswordPictureBox.InitialImage = null;
            this.PasswordPictureBox.Location = new System.Drawing.Point(348, 391);
            this.PasswordPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordPictureBox.Name = "PasswordPictureBox";
            this.PasswordPictureBox.Size = new System.Drawing.Size(27, 25);
            this.PasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PasswordPictureBox.TabIndex = 37;
            this.PasswordPictureBox.TabStop = false;
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.AutoSize = true;
            this.RepeatPasswordLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(17, 459);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(153, 25);
            this.RepeatPasswordLabel.Style = MetroFramework.MetroColorStyle.Black;
            this.RepeatPasswordLabel.TabIndex = 38;
            this.RepeatPasswordLabel.Text = "Repeat password:";
            this.RepeatPasswordLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RepeatPasswordTextBox
            // 
            // 
            // 
            // 
            this.RepeatPasswordTextBox.CustomButton.Image = null;
            this.RepeatPasswordTextBox.CustomButton.Location = new System.Drawing.Point(329, 1);
            this.RepeatPasswordTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RepeatPasswordTextBox.CustomButton.Name = "";
            this.RepeatPasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RepeatPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RepeatPasswordTextBox.CustomButton.TabIndex = 1;
            this.RepeatPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RepeatPasswordTextBox.CustomButton.UseSelectable = true;
            this.RepeatPasswordTextBox.CustomButton.Visible = false;
            this.RepeatPasswordTextBox.Lines = new string[0];
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(24, 495);
            this.RepeatPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RepeatPasswordTextBox.MaxLength = 30;
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.PasswordChar = '●';
            this.RepeatPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RepeatPasswordTextBox.SelectedText = "";
            this.RepeatPasswordTextBox.SelectionLength = 0;
            this.RepeatPasswordTextBox.SelectionStart = 0;
            this.RepeatPasswordTextBox.ShortcutsEnabled = false;
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(351, 23);
            this.RepeatPasswordTextBox.TabIndex = 39;
            this.RepeatPasswordTextBox.UseSelectable = true;
            this.RepeatPasswordTextBox.UseSystemPasswordChar = true;
            this.RepeatPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RepeatPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.RepeatPasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RepeatPasswordTextBox_KeyPress);
            // 
            // RepeatPasswordPictureBox
            // 
            this.RepeatPasswordPictureBox.InitialImage = null;
            this.RepeatPasswordPictureBox.Location = new System.Drawing.Point(348, 465);
            this.RepeatPasswordPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RepeatPasswordPictureBox.Name = "RepeatPasswordPictureBox";
            this.RepeatPasswordPictureBox.Size = new System.Drawing.Size(27, 25);
            this.RepeatPasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RepeatPasswordPictureBox.TabIndex = 40;
            this.RepeatPasswordPictureBox.TabStop = false;
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.CreateAccountButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.CreateAccountButton.Highlight = true;
            this.CreateAccountButton.Location = new System.Drawing.Point(24, 551);
            this.CreateAccountButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(351, 37);
            this.CreateAccountButton.TabIndex = 41;
            this.CreateAccountButton.Text = "Create";
            this.CreateAccountButton.UseSelectable = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 615);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.RepeatPasswordPictureBox);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.PasswordPictureBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.SurnamePictureBox);
            this.Controls.Add(this.LoginPictureBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.userYearBirth);
            this.Controls.Add(this.userMonthBirth);
            this.Controls.Add(this.userDayBirth);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NamePictureBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.BackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateAccountForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Registration";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateAccountForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateAccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurnamePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatPasswordPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackButton;
        private MetroFramework.Controls.MetroLabel NameLabel;
        private MetroFramework.Controls.MetroTextBox NameTextBox;
        private System.Windows.Forms.PictureBox NamePictureBox;
        private MetroFramework.Controls.MetroLabel SurnameLabel;
        private MetroFramework.Controls.MetroTextBox SurnameTextBox;
        private MetroFramework.Controls.MetroLabel BirthdayLabel;
        private MetroFramework.Controls.MetroComboBox userDayBirth;
        private MetroFramework.Controls.MetroComboBox userMonthBirth;
        private MetroFramework.Controls.MetroComboBox userYearBirth;
        private MetroFramework.Controls.MetroLabel LoginLabel;
        private MetroFramework.Controls.MetroTextBox LoginTextBox;
        private System.Windows.Forms.PictureBox LoginPictureBox;
        private System.Windows.Forms.PictureBox SurnamePictureBox;
        private MetroFramework.Controls.MetroLabel PasswordLabel;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox PasswordPictureBox;
        private MetroFramework.Controls.MetroLabel RepeatPasswordLabel;
        private MetroFramework.Controls.MetroTextBox RepeatPasswordTextBox;
        private System.Windows.Forms.PictureBox RepeatPasswordPictureBox;
        private MetroFramework.Controls.MetroButton CreateAccountButton;
    }
}