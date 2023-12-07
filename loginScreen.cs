using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvitoClone
{
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        private void loginScreen_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String userLogin = loginField.Text;
            String userPassword = passField.Text;

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPassword;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь найден");
            }
            else
            {
                MessageBox.Show("Пользователь не зарегистрирован");
            }
        }

        Point lastPoint;

        private void loginScreen_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void loginScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (registerLoginField.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (registerPassField.Text == "")
            {
                MessageBox.Show("Введите парель");
                return;
            }

            if (registerNumberField.Text == "")
            {
                MessageBox.Show("Введите номер телефона");
                return;
            }

            if (IsUserExist())
            {
                return;
            }

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `number`) VALUES (@uL, @uP, @uN)", db.getConnection());

            if (!registerPassField.Text.Equals(registerRepeatPassField.Text))
            {
                MessageBox.Show("Пароль не совпадает");
                return;
            }
            else
            {
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = registerLoginField.Text;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = registerPassField.Text;
                command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = registerNumberField.Text;
            }

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан");
            }
            else
            {
                MessageBox.Show("Аккаунт не был создан");
            }

            db.closeConnection();

        }

        public Boolean IsUserExist()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = registerLoginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже зарегистрирован");
                return true;
            }
            else
            { 
                return false;
            }
        }
    }
}
