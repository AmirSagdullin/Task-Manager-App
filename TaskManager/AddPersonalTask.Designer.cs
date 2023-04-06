namespace Task_Manager
{
    partial class AddPersonalTask
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
            this.avtorizationLabel = new System.Windows.Forms.Label();
            this.closePersonalTask = new System.Windows.Forms.Label();
            this.nameTask = new System.Windows.Forms.TextBox();
            this.distribution = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonNewTask = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_to_solve = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // avtorizationLabel
            // 
            this.avtorizationLabel.AutoSize = true;
            this.avtorizationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avtorizationLabel.Location = new System.Drawing.Point(6, 539);
            this.avtorizationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.avtorizationLabel.Name = "avtorizationLabel";
            this.avtorizationLabel.Size = new System.Drawing.Size(0, 16);
            this.avtorizationLabel.TabIndex = 32;
            // 
            // closePersonalTask
            // 
            this.closePersonalTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePersonalTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closePersonalTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.closePersonalTask.Location = new System.Drawing.Point(536, 8);
            this.closePersonalTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closePersonalTask.Name = "closePersonalTask";
            this.closePersonalTask.Size = new System.Drawing.Size(29, 28);
            this.closePersonalTask.TabIndex = 31;
            this.closePersonalTask.Text = "х";
            this.closePersonalTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closePersonalTask.Click += new System.EventHandler(this.closePersonalTask_Click);
            // 
            // nameTask
            // 
            this.nameTask.Location = new System.Drawing.Point(205, 136);
            this.nameTask.Margin = new System.Windows.Forms.Padding(4);
            this.nameTask.Multiline = true;
            this.nameTask.Name = "nameTask";
            this.nameTask.Size = new System.Drawing.Size(323, 21);
            this.nameTask.TabIndex = 30;
            // 
            // distribution
            // 
            this.distribution.Location = new System.Drawing.Point(205, 186);
            this.distribution.Margin = new System.Windows.Forms.Padding(4);
            this.distribution.Multiline = true;
            this.distribution.Name = "distribution";
            this.distribution.Size = new System.Drawing.Size(323, 74);
            this.distribution.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 44);
            this.label7.TabIndex = 28;
            this.label7.Text = "описание:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 62);
            this.label6.TabIndex = 27;
            this.label6.Text = "название \r\nзадачи:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonNewTask
            // 
            this.buttonNewTask.Location = new System.Drawing.Point(395, 371);
            this.buttonNewTask.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNewTask.Name = "buttonNewTask";
            this.buttonNewTask.Size = new System.Drawing.Size(133, 28);
            this.buttonNewTask.TabIndex = 23;
            this.buttonNewTask.Text = "добавить";
            this.buttonNewTask.UseVisualStyleBackColor = true;
            this.buttonNewTask.Click += new System.EventHandler(this.buttonNewTask_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 79);
            this.label3.TabIndex = 19;
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
            this.label2.Size = new System.Drawing.Size(566, 119);
            this.label2.TabIndex = 18;
            this.label2.Text = "Личная задача";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_to_solve
            // 
            this.dateTimePicker_to_solve.Location = new System.Drawing.Point(205, 312);
            this.dateTimePicker_to_solve.Name = "dateTimePicker_to_solve";
            this.dateTimePicker_to_solve.Size = new System.Drawing.Size(181, 22);
            this.dateTimePicker_to_solve.TabIndex = 35;
            // 
            // AddPersonalTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(566, 433);
            this.Controls.Add(this.dateTimePicker_to_solve);
            this.Controls.Add(this.avtorizationLabel);
            this.Controls.Add(this.closePersonalTask);
            this.Controls.Add(this.nameTask);
            this.Controls.Add(this.distribution);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonNewTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPersonalTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPersonalTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label avtorizationLabel;
        private System.Windows.Forms.Label closePersonalTask;
        private System.Windows.Forms.TextBox nameTask;
        private System.Windows.Forms.TextBox distribution;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonNewTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to_solve;
    }
}