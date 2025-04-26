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
            string videoPath = @"D:\\\\Shift\\Shift\\Picture\\Animation.mp4";
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.FirstOrDefault(x => x.Login == UserText.Text && x.Password == PassLogin.Text);

                if (users == null)
                {
                    MessageBox.Show("Ошибка логина!");
                    return;
                }
                else
                panelVideo.Visible = true;
                panelVideo.BringToFront();
                axWindowsMediaPlayer1.URL = videoPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                timer1.Interval = 4000;
                timer1.Start();
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
