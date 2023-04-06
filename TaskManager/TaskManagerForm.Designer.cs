namespace Task_Manager
{
    partial class TaskManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TaskButton = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.TeamButton = new System.Windows.Forms.PictureBox();
            this.ArchiveButton = new System.Windows.Forms.PictureBox();
            this.UserButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonAddTask);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.TaskButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.TeamButton);
            this.panel1.Controls.Add(this.ArchiveButton);
            this.panel1.Controls.Add(this.UserButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 671);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(220, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Пример";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(125, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 44);
            this.label6.TabIndex = 13;
            this.label6.Text = "Логин:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(794, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Личные задачи";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(917, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выбрать группу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(1052, 171);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(109, 44);
            this.buttonAddTask.TabIndex = 1;
            this.buttonAddTask.Text = "Новая задача";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(131, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 374);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TaskButton
            // 
            this.TaskButton.BackColor = System.Drawing.Color.Snow;
            this.TaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaskButton.Image = ((System.Drawing.Image)(resources.GetObject("TaskButton.Image")));
            this.TaskButton.Location = new System.Drawing.Point(600, 33);
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(51, 51);
            this.TaskButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TaskButton.TabIndex = 5;
            this.TaskButton.TabStop = false;
            this.TaskButton.Click += new System.EventHandler(this.TaskButton_Click);
            this.TaskButton.MouseEnter += new System.EventHandler(this.TaskButton_MouseEnter);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Snow;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(1176, 33);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(51, 51);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton.TabIndex = 4;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            // 
            // TeamButton
            // 
            this.TeamButton.BackColor = System.Drawing.Color.Snow;
            this.TeamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeamButton.Image = ((System.Drawing.Image)(resources.GetObject("TeamButton.Image")));
            this.TeamButton.Location = new System.Drawing.Point(875, 33);
            this.TeamButton.Name = "TeamButton";
            this.TeamButton.Size = new System.Drawing.Size(51, 51);
            this.TeamButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TeamButton.TabIndex = 3;
            this.TeamButton.TabStop = false;
            this.TeamButton.Click += new System.EventHandler(this.TeamButton_Click);
            this.TeamButton.MouseEnter += new System.EventHandler(this.TeamButton_MouseEnter);
            // 
            // ArchiveButton
            // 
            this.ArchiveButton.BackColor = System.Drawing.Color.Snow;
            this.ArchiveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ArchiveButton.Image = ((System.Drawing.Image)(resources.GetObject("ArchiveButton.Image")));
            this.ArchiveButton.Location = new System.Drawing.Point(334, 33);
            this.ArchiveButton.Name = "ArchiveButton";
            this.ArchiveButton.Size = new System.Drawing.Size(51, 51);
            this.ArchiveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ArchiveButton.TabIndex = 2;
            this.ArchiveButton.TabStop = false;
            this.ArchiveButton.Click += new System.EventHandler(this.ArchiveButton_Click);
            this.ArchiveButton.MouseEnter += new System.EventHandler(this.ArchiveButton_MouseEnter);
            // 
            // UserButton
            // 
            this.UserButton.BackColor = System.Drawing.Color.Snow;
            this.UserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserButton.Image = ((System.Drawing.Image)(resources.GetObject("UserButton.Image")));
            this.UserButton.Location = new System.Drawing.Point(52, 33);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(51, 51);
            this.UserButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserButton.TabIndex = 1;
            this.UserButton.TabStop = false;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            this.UserButton.MouseEnter += new System.EventHandler(this.UserButton_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1279, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TaskManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1278, 671);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskManagerForm";
            this.Load += new System.EventHandler(this.TaskManagerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox TaskButton;
        private System.Windows.Forms.PictureBox ExitButton;
        private System.Windows.Forms.PictureBox TeamButton;
        private System.Windows.Forms.PictureBox ArchiveButton;
        private System.Windows.Forms.PictureBox UserButton;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}