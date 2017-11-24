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
            this.showMessageTextBox = new MetroFramework.Controls.MetroTextBox();
            this.userSurname = new MetroFramework.Controls.MetroLabel();
            this.userName = new MetroFramework.Controls.MetroLabel();
            this.messageTextBox = new MetroFramework.Controls.MetroTextBox();
            this.sendMessagePictureBox = new System.Windows.Forms.PictureBox();
            this.userInfoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sendMessagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showMessageTextBox
            // 
            // 
            // 
            // 
            this.showMessageTextBox.CustomButton.Image = null;
            this.showMessageTextBox.CustomButton.Location = new System.Drawing.Point(180, 2);
            this.showMessageTextBox.CustomButton.Name = "";
            this.showMessageTextBox.CustomButton.Size = new System.Drawing.Size(311, 311);
            this.showMessageTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.showMessageTextBox.CustomButton.TabIndex = 1;
            this.showMessageTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.showMessageTextBox.CustomButton.UseSelectable = true;
            this.showMessageTextBox.CustomButton.Visible = false;
            this.showMessageTextBox.Lines = new string[0];
            this.showMessageTextBox.Location = new System.Drawing.Point(21, 113);
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
            this.showMessageTextBox.Size = new System.Drawing.Size(494, 316);
            this.showMessageTextBox.TabIndex = 20;
            this.showMessageTextBox.UseSelectable = true;
            this.showMessageTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.showMessageTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // userSurname
            // 
            this.userSurname.AutoSize = true;
            this.userSurname.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.userSurname.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.userSurname.Location = new System.Drawing.Point(143, 59);
            this.userSurname.Name = "userSurname";
            this.userSurname.Size = new System.Drawing.Size(105, 25);
            this.userSurname.TabIndex = 12;
            this.userSurname.Text = "SURNAME";
            this.userSurname.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.userName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.userName.Location = new System.Drawing.Point(120, 26);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(68, 25);
            this.userName.TabIndex = 16;
            this.userName.Text = "NAME";
            this.userName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // messageTextBox
            // 
            // 
            // 
            // 
            this.messageTextBox.CustomButton.Image = null;
            this.messageTextBox.CustomButton.Location = new System.Drawing.Point(370, 2);
            this.messageTextBox.CustomButton.Name = "";
            this.messageTextBox.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.messageTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.messageTextBox.CustomButton.TabIndex = 1;
            this.messageTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.messageTextBox.CustomButton.UseSelectable = true;
            this.messageTextBox.CustomButton.Visible = false;
            this.messageTextBox.Lines = new string[0];
            this.messageTextBox.Location = new System.Drawing.Point(21, 458);
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
            this.messageTextBox.Size = new System.Drawing.Size(418, 50);
            this.messageTextBox.TabIndex = 11;
            this.messageTextBox.UseSelectable = true;
            this.messageTextBox.WaterMark = "Input message...";
            this.messageTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.messageTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // sendMessagePictureBox
            // 
            this.sendMessagePictureBox.Image = global::Chat.Properties.Resources.sendMessage;
            this.sendMessagePictureBox.Location = new System.Drawing.Point(457, 458);
            this.sendMessagePictureBox.Name = "sendMessagePictureBox";
            this.sendMessagePictureBox.Size = new System.Drawing.Size(58, 50);
            this.sendMessagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sendMessagePictureBox.TabIndex = 23;
            this.sendMessagePictureBox.TabStop = false;
            this.sendMessagePictureBox.Click += new System.EventHandler(this.sendMessagePictureBox_Click);
            this.sendMessagePictureBox.MouseEnter += new System.EventHandler(this.sendMessagePictureBox_MouseEnter);
            this.sendMessagePictureBox.MouseLeave += new System.EventHandler(this.sendMessagePictureBox_MouseLeave);
            // 
            // userInfoPictureBox
            // 
            this.userInfoPictureBox.Image = global::Chat.Properties.Resources.userInfo;
            this.userInfoPictureBox.Location = new System.Drawing.Point(21, 26);
            this.userInfoPictureBox.Name = "userInfoPictureBox";
            this.userInfoPictureBox.Size = new System.Drawing.Size(75, 69);
            this.userInfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userInfoPictureBox.TabIndex = 22;
            this.userInfoPictureBox.TabStop = false;
            this.userInfoPictureBox.Click += new System.EventHandler(this.userInfoPictureBox_Click);
            this.userInfoPictureBox.MouseEnter += new System.EventHandler(this.userInfoPictureBox_MouseEnter);
            // 
            // MainChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 532);
            this.Controls.Add(this.sendMessagePictureBox);
            this.Controls.Add(this.userInfoPictureBox);
            this.Controls.Add(this.showMessageTextBox);
            this.Controls.Add(this.userSurname);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.messageTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainChatForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainChatForm_FormClosing);
            this.Load += new System.EventHandler(this.MainChatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sendMessagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox showMessageTextBox;
        private MetroFramework.Controls.MetroLabel userSurname;
        private MetroFramework.Controls.MetroLabel userName;
        private MetroFramework.Controls.MetroTextBox messageTextBox;
        private System.Windows.Forms.PictureBox userInfoPictureBox;
        private System.Windows.Forms.PictureBox sendMessagePictureBox;
    }
}