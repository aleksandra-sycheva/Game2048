using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using Label = System.Windows.Forms.Label;
using Timer = System.Windows.Forms.Timer;
using static System.Windows.Forms.DataFormats;


namespace Game2048
{
    public partial class GameForm : System.Windows.Forms.Form
    {
        string userName;
        public int[,] map = new int[4, 4];
        public Label[,] labels = new Label[4, 4];
        public PictureBox[,] pics = new PictureBox[4, 4];
        private int score = 0;

        public GameForm(string userName)
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(OnKeyboardPressed);
            map[0, 0] = 1;
            map[0, 1] = 1;
            this.userName = userName;
            CreateMap();
            CreatePics();
            checkScore(score);
            GenerateNewPic();
        }


        private void CreateMap()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Location = new Point(127 + 120 * j, 85 + 120 * i);
                    pic.Size = new Size(100, 100);
                    pic.BackColor = SystemColors.ControlDarkDark;
                    this.Controls.Add(pic);
                    pic.BringToFront();

                    
                }
            }
        }

        private void GenerateNewPic()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 4);
            int b = rnd.Next(0, 4);
            while (pics[a, b] != null)
            {
                a = rnd.Next(0, 4);
                b = rnd.Next(0, 4);
            }
            map[a, b] = 1;
            pics[a, b] = new PictureBox();
            labels[a, b] = new Label();
            labels[a, b].Text = "2";
            labels[a, b].Size = new Size(100, 100);
            labels[a, b].TextAlign = ContentAlignment.MiddleCenter;
            labels[a, b].Font = new Font(new FontFamily("Franklin Gothic Medium"), 20, FontStyle.Bold);
            labels[a, b].ForeColor = Color.FromArgb(119, 110, 101);
            pics[a, b].Controls.Add(labels[a, b]);
            pics[a, b].Location = new Point(127 + b * 120, 85 + 120 * a);
            pics[a, b].Size = new Size(100, 100);
            pics[a, b].BackColor = Color.FromArgb(238, 228, 219);
            this.Controls.Add(pics[a, b]);
            pics[a, b].BringToFront();
        }

        private void CreatePics()
        {
            pics[0, 0] = new PictureBox();
            labels[0, 0] = new Label();
            labels[0, 0].Text = "2";
            labels[0, 0].Size = new Size(100, 100);
            labels[0, 0].TextAlign = ContentAlignment.MiddleCenter;
            labels[0, 0].Font = new Font(new FontFamily("Franklin Gothic Medium"), 20, FontStyle.Bold);
            pics[0, 0].Controls.Add(labels[0, 0]);
            pics[0, 0].Location = new Point(127, 85);
            pics[0, 0].Size = new Size(100, 100);
            pics[0, 0].BackColor = Color.FromArgb(238, 228, 219);
            labels[0, 0].ForeColor = Color.FromArgb(119, 110, 101);
            this.Controls.Add(pics[0, 0]);
            pics[0, 0].BringToFront();

            pics[0, 1] = new PictureBox();
            labels[0, 1] = new Label();
            labels[0, 1].Text = "2";
            labels[0, 1].Size = new Size(100, 100);
            labels[0, 1].TextAlign = ContentAlignment.MiddleCenter;
            labels[0, 1].Font = new Font(new FontFamily("Franklin Gothic Medium"), 20, FontStyle.Bold);
            pics[0, 1].Controls.Add(labels[0, 1]);
            pics[0, 1].Location = new Point(247, 85);
            pics[0, 1].Size = new Size(100, 100);
            pics[0, 1].BackColor = Color.FromArgb(238, 228, 219);
            labels[0, 1].ForeColor = Color.FromArgb(119, 110, 101);
            this.Controls.Add(pics[0, 1]);
            pics[0, 1].BringToFront();
        }

        private void ChangeColor(int sum, int k, int j)
        {

            if (sum % 131072 == 0)
            {
                labels[k, j].ForeColor = Color.FromArgb(255, 246, 230);
                pics[k, j].BackColor = Color.FromArgb(0, 118, 193);
            }
            if (sum % 65536 == 0)
            {
                labels[k, j].ForeColor = Color.FromArgb(255, 246, 230);
                pics[k, j].BackColor = Color.FromArgb(83, 154, 229);
            }
            if (sum % 32768 == 0)
            {
                labels[k, j].ForeColor = Color.FromArgb(255, 246, 230);
                pics[k, j].BackColor = Color.FromArgb(96, 178, 219);
            }
            if (sum % 16384 == 0)
            {
                labels[k, j].ForeColor = Color.FromArgb(255, 246, 230);
                pics[k, j].BackColor = Color.FromArgb(248, 19, 30);
            }
            if (sum % 8192 == 0)
            {
                labels[k, j].ForeColor = Color.FromArgb(255, 246, 230);
                pics[k, j].BackColor = Color.FromArgb(255, 34, 75);
            }
            if (sum % 4096 == 0)
            {
                labels[k, j].ForeColor = Color.FromArgb(255, 246, 230);
                pics[k, j].BackColor = Color.FromArgb(255, 80, 94);
            }
            if (sum % 2048 == 0)
            {
                labels[k, j].ForeColor = Color.FromArgb(255, 246, 230);
                pics[k, j].BackColor = Color.FromArgb(237, 193, 46);
            }
            else if (sum % 1024 == 0)
            {
                labels[k, j].ForeColor = Color.FromArgb(255, 246, 230);
                pics[k, j].BackColor = Color.FromArgb(237, 197, 63);
            }
            else if (sum % 512 == 0)
            {
                labels[k, j].ForeColor = Color.FromArgb(255, 246, 230);
                pics[k, j].BackColor = Color.FromArgb(238, 201, 80);
            }
            else if (sum % 256 == 0)
            {
                pics[k, j].BackColor = Color.FromArgb(238, 204, 98);
                labels[k, j].ForeColor = Color.FromArgb(255, 255, 255);
            }
            else if (sum % 128 == 0)
            {
                pics[k, j].BackColor = Color.FromArgb(236, 208, 114);
                labels[k, j].ForeColor = Color.FromArgb(255, 255, 255);
            }
            else if (sum % 64 == 0)
            {
                pics[k, j].BackColor = Color.FromArgb(247, 96, 60);
                labels[k, j].ForeColor = Color.FromArgb(255, 255, 255);
            }
            else if (sum % 32 == 0)
            {
                pics[k, j].BackColor = Color.FromArgb(246, 124, 95);
                labels[k, j].ForeColor = Color.FromArgb(255, 255, 255);
            }
            else if (sum % 16 == 0)
            {
                pics[k, j].BackColor = Color.FromArgb(246, 150, 100);
                labels[k, j].ForeColor = Color.FromArgb(255, 255, 255);
            }
            else if (sum % 8 == 0)
            {
                labels[k, j].ForeColor = Color.FromArgb(255, 255, 255);
                pics[k, j].BackColor = Color.FromArgb(243, 178, 122);
            }
            else
            {
                labels[k, j].ForeColor = Color.FromArgb(119, 110, 101);
                pics[k, j].BackColor = Color.FromArgb(238, 224, 203);
            }
        }

        private void OnKeyboardPressed(object sender, KeyEventArgs e)
        {

            bool ifPicWasMoved = false;

            switch (e.KeyCode.ToString())
            {
                case "Right":
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 2; l >= 0; l--)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = l + 1; j < 4; j++)
                                {
                                    if (map[k, j] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[k, j - 1] = 0;
                                        map[k, j] = 1;
                                        pics[k, j] = pics[k, j - 1];
                                        pics[k, j - 1] = null;
                                        labels[k, j] = labels[k, j - 1];
                                        labels[k, j - 1] = null;
                                        pics[k, j].Location = new Point(pics[k, j].Location.X + 120, pics[k, j].Location.Y);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[k, j].Text);
                                        int b = int.Parse(labels[k, j - 1].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[k, j].Text = (a + b).ToString();
                                            score += (a + b);
                                            ChangeColor(a + b, k, j);
                                            checkScore(score);
                                            label1.Text = "Счет: " + score;
                                            map[k, j - 1] = 0;
                                            this.Controls.Remove(pics[k, j - 1]);
                                            this.Controls.Remove(labels[k, j - 1]);
                                            pics[k, j - 1] = null;
                                            labels[k, j - 1] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Left":
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 1; l < 4; l++)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = l - 1; j >= 0; j--)
                                {
                                    if (map[k, j] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[k, j + 1] = 0;
                                        map[k, j] = 1;
                                        pics[k, j] = pics[k, j + 1];
                                        pics[k, j + 1] = null;
                                        labels[k, j] = labels[k, j + 1];
                                        labels[k, j + 1] = null;
                                        pics[k, j].Location = new Point(pics[k, j].Location.X - 120, pics[k, j].Location.Y);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[k, j].Text);
                                        int b = int.Parse(labels[k, j + 1].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[k, j].Text = (a + b).ToString();
                                            score += (a + b);
                                            ChangeColor(a + b, k, j);
                                            checkScore(score);
                                            label1.Text = "Счет: " + score;
                                            map[k, j + 1] = 0;
                                            this.Controls.Remove(pics[k, j + 1]);
                                            this.Controls.Remove(labels[k, j + 1]);
                                            pics[k, j + 1] = null;
                                            labels[k, j + 1] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Down":
                    for (int k = 2; k >= 0; k--)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = k + 1; j < 4; j++)
                                {
                                    if (map[j, l] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[j - 1, l] = 0;
                                        map[j, l] = 1;
                                        pics[j, l] = pics[j - 1, l];
                                        pics[j - 1, l] = null;
                                        labels[j, l] = labels[j - 1, l];
                                        labels[j - 1, l] = null;
                                        pics[j, l].Location = new Point(pics[j, l].Location.X, pics[j, l].Location.Y + 120);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[j, l].Text);
                                        int b = int.Parse(labels[j - 1, l].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[j, l].Text = (a + b).ToString();
                                            score += (a + b);
                                            ChangeColor(a + b, j, l);
                                            checkScore(score);
                                            label1.Text = "Счет: " + score;
                                            map[j - 1, l] = 0;
                                            this.Controls.Remove(pics[j - 1, l]);
                                            this.Controls.Remove(labels[j - 1, l]);
                                            pics[j - 1, l] = null;
                                            labels[j - 1, l] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Up":
                    for (int k = 1; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = k - 1; j >= 0; j--)
                                {
                                    if (map[j, l] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[j + 1, l] = 0;
                                        map[j, l] = 1;
                                        pics[j, l] = pics[j + 1, l];
                                        pics[j + 1, l] = null;
                                        labels[j, l] = labels[j + 1, l];
                                        labels[j + 1, l] = null;
                                        pics[j, l].Location = new Point(pics[j, l].Location.X, pics[j, l].Location.Y - 120);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[j, l].Text);
                                        int b = int.Parse(labels[j + 1, l].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[j, l].Text = (a + b).ToString();
                                            score += (a + b);
                                            ChangeColor(a + b, j, l);
                                            checkScore(score);
                                            label1.Text = "Счет: " + score;
                                            map[j + 1, l] = 0;
                                            this.Controls.Remove(pics[j + 1, l]);
                                            this.Controls.Remove(labels[j + 1, l]);
                                            pics[j + 1, l] = null;
                                            labels[j + 1, l] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                default:
                    if (e.KeyCode == Keys.Escape) // Проверяем, нажата ли клавиша Esc
                    {
                        EndForm form4 = new EndForm(userName, score);
                        form4.Show();
                        this.Close();
                    }
                    break;
            }
            if (ifPicWasMoved)
            {
                GenerateNewPic();
            }
            else
            {
                if (!FreeCell())
                {
                    Thread.Sleep(1000);
                    EndForm form4 = new EndForm(userName, score);
                    form4.Show();
                    this.Close();

                }
                else
                {
                    GenerateNewPic();
                }
            }

        }
        private bool FreeCell()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (pics[i, j] == null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        private void checkScore(int score)
        {
            string filePath = "C:\\Users\\User\\Documents\\IS22\\Sycheva\\C#\\Курсовой проект\\Курсовой проект\\Game2048\\player_data.txt";
            int existingScore = 0;
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                List<string> updatedLines = new List<string>();


                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    if (data[0] == userName)
                    {
                        existingScore = int.Parse(data[1]);
                    }
                }
                if (existingScore > score)
                {
                    labelTopScore.Text = "Рекорд: " + existingScore;
                }
                else
                {
                    labelTopScore.Text = "Рекорд: " + score;
                }
            }
        }
    }
}
