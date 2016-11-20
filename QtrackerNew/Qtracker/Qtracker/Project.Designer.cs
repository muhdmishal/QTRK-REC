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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.projectList = new System.Windows.Forms.ComboBox();
            this.taskList = new System.Windows.Forms.ComboBox();
            this.startTrack = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.btn_addTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(66, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tracker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name :";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(60, 77);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 4;
            this.name.Text = "Name";
            // 
            // projectList
            // 
            this.projectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.projectList.FormattingEnabled = true;
            this.projectList.Location = new System.Drawing.Point(20, 139);
            this.projectList.MaximumSize = new System.Drawing.Size(250, 0);
            this.projectList.MinimumSize = new System.Drawing.Size(250, 0);
            this.projectList.Name = "projectList";
            this.projectList.Size = new System.Drawing.Size(250, 24);
            this.projectList.TabIndex = 5;
            this.projectList.SelectedIndexChanged += new System.EventHandler(this.projectList_SelectedIndexChanged);
            // 
            // taskList
            // 
            this.taskList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.taskList.FormattingEnabled = true;
            this.taskList.Location = new System.Drawing.Point(19, 177);
            this.taskList.MaximumSize = new System.Drawing.Size(250, 0);
            this.taskList.MinimumSize = new System.Drawing.Size(250, 0);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(250, 24);
            this.taskList.TabIndex = 6;
            // 
            // startTrack
            // 
            this.startTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(53)))), ((int)(((byte)(46)))));
            this.startTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startTrack.Location = new System.Drawing.Point(17, 210);
            this.startTrack.Name = "startTrack";
            this.startTrack.Size = new System.Drawing.Size(250, 37);
            this.startTrack.TabIndex = 7;
            this.startTrack.Text = "Track Time";
            this.startTrack.UseVisualStyleBackColor = false;
            this.startTrack.Click += new System.EventHandler(this.startTrack_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.ForeColor = System.Drawing.Color.Red;
            this.message.Location = new System.Drawing.Point(20, 97);
            this.message.MaximumSize = new System.Drawing.Size(250, 30);
            this.message.MinimumSize = new System.Drawing.Size(250, 30);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(250, 30);
            this.message.TabIndex = 8;
            this.message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_addTask
            // 
            this.btn_addTask.Location = new System.Drawing.Point(197, 71);
            this.btn_addTask.Name = "btn_addTask";
            this.btn_addTask.Size = new System.Drawing.Size(75, 23);
            this.btn_addTask.TabIndex = 9;
            this.btn_addTask.Text = "Add Task";
            this.btn_addTask.UseVisualStyleBackColor = true;
            this.btn_addTask.Click += new System.EventHandler(this.btn_addTask_Click);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_addTask);
            this.Controls.Add(this.message);
            this.Controls.Add(this.startTrack);
            this.Controls.Add(this.taskList);
            this.Controls.Add(this.projectList);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Project";
            this.Text = "Project";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ComboBox projectList;
        private System.Windows.Forms.ComboBox taskList;
        private System.Windows.Forms.Button startTrack;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button btn_addTask;
    }
}