using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using Newtonsoft.Json;

namespace Shift
{

    public partial class LoginForm : Form
    {
        private string filePath = "users.json";
        public class User
        {
            public string Login { get; set; }
            public string Password { get; set; }
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;


        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string videoPath = @"D:\Progs\ProjectAAAAAAAAAAAAAAAA\Shift\Shift\Picture\Animation.mp4";
            string login = UserText.Text;
            string password = PassLogin.Text;

            if (File.Exists(filePath)) // Проверка на существование пользователя в файле
            {
                string json = File.ReadAllText(filePath);
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
                User user = users.Find(u => u.Login == login);

                if (user != null)
                {
                    // Если пользователь найден, проверяем пароль
                    if (VerifyPassword(password, user.Password))
                    {
                        panelVideo.Visible = true;
                        panelVideo.BringToFront();
                        axWindowsMediaPlayer1.URL = videoPath;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        timer1.Interval = 4000; 
                        timer1.Start();
                       
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль.");
                    }
                }
            }
        }
        private bool VerifyPassword(object password1, string password2)
        {
            throw new NotImplementedException();
        }


        private bool VerifyPassword(string enteredPassword, string storedPassword)
        {
            string hashedPassword = HashPassword(enteredPassword);
            return hashedPassword == storedPassword;
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
        private void SwitchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
