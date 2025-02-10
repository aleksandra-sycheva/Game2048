namespace Game2048
{
    partial class EndForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            labelResult = new Label();
            buttonBack = new Button();
            label1 = new Label();
            labelTopPlayers = new Label();
            textBoxPlayerRank = new TextBox();
            textBoxBestScore = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MidnightBlue;
            pictureBox2.Location = new Point(88, 24);
            pictureBox2.Margin = new Padding(18, 15, 18, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(490, 57);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.RoyalBlue;
            pictureBox1.Location = new Point(88, 24);
            pictureBox1.Margin = new Padding(18, 15, 18, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 511);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.BackColor = Color.MidnightBlue;
            labelResult.Font = new Font("Franklin Gothic Medium", 20F, FontStyle.Bold);
            labelResult.ForeColor = SystemColors.Control;
            labelResult.Location = new Point(230, 37);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(208, 34);
            labelResult.TabIndex = 5;
            labelResult.Text = "Игра окончена";
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.MidnightBlue;
            buttonBack.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonBack.ForeColor = SystemColors.Control;
            buttonBack.Location = new Point(230, 483);
            buttonBack.Margin = new Padding(3, 2, 3, 2);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(220, 40);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "Играть снова";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font("Franklin Gothic Medium", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(218, 87);
            label1.Name = "label1";
            label1.Size = new Size(242, 34);
            label1.TabIndex = 10;
            label1.Text = "Таблица лидеров:";
            // 
            // labelTopPlayers
            // 
            labelTopPlayers.AutoSize = true;
            labelTopPlayers.BackColor = Color.RoyalBlue;
            labelTopPlayers.Font = new Font("Franklin Gothic Medium", 20F, FontStyle.Bold);
            labelTopPlayers.ForeColor = Color.White;
            labelTopPlayers.Location = new Point(230, 121);
            labelTopPlayers.Name = "labelTopPlayers";
            labelTopPlayers.Size = new Size(0, 34);
            labelTopPlayers.TabIndex = 11;
            // 
            // textBoxPlayerRank
            // 
            textBoxPlayerRank.BackColor = Color.RoyalBlue;
            textBoxPlayerRank.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Bold);
            textBoxPlayerRank.ForeColor = Color.White;
            textBoxPlayerRank.Location = new Point(109, 432);
            textBoxPlayerRank.Multiline = true;
            textBoxPlayerRank.Name = "textBoxPlayerRank";
            textBoxPlayerRank.ReadOnly = true;
            textBoxPlayerRank.ShortcutsEnabled = false;
            textBoxPlayerRank.Size = new Size(456, 46);
            textBoxPlayerRank.TabIndex = 12;
            textBoxPlayerRank.TabStop = false;
            textBoxPlayerRank.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxBestScore
            // 
            textBoxBestScore.BackColor = Color.RoyalBlue;
            textBoxBestScore.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Bold);
            textBoxBestScore.ForeColor = Color.White;
            textBoxBestScore.Location = new Point(109, 355);
            textBoxBestScore.Multiline = true;
            textBoxBestScore.Name = "textBoxBestScore";
            textBoxBestScore.ReadOnly = true;
            textBoxBestScore.ShortcutsEnabled = false;
            textBoxBestScore.Size = new Size(456, 46);
            textBoxBestScore.TabIndex = 13;
            textBoxBestScore.TabStop = false;
            textBoxBestScore.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(239, 404);
            label2.Name = "label2";
            label2.Size = new Size(199, 25);
            label2.TabIndex = 14;
            label2.Text = "Текущий результат:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font("Franklin Gothic Medium", 15F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(248, 327);
            label3.Name = "label3";
            label3.Size = new Size(190, 25);
            label3.TabIndex = 15;
            label3.Text = "Лучший результат:";
            // 
            // EndForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(689, 559);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxBestScore);
            Controls.Add(textBoxPlayerRank);
            Controls.Add(labelTopPlayers);
            Controls.Add(label1);
            Controls.Add(buttonBack);
            Controls.Add(labelResult);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EndForm";
            Text = "Результат";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label labelResult;
        private Button buttonBack;
        private Label label1;
        private Label labelTopPlayers;
        private TextBox textBoxPlayerRank;
        private TextBox textBoxBestScore;
        private Label label2;
        private Label label3;
    }
}