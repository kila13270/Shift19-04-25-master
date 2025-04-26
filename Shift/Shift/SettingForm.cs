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
    public partial class SettingForm : Form
    {
        private User currentUser;
        private string avatarsFolder = "Avatars";
        public SettingForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowseAvatar_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                Title = "Выберите аватарку"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Сохраняем путь к файлу или конвертируем изображение в Base64
                currentUser.Avatar = openFileDialog.FileName;
                // Дополнительно: отображение выбранной аватарки в PictureBox
                pictureBoxAvatar.ImageLocation = openFileDialog.FileName;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
