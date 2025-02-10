using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Game2048
{
    public partial class EndForm : System.Windows.Forms.Form
    {
        public string userName;
        private int score;
        public EndForm(string userName, int score)
        {
            InitializeComponent();
            this.userName = userName;
            this.score = score;
            Get_result();
        }

        private void Get_result()
        {
            SavePlayerData(userName, score);
            DisplayTopPlayers();
        }
        void SavePlayerData(string username, int score)
        {
            // Путь к файлу
            string filePath = "C:\\Users\\User\\Documents\\IS22\\Sycheva\\C#\\Курсовой проект\\Курсовой проект\\Game2048\\player_data.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    List<string> updatedLines = new List<string>();
                    bool playerFound = false; 
                    string lineToWrite = ""; 

                    foreach (string line in lines)
                    {
                        string[] data = line.Split(',');
                        if (data[0] == userName)
                        {
                            int existingScore = int.Parse(data[1]);
                            if (existingScore < score)
                            {
                                existingScore = score;
                            }
                            lineToWrite = $"{userName},{existingScore}";
                            updatedLines.Add(lineToWrite); 
                            playerFound = true; 
                        }
                        else
                        {
                            updatedLines.Add(line); 
                        }
                    }

                    if (!playerFound)
                    {
                        
                        lineToWrite = $"{userName},{score}";
                        updatedLines.Add(lineToWrite);
                    }

                    File.WriteAllLines(filePath, updatedLines);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
            }
        }

        private void DisplayTopPlayers()
        {
            string filePath = "C:\\Users\\User\\Documents\\IS22\\Sycheva\\C#\\Курсовой проект\\Курсовой проект\\Game2048\\player_data.txt";
            if (File.Exists(filePath))
            {
                var playerScores = new List<(string Username, int Score)>();

                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    if (data.Length == 2)
                    {
                        string username = data[0];
                        int score;
                        if (int.TryParse(data[1], out score))
                        {
                            playerScores.Add((username, score));
                        }
                    }
                }

                var sortedScores = playerScores.OrderByDescending(ps => ps.Score).ToList();

                StringBuilder topPlayers = new StringBuilder();
                for (int i = 0; i < Math.Min(5, sortedScores.Count); i++)
                {
                    topPlayers.AppendLine($"{i + 1}) {sortedScores[i].Username} - {sortedScores[i].Score}");
                }
                labelTopPlayers.Text = topPlayers.ToString();

                // Найти место текущего игрока
                int playerRank = sortedScores.FindIndex(ps => ps.Username == userName) + 1;
                if (playerRank > 0)
                {
                    textBoxPlayerRank.Text = $"{userName} - {score}";
                    var bestScore = playerScores.FirstOrDefault(ps => ps.Username == userName);
                    int bestRank = sortedScores.FindIndex(ps => ps.Username == userName) + 1; // Находим ранг лучшего результата
                    textBoxBestScore.Text = $"{bestRank}) {bestScore.Username} - {bestScore.Score}";
                }
                else
                {
                    textBoxPlayerRank.Text = "Вы не в топе!";
                }
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            GameForm form4 = new GameForm(userName);
            form4.Show();
            this.Close();
        }
    }   
}
