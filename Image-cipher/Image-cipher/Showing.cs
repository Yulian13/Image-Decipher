using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_cipher
{
    public partial class Showing : Form
    {
        static Image[] NewImages;
        static Image[] origenImage;
        static string[] RightKeys;
        static bool[] ReadyPhotos;
        bool close = false;

        bool originDeshifrovka = true;
        bool NormalZoom = true;
        string Key;
        int numberPhoto;
        public int NumberPhoto
        {
            get => numberPhoto;
            set
            {
                numberPhoto = value;
                LabelView.Text = $"Page: {NumberPhoto + 1}/{ReadyPhotos.Length}";
                ProgressBarView.Value = numberPhoto + 1;
                pictureBox1_SizeChanged(null, null);
            }
        }

        public Showing(Image[] composition,string[] rightKeys,string Name, string Key)
        {
            InitializeComponent();

            this.Key = Key;
            RightKeys = rightKeys;
            try
            {
                this.Text = Librari.DeShifrovka(Name, Key);
            }
            catch (Exception)
            {
                this.Text = Name;
            }
            NewImages = composition;
            origenImage = composition;
            ReadyPhotos = new bool[composition.Length];

            ProgressBarProgress.Maximum = ReadyPhotos.Length;
            ProgressBarView.Maximum = ReadyPhotos.Length;
            backgroundWorker1.RunWorkerAsync(composition);

            while (ReadyPhotos[0] != true) { }
            NumberPhoto = 0;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Image error = Console.ErrorImage;
            for(int i = 0; i< NewImages.Length; i++)
            {
                if (close) return; // Crutch
                try
                {
                    NewImages[i] = new NewImage(NewImages[i],rightKey:RightKeys[i]).DeShifrovkaImage(Key);
                }
                catch (Exception)
                {
                    NewImages[i] = error;
                }
                ReadyPhotos[i] = true;
                backgroundWorker1.ReportProgress(++i);
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (close) return; // Crutch

            LabelProgress.Text = $"{e.ProgressPercentage}/{NewImages.Length}";
            ProgressBarProgress.Value++;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (close) return; // Crutch

            ProgressBarProgress.Visible = false;
            LabelProgress.Visible = false;
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            panel1.VerticalScroll.Value = 0;
            if (NumberPhoto < NewImages.Length - 1 && ReadyPhotos[NumberPhoto + 1] == true)
                NumberPhoto++;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panel1.VerticalScroll.Value = 0;
            if (NumberPhoto > 0)
                NumberPhoto--;
        }

        private void Watching_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.XButton1)
                buttonForward_Click(null, null);
            else if (e.Button == MouseButtons.XButton2)
                buttonBack_Click(null, null);
            else if (e.Button == MouseButtons.Left)
            {
                if (e.Location.X < Console.Width / 2)
                    buttonBack_Click(null, null);
                else
                    buttonForward_Click(null, null);
            }
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            Image image = (originDeshifrovka) ? NewImages[numberPhoto] :
                    origenImage[NumberPhoto];
            LabelView.Margin = new Padding((int)(toolStrip1.Width * 0.4), 3, 0, 2);
            if (NormalZoom)
            {
                int Width = panel1.Width - 20;
                int Height = (int)(((double)image.Height / image.Width) * Width);
                Size newSize = new Size(Width, Height);
                Console.Image = new Bitmap(image, newSize);
                Console.Size = new Size(newSize.Width, newSize.Height + statusStrip1.Height);
            }
            else
            {
                Console.Size = new Size(panel1.Width - 20, panel1.Height - 20);
                Console.Image = image;
            }
        }

        private void toolStripButtonOriginalDeshifrovka_Click(object sender, EventArgs e)
        {
            originDeshifrovka = !originDeshifrovka;
            toolStripButtonOriginalDeshifrovka.Text = (originDeshifrovka) ? "origin" : "Deshifrovka";
            NumberPhoto = NumberPhoto;
        }

        private void ButtonZoomNormal_Click(object sender, EventArgs e)
        {
            NormalZoom = !NormalZoom;
            Console.SizeMode = (NormalZoom) ? PictureBoxSizeMode.Normal : PictureBoxSizeMode.Zoom;
            Console.Image = NewImages[NumberPhoto];
            ButtonZoomNormal.Text = (NormalZoom) ? "Zoom" : "Normal";
            pictureBox1_SizeChanged(null, null);
        }

        private void Watching_FormClosing(object sender, FormClosingEventArgs e) => close = true;
    }
}
