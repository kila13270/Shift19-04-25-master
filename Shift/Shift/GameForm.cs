using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        public GameForm()
        {
            InitializeComponent();
            pictureBox2.Load($"D:\\\\Progs\\ProjectAAAAAAAAAAAAAAAA\\Shift\\Shift\\Picture\\GameIcon\\{counter}.JPG");
            timer.Interval = 1000;
            timer.Start();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            string[] gameFiles = Directory.GetFiles(lastDownloadedPath, "ХОРРОР ПРЕКОЛ.exe", SearchOption.AllDirectories);
            if (gameFiles.Length > 0)
            {
                string foundPath = gameFiles[0];

                try
                {
                    // Запускаем EXE-файл напрямую
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = foundPath,
                        UseShellExecute = true,
                        WorkingDirectory = Path.GetDirectoryName(foundPath)
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось запустить игру: {ex.Message}",
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                    try
                    {
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
                            MessageBox.Show("Файл успешно скачан!", "Успех",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DownloadButton.Visible = false;

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка при скачивании файла");
                    }
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
                counter = 10;
            }
            pictureBox2.Load($"D:\\\\Progs\\ProjectAAAAAAAAAAAAAAAA\\Shift\\Shift\\Picture\\GameIcon\\{counter}.JPG");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter > 10)
            {
                counter = 1;
            }
            pictureBox2.Load($"D:\\\\Progs\\ProjectAAAAAAAAAAAAAAAA\\Shift\\Shift\\Picture\\GameIcon\\{counter}.JPG");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > 10)
            {
                counter = 1;
            }
            pictureBox2.Load($"D:\\\\Progs\\ProjectAAAAAAAAAAAAAAAA\\Shift\\Shift\\Picture\\GameIcon\\{counter}.JPG");
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
