using Npgsql;
using System;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class AddPersonalTask : Form
    {
        DataGridView Grid { get; set; }
        public AddPersonalTask(DataGridView grid)
        {
            InitializeComponent();
            CenterToScreen();
            Grid = grid;
        }

        public DataGridView GetDataGridView()
        {
            TaskManagerForm.RefreshDataGrid(Grid);
            return Grid;
        }

        private void closePersonalTask_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNewTask_Click(object sender, EventArgs e)
        {
            if (nameTask.Text == string.Empty)
            {
                MessageBox.Show("Добавьте название задачи!");
                return;
            } else if (distribution.Text == string.Empty)
            {
                MessageBox.Show("Добавьте описание задачи!");
                return;
            } else if (dateTimePicker_to_solve.Value.ToUniversalTime() < DateTime.UtcNow)
            {
                MessageBox.Show("Некорректная дата решения задачи!");
                return;
            }

            NpgsqlConnection connection = DB.GetConnection();
            NpgsqlCommand command = connection.CreateCommand();
            command.CommandText = $"INSERT INTO task(namee, description, property, date_to_solve, user_create) VALUES ('{nameTask.Text}', '{distribution.Text}', 'Личное', '{dateTimePicker_to_solve.Value.ToUniversalTime()}', '{TaskManagerForm.Login}')";

            try
            {
                connection.Open();

                if (command.ExecuteNonQuery() != -1)
                {
                    MessageBox.Show("Дело успешно добавлено!");
                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
        }

    }
}
