using Npgsql;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            CenterToScreen();

            userNameField.Text = "Введите имя...";
            userNameField.ForeColor = Color.Gray;

            userSurnameField.Text = "Введите фамилию...";
            userSurnameField.ForeColor = Color.Gray;

            loginField.Text = "Придумайте логин...";
            loginField.ForeColor = Color.Gray;
        }

        private void closeButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя...")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя...";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию...")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите фамилию...";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Придумайте логин...")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Придумайте логин...";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя..." || userNameField.Text == string.Empty)
            {
                MessageBox.Show("Введите имя!");
                return;
            }

            if (userSurnameField.Text == "Введите фамилию..." || userSurnameField.Text == string.Empty)
            {
                MessageBox.Show("Введите фамилию!");
                return;
            }

            if (loginField.Text == "Придумайте логин..." || loginField.Text == string.Empty)
            {
                MessageBox.Show("Придумайте логин!");
                return;
            }

            if (passField.Text == "Придумайте пароль..." || passField.Text == string.Empty)
            {
                MessageBox.Show("Придумайте пароль!");
                return;
            }

            if (passConfirmField.Text == "Подтвердите пароль..." || passConfirmField.Text == string.Empty)
            {
                MessageBox.Show("Подтвердите пароль!");
                return;
            }

            if (passField.Text != passConfirmField.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }

            if (isUserExists())
            {
                MessageBox.Show("OK");
                return;
            }


            NpgsqlConnection connection = DB.GetConnection();
            NpgsqlCommand command = connection.CreateCommand();
            command.CommandText = $"INSERT INTO userr(name, surname, login, password) VALUES ('{userNameField.Text}', '{userSurnameField.Text}', '{loginField.Text}', '{passField.Text}')";
            try
            {
                connection.Open();
                if (command.ExecuteNonQuery() != -1)
                {
                    Hide();
                    TaskManagerForm taskManagerForm = new TaskManagerForm(loginField.Text);
                    taskManagerForm.Show();
                }
                else
                {
                    MessageBox.Show("Аккаунт с таким логином уже зарегистрирован!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally { connection.Close(); }
        }

        public bool isUserExists()
        {
            NpgsqlConnection connection = DB.GetConnection();
            NpgsqlCommand command = connection.CreateCommand();

            command.CommandText = $"SELECT EXISTS(SELECT * from userr WHERE login = '{loginField.Text}')";

            try
            {
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.Read() && reader.GetBoolean(0) == true)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует, введите другой!");
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return true;
            }
            finally { connection.Close(); }
        }

        private void avtorizationLabel_Click(object sender, EventArgs e)
        {
            Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
