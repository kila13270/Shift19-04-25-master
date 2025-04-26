using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shift
{
    public partial class HomeFormFull : Form
    {
        public HomeFormFull()
        {
            InitializeComponent();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StrecthButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeform = new HomeForm();
            homeform.Show();
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            GameForm gameform = new GameForm();
            gameform.Show();
        }

        private void FriendsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
