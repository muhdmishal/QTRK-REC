﻿namespace Qtracker
{
    partial class Tracker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tracker));
            this.label3 = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.taskName = new System.Windows.Forms.Label();
            this.timeSpend = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stopTrack = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Project :";
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.Location = new System.Drawing.Point(67, 89);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(35, 13);
            this.projectName.TabIndex = 32;
            this.projectName.Text = "Name";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(67, 70);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 30;
            this.name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(33, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(71, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 60);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tracker";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Task :";
            // 
            // taskName
            // 
            this.taskName.AutoSize = true;
            this.taskName.Location = new System.Drawing.Point(67, 111);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(35, 13);
            this.taskName.TabIndex = 37;
            this.taskName.Text = "Name";
            // 
            // timeSpend
            // 
            this.timeSpend.AutoSize = true;
            this.timeSpend.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.timeSpend.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSpend.ForeColor = System.Drawing.Color.DarkRed;
            this.timeSpend.Location = new System.Drawing.Point(34, 160);
            this.timeSpend.Name = "timeSpend";
            this.timeSpend.Size = new System.Drawing.Size(212, 55);
            this.timeSpend.TabIndex = 36;
            this.timeSpend.Text = "00:00:00";
            this.timeSpend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Location = new System.Drawing.Point(85, 135);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(49, 13);
            this.startTime.TabIndex = 35;
            this.startTime.Text = "00:00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Start Time :";
            // 
            // stopTrack
            // 
            this.stopTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(53)))), ((int)(((byte)(46)))));
            this.stopTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopTrack.Location = new System.Drawing.Point(19, 218);
            this.stopTrack.Name = "stopTrack";
            this.stopTrack.Size = new System.Drawing.Size(250, 37);
            this.stopTrack.TabIndex = 39;
            this.stopTrack.Text = "Stop";
            this.stopTrack.UseVisualStyleBackColor = false;
            this.stopTrack.Click += new System.EventHandler(this.stopTrack_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.stopTrack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.taskName);
            this.Controls.Add(this.timeSpend);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Tracker";
            this.Text = "Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label taskName;
        private System.Windows.Forms.Label timeSpend;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button stopTrack;
        private System.Windows.Forms.Timer timer1;
    }
}