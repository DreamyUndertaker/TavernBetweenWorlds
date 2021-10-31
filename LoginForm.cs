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


    }
}
