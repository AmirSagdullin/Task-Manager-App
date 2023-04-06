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
    public partial class GroupTasksChoose : Form
    {
        public GroupTasksChoose()
        {
            InitializeComponent();
            CenterToParent();
            LoadGroups();
        }

        int choosed_group = -1;

        private void LoadGroups()
        {
            dataGridView1.Rows.Clear();

            NpgsqlConnection connection = DB.GetConnection();
            NpgsqlCommand command = connection.CreateCommand();

            command.CommandText = $"SELECT r.* FROM groupp r INNER JOIN group_list l ON r.groupp_id = l.group_id WHERE l.user_name = '{TaskManagerForm.Login}'";

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

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public int GetGroup()
        {
            return choosed_group;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                choosed_group = (int)dataGridView1[0, e.RowIndex].Value;
            }
        }
    }
}
