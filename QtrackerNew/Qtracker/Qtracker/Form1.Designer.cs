namespace Qtracker
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.message = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(75, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tracker";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.ForeColor = System.Drawing.Color.Red;
            this.message.Location = new System.Drawing.Point(17, 80);
            this.message.MaximumSize = new System.Drawing.Size(250, 30);
            this.message.MinimumSize = new System.Drawing.Size(250, 30);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(250, 30);
            this.message.TabIndex = 2;
            this.message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // username
            // 
            this.username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.username.BackColor = System.Drawing.Color.White;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(20, 127);
            this.username.MaximumSize = new System.Drawing.Size(250, 30);
            this.username.MinimumSize = new System.Drawing.Size(250, 30);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(250, 30);
            this.username.TabIndex = 3;
            this.username.Text = "Username";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.password.BackColor = System.Drawing.Color.White;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(20, 164);
            this.password.MaximumSize = new System.Drawing.Size(250, 30);
            this.password.MinimumSize = new System.Drawing.Size(250, 30);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(250, 30);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(53)))), ((int)(((byte)(46)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Location = new System.Drawing.Point(20, 202);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(250, 37);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.message);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Text = "QTracker Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button btn_login;
    }
}

