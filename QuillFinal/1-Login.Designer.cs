namespace QuillFinal
{
    partial class LoginForm
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
            this.SourceCodeTB = new System.Windows.Forms.TextBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.loginconfirmButton = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.WelcomeBackLBL = new System.Windows.Forms.Label();
            this.ProfilePB = new System.Windows.Forms.PictureBox();
            this.CityPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityPB)).BeginInit();
            this.SuspendLayout();
            // 
            // SourceCodeTB
            // 
            this.SourceCodeTB.ForeColor = System.Drawing.Color.Gray;
            this.SourceCodeTB.Location = new System.Drawing.Point(185, 122);
            this.SourceCodeTB.Name = "SourceCodeTB";
            this.SourceCodeTB.Size = new System.Drawing.Size(118, 20);
            this.SourceCodeTB.TabIndex = 0;
            this.SourceCodeTB.Text = "Enter Source Code";
            this.SourceCodeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SignInButton.Location = new System.Drawing.Point(185, 148);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(118, 23);
            this.SignInButton.TabIndex = 1;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginconfirmButton
            // 
            this.loginconfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.loginconfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginconfirmButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginconfirmButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginconfirmButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.loginconfirmButton.Location = new System.Drawing.Point(185, 248);
            this.loginconfirmButton.Name = "loginconfirmButton";
            this.loginconfirmButton.Size = new System.Drawing.Size(118, 23);
            this.loginconfirmButton.TabIndex = 3;
            this.loginconfirmButton.Text = "Confirm";
            this.loginconfirmButton.UseVisualStyleBackColor = false;
            this.loginconfirmButton.Visible = false;
            this.loginconfirmButton.Click += new System.EventHandler(this.loginconfirmButton_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTB.Location = new System.Drawing.Point(185, 221);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(118, 21);
            this.PasswordTB.TabIndex = 2;
            this.PasswordTB.Text = "Password";
            this.PasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTB.Visible = false;
            // 
            // WelcomeBackLBL
            // 
            this.WelcomeBackLBL.AutoSize = true;
            this.WelcomeBackLBL.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeBackLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WelcomeBackLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WelcomeBackLBL.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBackLBL.ForeColor = System.Drawing.Color.White;
            this.WelcomeBackLBL.Location = new System.Drawing.Point(166, 90);
            this.WelcomeBackLBL.Name = "WelcomeBackLBL";
            this.WelcomeBackLBL.Size = new System.Drawing.Size(84, 15);
            this.WelcomeBackLBL.TabIndex = 4;
            this.WelcomeBackLBL.Text = "Welcome Back";
            this.WelcomeBackLBL.Visible = false;
            // 
            // ProfilePB
            // 
            this.ProfilePB.BackColor = System.Drawing.Color.White;
            this.ProfilePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProfilePB.Image = global::QuillFinal.Properties.Resources.user;
            this.ProfilePB.Location = new System.Drawing.Point(185, 108);
            this.ProfilePB.Name = "ProfilePB";
            this.ProfilePB.Size = new System.Drawing.Size(118, 107);
            this.ProfilePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePB.TabIndex = 5;
            this.ProfilePB.TabStop = false;
            this.ProfilePB.Visible = false;
            // 
            // CityPB
            // 
            this.CityPB.Image = global::QuillFinal.Properties.Resources.city;
            this.CityPB.Location = new System.Drawing.Point(-3, 0);
            this.CityPB.Name = "CityPB";
            this.CityPB.Size = new System.Drawing.Size(502, 300);
            this.CityPB.TabIndex = 6;
            this.CityPB.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 299);
            this.Controls.Add(this.ProfilePB);
            this.Controls.Add(this.WelcomeBackLBL);
            this.Controls.Add(this.loginconfirmButton);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.SourceCodeTB);
            this.Controls.Add(this.CityPB);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourceCodeTB;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button loginconfirmButton;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label WelcomeBackLBL;
        private System.Windows.Forms.PictureBox ProfilePB;
        private System.Windows.Forms.PictureBox CityPB;
    }
}

