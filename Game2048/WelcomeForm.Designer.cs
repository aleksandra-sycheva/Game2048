namespace Game2048
{
    partial class WelcomeForm
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            buttonRules = new Button();
            buttonGame = new Button();
            userName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.RoyalBlue;
            pictureBox1.Location = new Point(184, 112);
            pictureBox1.Margin = new Padding(18, 15, 18, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 217);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MidnightBlue;
            pictureBox2.Location = new Point(184, 112);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(326, 46);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Franklin Gothic Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(221, 122);
            label1.Name = "label1";
            label1.Size = new Size(233, 34);
            label1.TabIndex = 3;
            label1.Text = "Авторизируйтесь";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(286, 183);
            label2.Name = "label2";
            label2.Size = new Size(118, 30);
            label2.TabIndex = 6;
            label2.Text = "Ваш ник:";
            // 
            // buttonRules
            // 
            buttonRules.BackColor = Color.MidnightBlue;
            buttonRules.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRules.ForeColor = SystemColors.Control;
            buttonRules.Location = new Point(200, 280);
            buttonRules.Margin = new Padding(3, 2, 3, 2);
            buttonRules.Name = "buttonRules";
            buttonRules.Size = new Size(126, 33);
            buttonRules.TabIndex = 7;
            buttonRules.Text = "Правила";
            buttonRules.UseVisualStyleBackColor = false;
            buttonRules.Click += buttonRules_Click;
            // 
            // buttonGame
            // 
            buttonGame.BackColor = Color.MidnightBlue;
            buttonGame.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonGame.ForeColor = SystemColors.Control;
            buttonGame.Location = new Point(367, 280);
            buttonGame.Margin = new Padding(3, 2, 3, 2);
            buttonGame.Name = "buttonGame";
            buttonGame.Size = new Size(126, 33);
            buttonGame.TabIndex = 8;
            buttonGame.Text = "Играть";
            buttonGame.UseVisualStyleBackColor = false;
            buttonGame.Click += buttonGame_Click;
            // 
            // userName
            // 
            userName.Location = new Point(200, 222);
            userName.Name = "userName";
            userName.Size = new Size(293, 23);
            userName.TabIndex = 1;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(689, 455);
            Controls.Add(userName);
            Controls.Add(buttonGame);
            Controls.Add(buttonRules);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "WelcomeForm";
            Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Button buttonRules;
        private Button buttonGame;
        private TextBox userName;
    }
}