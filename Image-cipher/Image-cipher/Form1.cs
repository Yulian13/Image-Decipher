using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Image_cipher
{
    public partial class Form1 : Form
    {
        string Key;
        const string NameFolderCompositions = "CompositionImage";
        const string NameFolderKeys = "Keys";

        public Form1()
        {
            InitializeComponent();

            ButtonChangeKey_Click(null,null);

            LabelPath.Text = "";
            Console.DropDownItems.Add("Application running");
        }

        private void ButtonChangeKey_Click(object sender, EventArgs e)
        {
            GetKey key = new GetKey();
            key.ShowDialog();

            this.Key = key.maskedTextBox1.Text;

            if(sender != null && e != null)
            {
                Librari.MessadgeToConsole(Console,"Key have been changed");
                dataGridView1_SelectionChanged(null, null);
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FilePath = new FolderBrowserDialog();
            if (FilePath.ShowDialog() != DialogResult.OK)
                return;

            string MainPath = FilePath.SelectedPath + ((FilePath.SelectedPath.EndsWith("\\"))? 
                NameFolderCompositions : "\\" + NameFolderCompositions);

            LabelPath.Text = MainPath;

            if (!Directory.Exists(MainPath))
            {
                Librari.MessadgeToConsole(Console, "Folder isn't finder");
                return;
            }
            dataGridView1.Rows.Clear();

            int FoldersLenght = Directory.GetDirectories(MainPath).Length;
            int i = 0;
            int number = 0;
            while(i < FoldersLenght)
            {
                try
                {
                    if (!Directory.Exists(MainPath + $"\\{number}"))
                    {
                        number++;
                        continue;
                    }

                    dataGridView1.Rows.Add(
                        i,
                        new StreamReader(MainPath + $"\\{number}\\Text.txt").ReadToEnd(),
                        Directory.GetFiles(MainPath + $"\\{number}", "*jpg", SearchOption.TopDirectoryOnly).Length,
                        new Bitmap(MainPath + $"\\{number}\\0image.jpg"),
                        new StreamReader(MainPath + $"\\{number}\\{NameFolderKeys}\\0Key.txt").ReadToEnd()
                    );
                }
                catch (Exception)
                {
                    Librari.MessadgeToConsole(Console, $"failed to get into folder \"{number}\"");
                }
                if(number != 0 && number%100 == 0)
                {
                    DialogResult result = MessageBox.Show("Finishi the search?", "100 folders have been found",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly);

                    if (result == DialogResult.OK) break;
                }

                number++;
                i++;
            }

            return;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string text = "";
                try
                {
                    text = row.Cells[1].Value.ToString();
                    row.Cells[1].Value = Librari.DeShifrovka(text, Key);
                }
                catch (Exception)
                {
                    Librari.MessadgeToConsole(Console, $"failed to decipher \"{text}\"");
                }
                
            }
        }

        private void ButtonClear_console_Click(object sender, EventArgs e) => Console.DropDownItems.Clear();

        private void Console_ButtonClick(object sender, EventArgs e) => Console.ForeColor = Color.Black;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;
            try
            {
                Image image = (Image) dataGridView1.SelectedRows[0].Cells[3].Value;
                string key  = (string)dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                pictureBox1.Image = new NewImage(image, rightKey: key).DeShifrovkaImage(Key);
            }
            catch (Exception)
            {
                Librari.MessadgeToConsole(Console, 
                    $"failed to decipher \"{dataGridView1.SelectedRows[0].Cells[1].Value}\"");
                pictureBox1.Image = pictureBox1.ErrorImage;
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;
            int index = dataGridView1.SelectedRows[0].Index;
            int Id = Int32.Parse(dataGridView1[0, index].Value.ToString());
            int number = Int32.Parse(dataGridView1[2, index].Value.ToString());
            string Name = dataGridView1[1, index].Value.ToString();
            string[] keys = new string[number];
            Image[] images = new Image[number];
            images[0] = (Image)dataGridView1[3, index].Value;
            keys[0] = dataGridView1[4, index].Value.ToString();

            for(int i = 1; i < number; i++)
            {
                try
                {
                    keys[i] = new StreamReader(LabelPath.Text+$"\\{Id}\\{NameFolderKeys}\\{i}Key.txt").ReadToEnd();
                }
                catch (Exception ex)
                {
                    Librari.MessadgeToConsole(Console, ex.Message);
                }

                try
                {
                    images[i] = new Bitmap(LabelPath.Text + $"\\{Id}\\{i}image.jpg");
                }
                catch (Exception ex)
                {
                    Librari.MessadgeToConsole(Console, ex.Message);
                }
            }

            Showing showing = new Showing(images,keys,Name,Key);

            showing.Show();
        }
    }
}
