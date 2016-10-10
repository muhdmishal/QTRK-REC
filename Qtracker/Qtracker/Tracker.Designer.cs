namespace Qtracker
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
            this.label1 = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.Label();
            this.timeSpend = new System.Windows.Forms.Label();
            this.stopTrack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.taskName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Time :";
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Location = new System.Drawing.Point(218, 9);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(49, 13);
            this.startTime.TabIndex = 1;
            this.startTime.Text = "00:00:00";
            // 
            // timeSpend
            // 
            this.timeSpend.AutoSize = true;
            this.timeSpend.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.timeSpend.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSpend.ForeColor = System.Drawing.Color.DarkRed;
            this.timeSpend.Location = new System.Drawing.Point(36, 83);
            this.timeSpend.MinimumSize = new System.Drawing.Size(200, 100);
            this.timeSpend.Name = "timeSpend";
            this.timeSpend.Size = new System.Drawing.Size(212, 100);
            this.timeSpend.TabIndex = 2;
            this.timeSpend.Text = "00:00:00";
            this.timeSpend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopTrack
            // 
            this.stopTrack.Location = new System.Drawing.Point(33, 193);
            this.stopTrack.Name = "stopTrack";
            this.stopTrack.Size = new System.Drawing.Size(215, 23);
            this.stopTrack.TabIndex = 3;
            this.stopTrack.Text = "Stop";
            this.stopTrack.UseVisualStyleBackColor = true;
            this.stopTrack.Click += new System.EventHandler(this.stopTrack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name :";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(76, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 8;
            this.name.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Project :";
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.Location = new System.Drawing.Point(79, 33);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(35, 13);
            this.projectName.TabIndex = 10;
            this.projectName.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Task :";
            // 
            // taskName
            // 
            this.taskName.AutoSize = true;
            this.taskName.Location = new System.Drawing.Point(79, 59);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(35, 13);
            this.taskName.TabIndex = 12;
            this.taskName.Text = "Name";
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.taskName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.stopTrack);
            this.Controls.Add(this.timeSpend);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tracker";
            this.Text = "Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.Label timeSpend;
        private System.Windows.Forms.Button stopTrack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label taskName;
        private System.Windows.Forms.Timer timer1;
    }
}