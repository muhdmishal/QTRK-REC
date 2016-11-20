namespace Qtracker
{
    partial class AddTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTask));
            this.btn_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.taskTitle = new System.Windows.Forms.TextBox();
            this.taskDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(53)))), ((int)(((byte)(46)))));
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Location = new System.Drawing.Point(17, 220);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(250, 37);
            this.btn_add.TabIndex = 28;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Project :";
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.Location = new System.Drawing.Point(70, 86);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(35, 13);
            this.projectName.TabIndex = 26;
            this.projectName.Text = "Name";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(68, 67);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 24;
            this.name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(36, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(74, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 60);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tracker";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.ForeColor = System.Drawing.Color.Red;
            this.message.Location = new System.Drawing.Point(18, 101);
            this.message.MaximumSize = new System.Drawing.Size(250, 30);
            this.message.MinimumSize = new System.Drawing.Size(250, 30);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(250, 30);
            this.message.TabIndex = 29;
            this.message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // taskTitle
            // 
            this.taskTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.taskTitle.BackColor = System.Drawing.Color.White;
            this.taskTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTitle.Location = new System.Drawing.Point(21, 137);
            this.taskTitle.MaximumSize = new System.Drawing.Size(250, 30);
            this.taskTitle.MinimumSize = new System.Drawing.Size(250, 30);
            this.taskTitle.Name = "taskTitle";
            this.taskTitle.Size = new System.Drawing.Size(250, 22);
            this.taskTitle.TabIndex = 30;
            this.taskTitle.Text = "Title";
            // 
            // taskDescription
            // 
            this.taskDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.taskDescription.BackColor = System.Drawing.Color.White;
            this.taskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescription.Location = new System.Drawing.Point(21, 173);
            this.taskDescription.MinimumSize = new System.Drawing.Size(250, 30);
            this.taskDescription.Multiline = true;
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.Size = new System.Drawing.Size(250, 41);
            this.taskDescription.TabIndex = 31;
            this.taskDescription.Text = "Description";
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.taskDescription);
            this.Controls.Add(this.taskTitle);
            this.Controls.Add(this.message);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddTask";
            this.Text = "AddTask";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.TextBox taskTitle;
        private System.Windows.Forms.TextBox taskDescription;
    }
}