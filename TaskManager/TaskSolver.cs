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
    public partial class TaskSolve : Form
    {
        public TaskSolve(int task_id)
        {
            InitializeComponent();
            CenterToParent();
            this.task_id = task_id;
        }

        private int task_id;

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TaskSolve_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["Comment"].DefaultCellStyle.BackColor = Color.Green;
            RefreshDataGrid(dataGridView1);
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            NpgsqlConnection connection = DB.GetConnection();
            NpgsqlCommand command = connection.CreateCommand();

            command.CommandText = $"SELECT * from task WHERE task_id = {task_id}";

            try
            {
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ReadSingleRow(dgw, reader);
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

        static private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            string group_str;
            int group_int = record.GetInt32(4);

            if (group_int == -1)
            {
                group_str = "Нет";
            }
            else
            {
                group_str = group_int.ToString();
            }

            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3),
                group_str, record.GetString(5), record.GetString(6), record.GetString(7),
                record.GetString(8), record.GetString(9));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comment = dataGridView1.Rows[0].Cells[7].Value.ToString();
            string date_solved = DateTime.UtcNow.ToString();
            string solver = TaskManagerForm.Login;

            if (comment == string.Empty)
            {
                MessageBox.Show("Напишите комментарий или напишите \"Нет\".");
                return;
            }

            NpgsqlConnection connection = DB.GetConnection();
            NpgsqlCommand command = connection.CreateCommand();

            command.CommandText = $"UPDATE task SET commentt = '{comment}', date_solved = '{date_solved}', solver = '{solver}' WHERE task_id = {task_id}";

            try
            {
                connection.Open();
                
                if (command.ExecuteNonQuery() == -1)
                {
                    MessageBox.Show("Произошла ошибка, некорректные данные!");
                } else
                {
                    MessageBox.Show("Задача успешно решена!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            Close();
        }
    }
}
