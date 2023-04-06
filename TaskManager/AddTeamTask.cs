using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class AddTeamTask : Form
    {
        DataGridView Grid { get; set; }
        public AddTeamTask(DataGridView grid)
        {
            InitializeComponent();
            Grid = grid;
            CenterToScreen();
        }

        private void closeTeamTask_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataGridView GetDataGridView()
        {
            TaskManagerForm.RefreshDataGrid(Grid);
            return Grid;
        }

        private void buttonNewTask_Click(object sender, EventArgs e)
        {
            if (nameTask.Text == string.Empty)
            {
                MessageBox.Show("Добавьте название задачи!");
                return;
            }
            else if (distribution.Text == string.Empty)
            {
                MessageBox.Show("Добавьте описание задачи!");
                return;
            }
            else if (dateTimePicker_to_solve.Text == string.Empty)
            {
                MessageBox.Show("Добавьте дату решения задачи!");
                return;
            }

            NpgsqlConnection connection = DB.GetConnection();
            NpgsqlCommand command = connection.CreateCommand();
            command.CommandText = $"INSERT INTO task(namee, description, property, groupp, date_to_solve, user_create)" +
                $"VALUES ('{nameTask.Text}', '{distribution.Text}', 'Общее', {int.Parse(group.Text)}, '{dateTimePicker_to_solve.Value.ToUniversalTime()}', '{TaskManagerForm.Login}')";

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

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseGroup choosegroup = new ChooseGroup();
            choosegroup.ShowDialog();
            group.Text = choosegroup.choosedGroup().ToString();
            choosegroup.Close();
        }
    }
}
