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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainChatForm));
            this.showMessageTextBox = new MetroFramework.Controls.MetroTextBox();
            this.userName = new MetroFramework.Controls.MetroLabel();
            this.messageTextBox = new MetroFramework.Controls.MetroTextBox();
            this.sendMessagePictureBox = new System.Windows.Forms.PictureBox();
            this.userInfoPictureBox = new System.Windows.Forms.PictureBox();
            this.userSurname = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sendMessagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showMessageTextBox
            // 
            // 
            // 
            // 
            this.showMessageTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.showMessageTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.showMessageTextBox.CustomButton.Name = "";
            this.showMessageTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.showMessageTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.showMessageTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.showMessageTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.showMessageTextBox.CustomButton.UseSelectable = true;
            this.showMessageTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.showMessageTextBox.Lines = new string[0];
            resources.ApplyResources(this.showMessageTextBox, "showMessageTextBox");
            this.showMessageTextBox.MaxLength = 32767;
            this.showMessageTextBox.Multiline = true;
            this.showMessageTextBox.Name = "showMessageTextBox";
            this.showMessageTextBox.PasswordChar = '\0';
            this.showMessageTextBox.ReadOnly = true;
            this.showMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showMessageTextBox.SelectedText = "";
            this.showMessageTextBox.SelectionLength = 0;
            this.showMessageTextBox.SelectionStart = 0;
            this.showMessageTextBox.ShortcutsEnabled = true;
            this.showMessageTextBox.UseSelectable = true;
            this.showMessageTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.showMessageTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.showMessageTextBox.Enter += new System.EventHandler(this.showMessageTextBox_Enter);
            // 
            // userName
            // 
            resources.ApplyResources(this.userName, "userName");
            this.userName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.userName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.userName.Name = "userName";
            this.userName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // messageTextBox
            // 
            // 
            // 
            // 
            this.messageTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.messageTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.messageTextBox.CustomButton.Name = "";
            this.messageTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.messageTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.messageTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.messageTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.messageTextBox.CustomButton.UseSelectable = true;
            this.messageTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.messageTextBox.Lines = new string[0];
            resources.ApplyResources(this.messageTextBox, "messageTextBox");
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
            this.messageTextBox.UseSelectable = true;
            this.messageTextBox.WaterMark = "Input message...";
            this.messageTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.messageTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // sendMessagePictureBox
            // 
            this.sendMessagePictureBox.Image = global::Chat.Properties.Resources.sendMessage;
            resources.ApplyResources(this.sendMessagePictureBox, "sendMessagePictureBox");
            this.sendMessagePictureBox.Name = "sendMessagePictureBox";
            this.sendMessagePictureBox.TabStop = false;
            this.sendMessagePictureBox.Click += new System.EventHandler(this.sendMessagePictureBox_Click);
            this.sendMessagePictureBox.MouseEnter += new System.EventHandler(this.sendMessagePictureBox_MouseEnter);
            this.sendMessagePictureBox.MouseLeave += new System.EventHandler(this.sendMessagePictureBox_MouseLeave);
            // 
            // userInfoPictureBox
            // 
            this.userInfoPictureBox.Image = global::Chat.Properties.Resources.userInfo;
            resources.ApplyResources(this.userInfoPictureBox, "userInfoPictureBox");
            this.userInfoPictureBox.Name = "userInfoPictureBox";
            this.userInfoPictureBox.TabStop = false;
            this.userInfoPictureBox.Click += new System.EventHandler(this.userInfoPictureBox_Click);
            this.userInfoPictureBox.MouseEnter += new System.EventHandler(this.userInfoPictureBox_MouseEnter);
            // 
            // userSurname
            // 
            resources.ApplyResources(this.userSurname, "userSurname");
            this.userSurname.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.userSurname.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.userSurname.Name = "userSurname";
            this.userSurname.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainChatForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sendMessagePictureBox);
            this.Controls.Add(this.userInfoPictureBox);
            this.Controls.Add(this.showMessageTextBox);
            this.Controls.Add(this.userSurname);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.messageTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainChatForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Activated += new System.EventHandler(this.MainChatForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainChatForm_FormClosing);
            this.Load += new System.EventHandler(this.MainChatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sendMessagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox showMessageTextBox;
        private MetroFramework.Controls.MetroLabel userName;
        private MetroFramework.Controls.MetroTextBox messageTextBox;
        private System.Windows.Forms.PictureBox userInfoPictureBox;
        private System.Windows.Forms.PictureBox sendMessagePictureBox;
        private MetroFramework.Controls.MetroLabel userSurname;
        private System.Windows.Forms.Timer timer1;
    }
}