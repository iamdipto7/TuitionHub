namespace TutorHub
{
    partial class SignUp3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblVerification = new MetroFramework.Controls.MetroLabel();
            this.txtVerification = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btnSendVerification = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(0, 37);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(800, 43);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Final Step ";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVerification
            // 
            this.lblVerification.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblVerification.Location = new System.Drawing.Point(0, 97);
            this.lblVerification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerification.Name = "lblVerification";
            this.lblVerification.Size = new System.Drawing.Size(800, 117);
            this.lblVerification.TabIndex = 1;
            this.lblVerification.Text = "Press Send Verification Code and Check your email to get verification code.";
            this.lblVerification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVerification
            // 
            // 
            // 
            // 
            this.txtVerification.CustomButton.Image = null;
            this.txtVerification.CustomButton.Location = new System.Drawing.Point(261, 1);
            this.txtVerification.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerification.CustomButton.Name = "";
            this.txtVerification.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtVerification.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVerification.CustomButton.TabIndex = 1;
            this.txtVerification.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVerification.CustomButton.UseSelectable = true;
            this.txtVerification.CustomButton.Visible = false;
            this.txtVerification.Enabled = false;
            this.txtVerification.Lines = new string[0];
            this.txtVerification.Location = new System.Drawing.Point(251, 310);
            this.txtVerification.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerification.MaxLength = 32767;
            this.txtVerification.Name = "txtVerification";
            this.txtVerification.PasswordChar = '\0';
            this.txtVerification.PromptText = "Enter Your Verification Code";
            this.txtVerification.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVerification.SelectedText = "";
            this.txtVerification.SelectionLength = 0;
            this.txtVerification.SelectionStart = 0;
            this.txtVerification.ShortcutsEnabled = true;
            this.txtVerification.Size = new System.Drawing.Size(297, 37);
            this.txtVerification.TabIndex = 2;
            this.txtVerification.UseSelectable = true;
            this.txtVerification.WaterMark = "Enter Your Verification Code";
            this.txtVerification.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVerification.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(407, 382);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(144, 46);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "complete Signup";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(251, 382);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(125, 46);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Previous";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnSendVerification
            // 
            this.btnSendVerification.Location = new System.Drawing.Point(307, 246);
            this.btnSendVerification.Name = "btnSendVerification";
            this.btnSendVerification.Size = new System.Drawing.Size(195, 35);
            this.btnSendVerification.TabIndex = 5;
            this.btnSendVerification.Text = "Send Verification Code";
            this.btnSendVerification.UseSelectable = true;
            this.btnSendVerification.Click += new System.EventHandler(this.btnSendVerification_Click);
            // 
            // SignUp3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSendVerification);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtVerification);
            this.Controls.Add(this.lblVerification);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUp3";
            this.Size = new System.Drawing.Size(800, 492);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblVerification;
        private MetroFramework.Controls.MetroTextBox txtVerification;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btnSendVerification;
    }
}
