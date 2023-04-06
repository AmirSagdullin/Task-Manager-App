using Npgsql;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_Manager
{

    public partial class ChooseGroup : Form
    {

        public ChooseGroup()
        {
            InitializeComponent();
            CenterToParent();
            LoadGroups();
            LoadUsers();
        }

        int choosed_group = -1;

        private void LoadGroups()
        {
            dataGridView1.Rows.Clear();

            NpgsqlConnection connection = DB.GetConnection();
            NpgsqlCommand command = connection.CreateCommand();
            command.CommandText = $"SELECT r.* FROM groupp r LEFT JOIN group_list l ON r.groupp_id = l.group_id WHERE l.user_name = '{TaskManagerForm.Login}'";

            try
            {
                connection.Open();

                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }

        }

        private void LoadUsers()
        {
            dataGridView2.Rows.Clear();

            NpgsqlConnection connection = DB.GetConnection();
            NpgsqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT login FROM userr";

            try
            {
                connection.Open();

                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader.GetString(0));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
        }


        private void closeButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                choosed_group = (int)dataGridView1[0, e.RowIndex].Value;

                NpgsqlConnection connection = DB.GetConnection();
                NpgsqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT user_name from group_list WHERE group_id = {dataGridView1[0, e.RowIndex].Value}";

                try
                {
                    connection.Open();

                    NpgsqlDataReader reader = command.ExecuteReader();

                    dataGridView2.Rows.Clear();

                    while (reader.Read())
                    {
                        dataGridView2.Rows.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { connection.Close(); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public int choosedGroup()
        {
            return choosed_group;
        }
    }
}
