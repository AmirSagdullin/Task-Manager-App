namespace Task_Manager
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
            this.PersonalTaskButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TeamTaskbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PersonalTaskButton
            // 
            this.PersonalTaskButton.BackColor = System.Drawing.Color.Snow;
            this.PersonalTaskButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.PersonalTaskButton.Location = new System.Drawing.Point(71, 49);
            this.PersonalTaskButton.Name = "PersonalTaskButton";
            this.PersonalTaskButton.Size = new System.Drawing.Size(233, 36);
            this.PersonalTaskButton.TabIndex = 10;
            this.PersonalTaskButton.Text = "личная";
            this.PersonalTaskButton.UseVisualStyleBackColor = false;
            this.PersonalTaskButton.Click += new System.EventHandler(this.PersonalTaskButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "добавить задачу";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TeamTaskbutton
            // 
            this.TeamTaskbutton.BackColor = System.Drawing.Color.Snow;
            this.TeamTaskbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.TeamTaskbutton.Location = new System.Drawing.Point(71, 94);
            this.TeamTaskbutton.Name = "TeamTaskbutton";
            this.TeamTaskbutton.Size = new System.Drawing.Size(233, 36);
            this.TeamTaskbutton.TabIndex = 11;
            this.TeamTaskbutton.Text = "общая";
            this.TeamTaskbutton.UseVisualStyleBackColor = false;
            this.TeamTaskbutton.Click += new System.EventHandler(this.TeamTaskbutton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.label3.Location = new System.Drawing.Point(337, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "х";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(359, 142);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TeamTaskbutton);
            this.Controls.Add(this.PersonalTaskButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTask";
            this.Text = "AddTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PersonalTaskButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TeamTaskbutton;
        private System.Windows.Forms.Label label3;
    }
}