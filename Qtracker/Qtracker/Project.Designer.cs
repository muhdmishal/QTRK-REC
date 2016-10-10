namespace Qtracker
{
    partial class Project
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
            this.message = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.projectList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.ForeColor = System.Drawing.Color.Red;
            this.message.Location = new System.Drawing.Point(24, 54);
            this.message.MaximumSize = new System.Drawing.Size(250, 100);
            this.message.MinimumSize = new System.Drawing.Size(230, 30);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(230, 30);
            this.message.TabIndex = 2;
            this.message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(27, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 3;
            this.name.Text = "Name";
            // 
            // projectList
            // 
            this.projectList.FormattingEnabled = true;
            this.projectList.Location = new System.Drawing.Point(30, 62);
            this.projectList.Name = "projectList";
            this.projectList.Size = new System.Drawing.Size(224, 21);
            this.projectList.TabIndex = 4;
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.projectList);
            this.Controls.Add(this.name);
            this.Controls.Add(this.message);
            this.Name = "Project";
            this.Text = "QTracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ComboBox projectList;
    }
}