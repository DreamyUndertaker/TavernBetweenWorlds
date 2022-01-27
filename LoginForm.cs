using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaunhcerForMinecraft
{
    public class YandexDisApiDownlad : Download
    { 
        
    }

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
            

            String loginUser = LoginField.Text;//логин
            String PassUser = PassField.Text;//праоль

            DB db = new DB();//место для бд
            DataTable table = new DataTable();//таблица пользователей
            MySqlDataAdapter adapter = new MySqlDataAdapter();//адпетр для sql запроса
            MySqlCommand command = new MySqlCommand("SELECT * FROM `Users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());//sql запрос

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            string curFile = @"C:\Users\vadii\AppData\Roaming\.minecraft\start.bat";
            string mods = @"C:\\Users\\vadii\\AppData\\Roaming\\.minecraft\\mods\\14.01.2022_mods.zip";

            DownloadMods();

            if (table.Rows.Count > 0)//проверка регистрации пользователя
            {
                MessageBox.Show("Enter");

                Process.Start(folderName + "TLauncher.exe");// запуск tlauncher

                //this.Close();
                if (!File.Exists(curFile))//проверка наличия батника сервера
                {
                    ServerInstaller();
                }

                if (!File.Exists(mods))//проверка наличия сборки модов 
                {
                    

                }

               /* if (File.Exists(mods))
                {
                    Unpacking();
                }*/

            }
            else if (table.Rows.Count < 0 || PassField.Text == "Введите пароль" || PassField.Text == "")
            {
                MessageBox.Show("Неверный логин, или пароль");

            }

        }

        private void ServerInstaller()//генератор батника
        {
            System.IO.File.WriteAllText("C:\\TestFile.bat", @"
            @echo off
            java -Xmx1024M -Xms1024M -jar mohist-1.12.2-221-server.jar nogui
            pause");
        }

        private void DownloadMods()//скачавание сборки модов
        {
            

            WebClient webClient = new WebClient();
            webClient.DownloadFile(new Uri ("ttps://docs.google.com/u/0/nonceSigner?nonce=a1672oam8vkki&continue=1aMUOGkmoWmYHjFQcHP7UIgyQCJ7ONL_0"), @"C:\Users\vadii\AppData\Roaming\.minecraft\mods\zip.zip");

            
        }

       /* private void Unpacking()//распаковка арзива с модами
        {
            

            string zipPath = folderName + @"\mods\14.01.2022_mods.zip";
            string extractPath = folderName + @"\mods\"; ;

            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }*/

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
            this.Hide();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();

        }
    }
}
