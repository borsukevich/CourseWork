namespace Chat
{
    partial class CodeFromEmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeFromEmailForm));
            this.label1 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.SubmitCodeButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(19, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code:";
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailBox.Location = new System.Drawing.Point(119, 117);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(245, 26);
            this.EmailBox.TabIndex = 4;
            // 
            // SubmitCodeButton
            // 
            this.SubmitCodeButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.SubmitCodeButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.SubmitCodeButton.Highlight = true;
            this.SubmitCodeButton.Location = new System.Drawing.Point(119, 195);
            this.SubmitCodeButton.Name = "SubmitCodeButton";
            this.SubmitCodeButton.Size = new System.Drawing.Size(180, 42);
            this.SubmitCodeButton.Style = MetroFramework.MetroColorStyle.Green;
            this.SubmitCodeButton.TabIndex = 43;
            this.SubmitCodeButton.Text = "Submit";
            this.SubmitCodeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SubmitCodeButton.UseCustomBackColor = true;
            this.SubmitCodeButton.UseSelectable = true;
            this.SubmitCodeButton.UseStyleColors = true;
            this.SubmitCodeButton.Click += new System.EventHandler(this.SubmitCodeButton_Click);
            // 
            // CodeFromEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 265);
            this.Controls.Add(this.SubmitCodeButton);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodeFromEmailForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Code";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CodeFromEmailForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailBox;
        private MetroFramework.Controls.MetroButton SubmitCodeButton;
    }
}