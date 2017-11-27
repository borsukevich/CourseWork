namespace Chat
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.repeatTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.changeButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.CausesValidation = false;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(141, 113);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.MaxLength = 30;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(245, 26);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(41, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Repeat:";
            // 
            // repeatTextBox
            // 
            this.repeatTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.repeatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatTextBox.Location = new System.Drawing.Point(141, 181);
            this.repeatTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.repeatTextBox.MaxLength = 30;
            this.repeatTextBox.Name = "repeatTextBox";
            this.repeatTextBox.Size = new System.Drawing.Size(245, 26);
            this.repeatTextBox.TabIndex = 1;
            this.repeatTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.passwordLabel.Location = new System.Drawing.Point(12, 109);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(126, 29);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password:";
            // 
            // changeButton
            // 
            this.changeButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.changeButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.changeButton.Highlight = true;
            this.changeButton.Location = new System.Drawing.Point(130, 249);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(180, 42);
            this.changeButton.Style = MetroFramework.MetroColorStyle.Green;
            this.changeButton.TabIndex = 13;
            this.changeButton.Text = "Change";
            this.changeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.changeButton.UseCustomBackColor = true;
            this.changeButton.UseSelectable = true;
            this.changeButton.UseStyleColors = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 350);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.repeatTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "New Password";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePasswordForm_FormClosing);
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repeatTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private MetroFramework.Controls.MetroButton changeButton;
    }
}