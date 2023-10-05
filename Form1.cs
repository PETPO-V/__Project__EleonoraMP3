using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace EleonoraMP3
{

    partial class mainWindow : Form
    {
        //Point start_point = new Point(0, 0);

        public ClsMp3 mp3 = new ClsMp3();
        public String[] paths, files;
        private readonly Stopwatch stopwatch = new Stopwatch();


        //public Point MouseHook;
        //bool drag = false;
        //bool btnoff = false;

        Timer timer = new Timer();
        int timerCounter = 0;

        public mainWindow()
        {
            InitializeComponent();
            timer.Interval = 1000; 
            timer.Tick += new EventHandler(timer_Tick); 

        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        ///SIDE_BAR_ZONE
        private void buttonWorkingZone_Click(object sender, EventArgs e)
        {
            centreWindow.SetPage(0);
            sideWindow.SetPage(tabPage3);
        }
        private void buttonExplorePoint_Click(object sender, EventArgs e)
        {
            centreWindow.SetPage(1);
            sideWindow.SetPage(tabPage4);
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            centreWindow.SetPage(2);
            sideWindow.SetPage(tabPage4);
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        ///BUTTONS_AND_SLIDERS_ZONE

        int buttonParameter = 0;
        private void buttonPlayWorkingZone_Click(object sender, EventArgs e)
        {
            if (buttonParameter == 0)
            {
                mp3.Open(paths[listBox1.SelectedIndex]);
                mp3.Play();
                timer.Start();
                stopwatch.Start();

                TagLib.File file = TagLib.File.Create(paths[listBox1.SelectedIndex]);
                songLabelCenter.Text = file.Tag.Title;
                label8.Text = file.Tag.Title;
                artistLabelCenter.Text = file.Tag.Album;
                label9.Text = file.Tag.Album;

                MemoryStream ms = new MemoryStream(file.Tag.Pictures[0].Data.Data);
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms);

                pictureBox1.Image = image;
                pictureBox2.Image = image;
            }
        }
        private void buttonNextWorkingZone_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
            {
                listBox1.SetSelected(listBox1.Items.Count - listBox1.Items.Count, true);
                listBox2.SetSelected(listBox1.Items.Count - listBox1.Items.Count, true);
            }
            else
            {
                listBox1.SetSelected(listBox1.SelectedIndex + 1, true);
                listBox2.SetSelected(listBox1.SelectedIndex , true);
                mp3.Close();

                stopwatch.Reset();

                timerCounter = 0;
                songTimer.Text = stopwatch.Elapsed.ToString("mm\\:ss");
                songTimerSide.Text = stopwatch.Elapsed.ToString("mm\\:ss");
                songSlider.Value = (timerCounter);
                songSliderSide.Value = (timerCounter);

                mp3.Open(paths[listBox1.SelectedIndex]);
                mp3.Play();

                timer.Start();
                stopwatch.Start();

                TagLib.File file = TagLib.File.Create(paths[listBox1.SelectedIndex]);
                songLabelCenter.Text = file.Tag.Title;
                artistLabelCenter.Text = file.Tag.Album;
                label8.Text = file.Tag.Title;
                label9.Text = file.Tag.Album;

                MemoryStream ms = new MemoryStream(file.Tag.Pictures[0].Data.Data);
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms);

                pictureBox1.Image = image;
                pictureBox2.Image = image;
            }
        }
        private void buttonPreviousWorkingZone_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                listBox1.SetSelected(listBox1.Items.Count - 1, true);
                listBox2.SetSelected(listBox1.Items.Count - 1, true);
            }
            else
            {
                listBox1.SetSelected(listBox1.SelectedIndex - 1, true);
                listBox2.SetSelected(listBox1.SelectedIndex , true);
                mp3.Close();

                stopwatch.Reset();

                timerCounter = 0;
                songTimer.Text = stopwatch.Elapsed.ToString("mm\\:ss");
                songTimerSide.Text = stopwatch.Elapsed.ToString("mm\\:ss");
                songSlider.Value = (timerCounter);
                songSliderSide.Value = (timerCounter);

                mp3.Open(paths[listBox1.SelectedIndex]);
                mp3.Play();
                timer.Start();
                stopwatch.Start();

                TagLib.File file = TagLib.File.Create(paths[listBox1.SelectedIndex]);
                songLabelCenter.Text = file.Tag.Title;
                artistLabelCenter.Text = file.Tag.Album;
                label8.Text = file.Tag.Title;
                label9.Text = file.Tag.Album;

                MemoryStream ms = new MemoryStream(file.Tag.Pictures[0].Data.Data);
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms);

                pictureBox1.Image = image;
                pictureBox2.Image = image;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            songTimer.Text = stopwatch.Elapsed.ToString("mm\\:ss");
            songTimerSide.Text = stopwatch.Elapsed.ToString("mm\\:ss");
            songSlider.Value = (++timerCounter);
            songSliderSide.Value = (timerCounter);

        }
        private void buttonHeaderExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton4_Click_1(object sender, EventArgs e)
        {
            mp3.Stop();
            timer.Stop();
            stopwatch.Stop();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            mp3.Close();
            timer.Stop();
            stopwatch.Reset();

            timerCounter = 0;
            songTimer.Text = stopwatch.Elapsed.ToString("mm\\:ss");
            songTimerSide.Text = stopwatch.Elapsed.ToString("mm\\:ss");
            songSlider.Value = (timerCounter);
            songSliderSide.Value = (timerCounter);

        }
        private void buttonEject_Click_1(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog()) //позваляет открывать файлы
            {
                ofd.Multiselect = true;
                ofd.Filter = "Mp3 Files|*.mp3";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    files = ofd.SafeFileNames;
                    paths = ofd.FileNames;


                    File.WriteAllText(@"C:\MP3PlayerWF\MP3PlayerWF\bin\Debug\test.txt", string.Empty);
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    System.IO.StreamWriter textFile = new System.IO.StreamWriter(@"C:\MP3PlayerWF\MP3PlayerWF\bin\Debug\test.txt");
                    for (int i = 0; i < paths.Length; i++)
                    {
                        textFile.WriteLine(paths[i]);
                    }
                    textFile.Close();
                    for (int i = 0; i < files.Length; i++)
                    {
                        listBox1.Items.Add(files[i]);
                        listBox2.Items.Add(files[i]);
                    }

                    listBox1.SetSelected(0, true);
                    listBox2.SetSelected(0, true);
                    
                }
            }
        }
    }
}
