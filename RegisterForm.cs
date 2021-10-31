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

namespace LaunhcerForMinecraft
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            LoginField.Text = "Введите логин";
            LoginField.ForeColor = Color.Gray;

            PassField.Text = "Введите пароль";
            PassField.ForeColor = Color.Gray;

            PlayerName.Text = "Введите имя персонажа";
            PlayerName.ForeColor = Color.Gray;
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите логин")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Gray;
            }
            else if (LoginField.Text != "Введите логин")
            {
                LoginField.ForeColor = Color.Black;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                LoginField.Text = "Введите логин";
                LoginField.ForeColor = Color.Gray;
            }
            else if (LoginField.Text != "")
            {
                LoginField.ForeColor = Color.Black;
            }
        }

        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "Введите пароль")
            {
                PassField.ForeColor = Color.Gray;
                PassField.Text = "";
            }
            else if (PassField.Text != "Введите логин")
            {
                PassField.ForeColor = Color.Black;
            }
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == "")
            {
                PassField.Text = "Введите пароль";
                PassField.ForeColor = Color.Gray;
            }
            else if (PassField.Text != "")
            {
                PassField.ForeColor = Color.Black;
            }
        }

        private void PlayerName_Enter(object sender, EventArgs e)
        {
            if (PlayerName.Text == "Введите имя персонажа")
            {
                PlayerName.Text = "";
                PlayerName.ForeColor = Color.Gray;
            }
            else if (PlayerName.Text != "Введите имя персонажа")
            {
                PlayerName.ForeColor = Color.Black;
            }
        }

        private void PlayerName_Leave(object sender, EventArgs e)
        {
            if (PlayerName.Text == "")
            {
                PlayerName.Text = "Введите имя персонажа";
                PlayerName.ForeColor = Color.Gray;
            }
            else if (PlayerName.Text != "")
            {
                PlayerName.ForeColor = Color.Black;
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            string playerName = PlayerName.Text;
            string loginUser = LoginField.Text;
            string passUser = PassField.Text;

            if (LoginField.Text == "" || PassField.Text == "")
            {
                MessageBox.Show("All field must be fill");

            }


            if (isUserExists())
            {
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Users` (`login`, `password`) VALUES (@login, @password);", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passUser;
            
            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Your account has been created");
            }
            else
            {
                MessageBox.Show("Your account has not been created");
            }



            db.closeConnection();
        }
        public Boolean isUserExists()
        {

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Users WHERE login = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This login are be registrated");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }
    }
}
