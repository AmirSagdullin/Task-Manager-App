namespace Task_Manager
{
    partial class AddTeamTask
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
            this.nameTask = new System.Windows.Forms.TextBox();
            this.distribution = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonNewTask = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.TextBox();
            this.closeTeamTask = new System.Windows.Forms.Label();
            this.dateTimePicker_to_solve = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTask
            // 
            this.nameTask.Location = new System.Drawing.Point(205, 126);
            this.nameTask.Margin = new System.Windows.Forms.Padding(4);
            this.nameTask.Multiline = true;
            this.nameTask.Name = "nameTask";
            this.nameTask.Size = new System.Drawing.Size(323, 21);
            this.nameTask.TabIndex = 44;
            // 
            // distribution
            // 
            this.distribution.Location = new System.Drawing.Point(205, 176);
            this.distribution.Margin = new System.Windows.Forms.Padding(4);
            this.distribution.Multiline = true;
            this.distribution.Name = "distribution";
            this.distribution.Size = new System.Drawing.Size(323, 74);
            this.distribution.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 44);
            this.label7.TabIndex = 42;
            this.label7.Text = "описание:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 62);
            this.label6.TabIndex = 41;
            this.label6.Text = "название \r\nзадачи:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonNewTask
            // 
            this.buttonNewTask.Location = new System.Drawing.Point(395, 438);
            this.buttonNewTask.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNewTask.Name = "buttonNewTask";
            this.buttonNewTask.Size = new System.Drawing.Size(133, 28);
            this.buttonNewTask.TabIndex = 39;
            this.buttonNewTask.Text = "добавить";
            this.buttonNewTask.UseVisualStyleBackColor = true;
            this.buttonNewTask.Click += new System.EventHandler(this.buttonNewTask_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 329);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 79);
            this.label3.TabIndex = 36;
            this.label3.Text = "дата \r\nокончания";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(549, 119);
            this.label2.TabIndex = 35;
            this.label2.Text = "Общая задача";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 44);
            this.label1.TabIndex = 47;
            this.label1.Text = "группа:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // group
            // 
            this.group.Location = new System.Drawing.Point(346, 288);
            this.group.Margin = new System.Windows.Forms.Padding(4);
            this.group.Multiline = true;
            this.group.Name = "group";
            this.group.ReadOnly = true;
            this.group.Size = new System.Drawing.Size(57, 21);
            this.group.TabIndex = 48;
            // 
            // closeTeamTask
            // 
            this.closeTeamTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeTeamTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeTeamTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.closeTeamTask.Location = new System.Drawing.Point(499, 9);
            this.closeTeamTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeTeamTask.Name = "closeTeamTask";
            this.closeTeamTask.Size = new System.Drawing.Size(29, 28);
            this.closeTeamTask.TabIndex = 49;
            this.closeTeamTask.Text = "х";
            this.closeTeamTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeTeamTask.Click += new System.EventHandler(this.closeTeamTask_Click);
            // 
            // dateTimePicker_to_solve
            // 
            this.dateTimePicker_to_solve.Location = new System.Drawing.Point(205, 361);
            this.dateTimePicker_to_solve.Name = "dateTimePicker_to_solve";
            this.dateTimePicker_to_solve.Size = new System.Drawing.Size(181, 22);
            this.dateTimePicker_to_solve.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 285);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 39;
            this.button1.Text = "выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddTeamTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(549, 501);
            this.Controls.Add(this.dateTimePicker_to_solve);
            this.Controls.Add(this.closeTeamTask);
            this.Controls.Add(this.group);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTask);
            this.Controls.Add(this.distribution);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonNewTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTeamTask";
            this.Text = "AddTeamTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameTask;
        private System.Windows.Forms.TextBox distribution;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonNewTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox group;
        private System.Windows.Forms.Label closeTeamTask;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to_solve;
        private System.Windows.Forms.Button button1;
    }
}