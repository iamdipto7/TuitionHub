namespace TutorHub
{
    partial class HomePage
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
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.tileEditProfile = new MetroFramework.Controls.MetroTile();
            this.tileCreatePost = new MetroFramework.Controls.MetroTile();
            this.tileLogOut = new MetroFramework.Controls.MetroTile();
            this.tileMyPost = new MetroFramework.Controls.MetroTile();
            this.tileViewPost = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(293, 146);
            this.metroTile6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(188, 234);
            this.metroTile6.TabIndex = 11;
            this.metroTile6.Text = "profile";
            this.metroTile6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // tileEditProfile
            // 
            this.tileEditProfile.ActiveControl = null;
            this.tileEditProfile.Location = new System.Drawing.Point(489, 270);
            this.tileEditProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tileEditProfile.Name = "tileEditProfile";
            this.tileEditProfile.Size = new System.Drawing.Size(127, 111);
            this.tileEditProfile.TabIndex = 10;
            this.tileEditProfile.Text = "edit profile";
            this.tileEditProfile.UseSelectable = true;
            // 
            // tileCreatePost
            // 
            this.tileCreatePost.ActiveControl = null;
            this.tileCreatePost.Location = new System.Drawing.Point(489, 146);
            this.tileCreatePost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tileCreatePost.Name = "tileCreatePost";
            this.tileCreatePost.Size = new System.Drawing.Size(127, 116);
            this.tileCreatePost.TabIndex = 9;
            this.tileCreatePost.Text = "Create post";
            this.tileCreatePost.UseSelectable = true;
            this.tileCreatePost.Click += new System.EventHandler(this.tileCreatePost_Click);
            // 
            // tileLogOut
            // 
            this.tileLogOut.ActiveControl = null;
            this.tileLogOut.Location = new System.Drawing.Point(751, 270);
            this.tileLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tileLogOut.Name = "tileLogOut";
            this.tileLogOut.Size = new System.Drawing.Size(132, 111);
            this.tileLogOut.TabIndex = 8;
            this.tileLogOut.Text = "Log Out";
            this.tileLogOut.UseSelectable = true;
            // 
            // tileMyPost
            // 
            this.tileMyPost.ActiveControl = null;
            this.tileMyPost.Location = new System.Drawing.Point(624, 270);
            this.tileMyPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tileMyPost.Name = "tileMyPost";
            this.tileMyPost.Size = new System.Drawing.Size(119, 111);
            this.tileMyPost.TabIndex = 7;
            this.tileMyPost.Text = "my posts";
            this.tileMyPost.UseSelectable = true;
            // 
            // tileViewPost
            // 
            this.tileViewPost.ActiveControl = null;
            this.tileViewPost.Location = new System.Drawing.Point(624, 146);
            this.tileViewPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tileViewPost.Name = "tileViewPost";
            this.tileViewPost.Size = new System.Drawing.Size(259, 116);
            this.tileViewPost.TabIndex = 6;
            this.tileViewPost.Text = "View Post";
            this.tileViewPost.UseSelectable = true;
            this.tileViewPost.Click += new System.EventHandler(this.tileViewPost_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.tileEditProfile);
            this.Controls.Add(this.tileCreatePost);
            this.Controls.Add(this.tileLogOut);
            this.Controls.Add(this.tileMyPost);
            this.Controls.Add(this.tileViewPost);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1167, 549);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile tileEditProfile;
        private MetroFramework.Controls.MetroTile tileCreatePost;
        private MetroFramework.Controls.MetroTile tileLogOut;
        private MetroFramework.Controls.MetroTile tileMyPost;
        private MetroFramework.Controls.MetroTile tileViewPost;
    }
}
