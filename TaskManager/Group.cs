using Npgsql;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class Group : Form
    {
        public Group()
        {
            InitializeComponent();
            CenterToScreen();
            LoadGroups();
            LoadUsers();
        }

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
            Application.Exit();
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

        //  Создание новой группы
        private void button1_Click(object sender, EventArgs e)
        {
            if (nameGroup.Text == string.Empty)
            {
                MessageBox.Show("Введите название группы!");
                return;
            }


            NpgsqlConnection connection = DB.GetConnection();
            NpgsqlCommand command = connection.CreateCommand();
            command.CommandText = $"INSERT INTO groupp(group_name) VALUES ('{nameGroup.Text}')";

            try
            {
                connection.Open();

                if (command.ExecuteNonQuery() != -1)
                {
                    command.CommandText = $"INSERT INTO group_list(group_id, user_name) VALUES ((SELECT groupp_id FROM groupp WHERE group_name = '{nameGroup.Text}'), '{TaskManagerForm.Login}')";

                    if (command.ExecuteNonQuery() != -1)
                    {
                        LoadGroups();
                        LoadUsers();
                    }
                    else
                    {
                        MessageBox.Show("Такая группа уже есть");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Такая группа уже есть!");
            }
            finally { connection.Close(); }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (groupFiled.Text == string.Empty)
            {
                MessageBox.Show("Введите группу!");
                return;
            }
            else if (userField.Text == string.Empty)
            {
                MessageBox.Show("Введите логин пользователя!");
                return;
            }

            NpgsqlConnection connection = DB.GetConnection();
            NpgsqlCommand command = connection.CreateCommand();

            try
            {
                connection.Open();

                command.CommandText = $"SELECT COUNT(*) FROM groupp WHERE groupp_id = {int.Parse(groupFiled.Text)}";
                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.Read() && reader.GetInt32(0) == 0)
                {
                    MessageBox.Show("Такой группы не существует!");
                    return;
                }
                reader.Close();

                command.CommandText = $"SELECT COUNT(*) FROM userr WHERE login = '{userField.Text}'";
                reader = command.ExecuteReader();

                if (reader.Read() && reader.GetInt32(0) == 0)
                {
                    MessageBox.Show("Такого пользователя не существует!");
                    return;
                }
                reader.Close();

                command.CommandText = $"DELETE from group_list WHERE user_name = '{userField.Text}' AND group_id = {int.Parse(groupFiled.Text)}";

                if (command.ExecuteNonQuery() == -1)
                {
                    MessageBox.Show("Такой группы или пользователя не существует!");
                }
                else
                {
                    LoadGroups();
                    LoadUsers();
                    MessageBox.Show("Пользователь успешно удален!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (groupFiled.Text == string.Empty)
            {
                MessageBox.Show("Введите группу!");
                return;
            }
            else if (userField.Text == string.Empty)
            {
                MessageBox.Show("Введите логин пользователя!");
                return;
            }

            NpgsqlConnection connection = DB.GetConnection();
            NpgsqlCommand command = connection.CreateCommand();

            try
            {
                connection.Open();

                command.CommandText = $"SELECT COUNT(*) FROM userr where login = '{userField.Text}';";

                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.Read() == false)
                {
                    MessageBox.Show("Пользователь не существует!");
                    return;
                }
                else
                {
                    if (reader.GetInt32(0) == 0)
                    {
                        MessageBox.Show("Пользователь не существует!");
                        return;
                    }
                    reader.Close();
                    command.CommandText = $"SELECT COUNT(*) FROM group_list WHERE group_id = {int.Parse(groupFiled.Text)} AND user_name = '{userField.Text}'";
                    reader = command.ExecuteReader();

                    if (reader.Read() == true && reader.GetInt32(0) != 0)
                    {
                        MessageBox.Show("Пользователь уже есть в группе!");
                        return;
                    }
                    else
                    {
                        reader.Close();
                        command.CommandText = $"SELECT COUNT(*) FROM groupp WHERE groupp_id = {int.Parse(groupFiled.Text)}";
                        reader = command.ExecuteReader();

                        if (reader.Read() && reader.GetInt32(0) == 0)
                        {
                            MessageBox.Show("Такой группы нет!");
                            return;
                        }
                        reader.Close();

                        command.CommandText = $"INSERT INTO group_list(group_id, user_name) VALUES ({int.Parse(groupFiled.Text)}, '{userField.Text}')";
                        if (command.ExecuteNonQuery() == -1)
                        {
                            MessageBox.Show("Ошибка данных!");
                            return;
                        }
                        else
                        {
                            LoadGroups();
                            LoadUsers();
                            MessageBox.Show("Пользователь добавлен!");
                        }
                    }
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
