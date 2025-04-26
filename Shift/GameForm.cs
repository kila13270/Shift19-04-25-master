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

namespace Shift
{
    public partial class GameForm : Form
    {
        int counter = 1;
        private string lastDownloadedPath;
        private string path = $"{System.IO.Directory.GetCurrentDirectory()}";

        public GameForm()
        {
            InitializeComponent();
            pictureBox2.Load($"{path}\\Picture\\GameIcon\\{counter}.JPG");
            timer.Interval = 1000;
            timer.Start();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Process.Start($"{path}\\Game-for-test-my-program-main\\prikoldesy\\ХОРРОР ПРЕКОЛ.exe");
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            string fileUrl = "https://github.com/kila13270/Game-for-test-my-program/archive/refs/heads/main.zip";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string fileName = Path.GetFileName(fileUrl);
            saveFileDialog.FileName = fileName;//сканирует скаченный файл что бы найти его имя и сохраняет его
            using (WebClient client = new WebClient())//дает возможность качать файлы с инета
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    client.DownloadProgressChanged += (s, ev) =>
                    {
                        progressBar.Value = ev.ProgressPercentage;//обращаемся к webclien и демонстрируем этап загрузки
                    };
                    client.DownloadFileAsync(new Uri(fileUrl), saveFileDialog.FileName);//сама загрузка

                    while (client.IsBusy)
                    {
                        Application.DoEvents();//ожидание завершения, с обеспечением стабтльной работы во время загрузки
                    }
                    lastDownloadedPath = Path.GetDirectoryName(saveFileDialog.FileName);
                    string extractPath = Path.Combine(lastDownloadedPath, $"{System.IO.Directory.GetCurrentDirectory()}");
                    //ronZipArchive.ExtractArchiveToDirectory(saveFileDialog.FileName, extractPath);
                    File.Delete(saveFileDialog.FileName);

                    DownloadButton.Visible = false;
                }
        }
   

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            counter--;
            if (counter <= 0)
            {
                counter = 3;
            }
            pictureBox2.Load($"{path}\\Picture\\GameIcon\\{counter}.JPG");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter > 3)
            {
                counter = 1;
            }
            pictureBox2.Load($"{path}\\Picture\\GameIcon\\{counter}.JPG");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > 3)
            {
                counter = 1;
            }
            pictureBox2.Load($"{path}\\Picture\\GameIcon\\{counter}.JPG");
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
        Point lastPoint;

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var dir = Directory.GetCurrentDirectory() + "\\Picture\\1.jpg";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
