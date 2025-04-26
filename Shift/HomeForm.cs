using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Shift
{
    public partial class HomeForm : Form
    {

        public HomeForm()
        {
            InitializeComponent();

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void StrecthButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeFormFull homefull = new HomeFormFull();
            homefull.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void BrowserButton_Click(object sender, EventArgs e)
        {

        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameform = new GameForm();
            gameform.Show();
        }

        private void FriendsButton_Click(object sender, EventArgs e)
        {
            Process.Start($"{System.IO.Directory.GetCurrentDirectory()}\\ConsoleApp\\ConsoleApp\\bin\\Debug\\net8.0\\ConsoleApp.exe");
            FriendsForm friendform = new FriendsForm();
            friendform.Show();
        }
    }
}
