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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoginField.Text = "Введите логин";
            LoginField.ForeColor = Color.Gray;

            PassField.Text = "Введите пароль";
            PassField.ForeColor = Color.Gray;

            
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

        private void RegistrationLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            String loginUser = LoginField.Text;
            String PassUser = PassField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `Users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Enter");
                
            }
            else
            {
                MessageBox.Show("Неверный логин, или пароль");

            }

        }
        private void DiskordLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/Rbzp7u3p5S");
        }

        private void VKLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/tavern.between.worlds");
        }

        private void YouTubeLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCivsDc7UxKgL49Epc-LmM8Q");
        }

        private void CivitatumTeamLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/civitatum.team");
        }

        private void SettingsBox_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }
    }
}
