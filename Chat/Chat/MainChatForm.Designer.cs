namespace Chat
{
    partial class MainChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainChatForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            this.showMessageTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.userSurname = new MetroFramework.Controls.MetroLabel();
            this.userName = new MetroFramework.Controls.MetroLabel();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.sendMessageButton = new MetroFramework.Controls.MetroButton();
            this.messageTextBox = new MetroFramework.Controls.MetroTextBox();
            this.userPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // showMessageTextBox
            // 
            // 
            // 
            // 
            this.showMessageTextBox.CustomButton.Image = null;
            this.showMessageTextBox.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.showMessageTextBox.CustomButton.Name = "";
            this.showMessageTextBox.CustomButton.Size = new System.Drawing.Size(535, 535);
            this.showMessageTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.showMessageTextBox.CustomButton.TabIndex = 1;
            this.showMessageTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.showMessageTextBox.CustomButton.UseSelectable = true;
            this.showMessageTextBox.CustomButton.Visible = false;
            this.showMessageTextBox.Lines = new string[0];
            this.showMessageTextBox.Location = new System.Drawing.Point(305, 60);
            this.showMessageTextBox.MaxLength = 32767;
            this.showMessageTextBox.Multiline = true;
            this.showMessageTextBox.Name = "showMessageTextBox";
            this.showMessageTextBox.PasswordChar = '\0';
            this.showMessageTextBox.ReadOnly = true;
            this.showMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.showMessageTextBox.SelectedText = "";
            this.showMessageTextBox.SelectionLength = 0;
            this.showMessageTextBox.SelectionStart = 0;
            this.showMessageTextBox.ShortcutsEnabled = true;
            this.showMessageTextBox.Size = new System.Drawing.Size(767, 537);
            this.showMessageTextBox.TabIndex = 20;
            this.showMessageTextBox.UseSelectable = true;
            this.showMessageTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.showMessageTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.Location = new System.Drawing.Point(30, 148);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(95, 29);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.White;
            this.metroButton1.TabIndex = 19;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // searchTextBox
            // 
            // 
            // 
            // 
            this.searchTextBox.CustomButton.Image = null;
            this.searchTextBox.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.searchTextBox.CustomButton.Name = "";
            this.searchTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.searchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchTextBox.CustomButton.TabIndex = 1;
            this.searchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchTextBox.CustomButton.UseSelectable = true;
            this.searchTextBox.CustomButton.Visible = false;
            this.searchTextBox.Lines = new string[0];
            this.searchTextBox.Location = new System.Drawing.Point(64, 199);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PromptText = "Search...";
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.SelectionLength = 0;
            this.searchTextBox.SelectionStart = 0;
            this.searchTextBox.ShortcutsEnabled = false;
            this.searchTextBox.Size = new System.Drawing.Size(178, 25);
            this.searchTextBox.TabIndex = 17;
            this.searchTextBox.UseSelectable = true;
            this.searchTextBox.WaterMark = "Search...";
            this.searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // userSurname
            // 
            this.userSurname.AutoSize = true;
            this.userSurname.Location = new System.Drawing.Point(150, 86);
            this.userSurname.Name = "userSurname";
            this.userSurname.Size = new System.Drawing.Size(74, 20);
            this.userSurname.TabIndex = 12;
            this.userSurname.Text = "SURNAME";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(150, 44);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(49, 20);
            this.userName.TabIndex = 16;
            this.userName.Text = "NAME";
            // 
            // metroListView1
            // 
            this.metroListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.metroListView1.Location = new System.Drawing.Point(30, 238);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(212, 439);
            this.metroListView1.TabIndex = 14;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.BackColor = System.Drawing.Color.Transparent;
            this.sendMessageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sendMessageButton.BackgroundImage")));
            this.sendMessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendMessageButton.Location = new System.Drawing.Point(1014, 627);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(58, 50);
            this.sendMessageButton.TabIndex = 13;
            this.sendMessageButton.UseSelectable = true;
            // 
            // messageTextBox
            // 
            // 
            // 
            // 
            this.messageTextBox.CustomButton.Image = null;
            this.messageTextBox.CustomButton.Location = new System.Drawing.Point(640, 2);
            this.messageTextBox.CustomButton.Name = "";
            this.messageTextBox.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.messageTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.messageTextBox.CustomButton.TabIndex = 1;
            this.messageTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.messageTextBox.CustomButton.UseSelectable = true;
            this.messageTextBox.CustomButton.Visible = false;
            this.messageTextBox.Lines = new string[0];
            this.messageTextBox.Location = new System.Drawing.Point(305, 627);
            this.messageTextBox.MaxLength = 300;
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.PasswordChar = '\0';
            this.messageTextBox.PromptText = "Input message...";
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.messageTextBox.SelectedText = "";
            this.messageTextBox.SelectionLength = 0;
            this.messageTextBox.SelectionStart = 0;
            this.messageTextBox.ShortcutsEnabled = true;
            this.messageTextBox.Size = new System.Drawing.Size(688, 50);
            this.messageTextBox.TabIndex = 11;
            this.messageTextBox.UseSelectable = true;
            this.messageTextBox.WaterMark = "Input message...";
            this.messageTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.messageTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // userPhoto
            // 
            this.userPhoto.BackColor = System.Drawing.Color.Transparent;
            this.userPhoto.Image = ((System.Drawing.Image)(resources.GetObject("userPhoto.Image")));
            this.userPhoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("userPhoto.InitialImage")));
            this.userPhoto.Location = new System.Drawing.Point(30, 32);
            this.userPhoto.Name = "userPhoto";
            this.userPhoto.Size = new System.Drawing.Size(95, 94);
            this.userPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPhoto.TabIndex = 15;
            this.userPhoto.TabStop = false;
            // 
            // MainChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 712);
            this.Controls.Add(this.showMessageTextBox);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.userSurname);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.userPhoto);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainChatForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox showMessageTextBox;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private MetroFramework.Controls.MetroLabel userSurname;
        private MetroFramework.Controls.MetroLabel userName;
        private MetroFramework.Controls.MetroListView metroListView1;
        private MetroFramework.Controls.MetroButton sendMessageButton;
        private MetroFramework.Controls.MetroTextBox messageTextBox;
        private System.Windows.Forms.PictureBox userPhoto;
    }
}