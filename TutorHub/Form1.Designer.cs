﻿namespace TutorHub
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.home1 = new TutorHub.home();
            this.panelNav = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panelMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelNav, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.931419F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.06858F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1167, 627);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Controls.Add(this.home1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(3, 58);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1161, 566);
            this.panelMain.TabIndex = 0;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.home1.Location = new System.Drawing.Point(256, 4);
            this.home1.Margin = new System.Windows.Forms.Padding(4);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(659, 304);
            this.home1.TabIndex = 1;
            this.home1.UseCustomBackColor = true;
            this.home1.UseSelectable = true;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.SystemColors.Control;
            this.panelNav.Controls.Add(this.button3);
            this.panelNav.Controls.Add(this.button2);
            this.panelNav.Controls.Add(this.button1);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNav.Location = new System.Drawing.Point(3, 3);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(1161, 49);
            this.panelNav.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(963, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "User";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(481, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "TutorHub";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 721);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Resizable = false;
            this.Text = "Form1";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelNav;
        public home home1;
        public System.Windows.Forms.Panel panelMain;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
    }
}

