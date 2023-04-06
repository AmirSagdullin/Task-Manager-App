using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace Task_Manager
{
    public partial class TaskManagerForm : Form
    {
        static public string Login { get; set; }

        static private int choosed_group = -1;

        public TaskManagerForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void closeButton1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        public TaskManagerForm(string login)
        {
            InitializeComponent();
            CenterToScreen();
            Login = login;
            label1.Text = login;
        }
        private void TaskManagerForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите завершить сеанс?", "Выход",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                choosed_group = -1;
                Login = null;
                Application.Exit();
            }
        }

        private void UserButton_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(UserButton, "Другой аккаунт");

        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            Login = null;
            choosed_group = -1;
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            Close();
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(ExitButton, "Выход");
        }

        private void ArchiveButton_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(ArchiveButton, "Архив");
        }

        private void TaskButton_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            buttonAddTask.Visible = true;

            RefreshDataGrid(dataGridView1);
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void TaskButton_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(TaskButton, "Задачи");
        }

        private void TeamButton_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(TeamButton, "Команды");
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "Номер задачи");
            dataGridView1.Columns.Add("name", "Название задачи");
            dataGridView1.Columns.Add("description", "Описание");
            dataGridView1.Columns.Add("property", "Тип");
            dataGridView1.Columns.Add("group", "Группа");
            dataGridView1.Columns.Add("date_to_solve", "Время, до какого числа необходимо выплнить дело");
            dataGridView1.Columns.Add("user_create", "Кто составил");
            dataGridView1.Columns.Add("comment", "Комментарий");
            dataGridView1.Columns.Add("date_solved", "Дата решения");
            dataGridView1.Columns.Add("solver", "Кто решил");
        }

        static private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            string group_str;
            int group_int = record.GetInt32(4);

            if (group_int == -1)
            {
                group_str = "Нет";
            } else
            {
                group_str = group_int.ToString();
            }

            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3),
                group_str, record.GetString(5), record.GetString(6), record.GetString(7), 
                record.GetString(8), record.GetString(9));
        }

        static public void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            NpgsqlConnection connection = DB.GetConnection();
            NpgsqlCommand command = connection.CreateCommand();

            if (choosed_group == -1)
            {
                command.CommandText = $"SELECT * FROM task WHERE user_create = '{Login}' AND solver = 'Нет'";
            } else
            {
                command.CommandText = $"SELECT * FROM task WHERE groupp = {choosed_group} AND solver = 'Нет'";
            }

            try
            {
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ReadSingleRow(dgw, reader);
                }
                reader.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                connection.Close();
            }

            choosed_group = -1;
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask(dataGridView1);
            addTask.ShowDialog();
            dataGridView1 = addTask.GetDataGridView();
        }

        private void TeamButton_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            group.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GroupTasksChoose groupTasks = new GroupTasksChoose();
            groupTasks.ShowDialog();
            choosed_group = groupTasks.GetGroup();
            groupTasks.Close();
            dataGridView1.Rows.Clear();
            RefreshDataGrid(dataGridView1);
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            NpgsqlConnection connection = DB.GetConnection();
            NpgsqlCommand command = connection.CreateCommand();

            command.CommandText = $"SELECT * from task WHERE (user_create = '{Login}' OR groupp = {choosed_group}) AND solver = 'Нет'";

            try
            {
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ReadSingleRow(dataGridView1, reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            NpgsqlConnection connection = DB.GetConnection();
            NpgsqlCommand command = connection.CreateCommand();

            command.CommandText = $"SELECT * from task WHERE user_create = '{Login}' AND groupp = -1 AND solver = 'Нет'";

            try
            {
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ReadSingleRow(dataGridView1, reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void ArchiveButton_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            buttonAddTask.Visible = false;

            dataGridView1.Rows.Clear();

            NpgsqlConnection connection = DB.GetConnection();
            NpgsqlCommand command = connection.CreateCommand();

            command.CommandText = $"SELECT r.* FROM task r LEFT JOIN group_list l ON r.groupp = l.group_id WHERE (l.user_name = '{Login}' AND r.date_solved <> 'Нет' AND r.solver <> 'Нет') OR (r.user_create = '{Login}' AND r.solver <> 'Нет')";

            try
            {
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ReadSingleRow(dataGridView1, reader);
                }
                reader.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1[9, e.RowIndex].Value.ToString() == "Нет")
                {
                int task_id = (int)dataGridView1[0, e.RowIndex].Value;
                TaskSolve taskSolve = new TaskSolve(task_id);
                taskSolve.ShowDialog();
                taskSolve.Close();

                RefreshDataGrid(dataGridView1);
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

            }
        }
    }
}
