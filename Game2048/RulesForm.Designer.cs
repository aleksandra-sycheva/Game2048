namespace Game2048
{
    partial class RulesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesForm));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            rulse = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MidnightBlue;
            pictureBox2.Location = new Point(81, 43);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(534, 46);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.RoyalBlue;
            pictureBox1.Location = new Point(81, 43);
            pictureBox1.Margin = new Padding(18, 15, 18, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(534, 328);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // rulse
            // 
            rulse.BackColor = Color.RoyalBlue;
            rulse.BorderStyle = BorderStyle.None;
            rulse.Font = new Font("Franklin Gothic Medium", 14F, FontStyle.Bold);
            rulse.ForeColor = Color.White;
            rulse.Location = new Point(81, 94);
            rulse.Margin = new Padding(3, 2, 3, 2);
            rulse.Multiline = true;
            rulse.Name = "rulse";
            rulse.ReadOnly = true;
            rulse.Size = new Size(534, 314);
            rulse.TabIndex = 5;
            rulse.TabStop = false;
            rulse.Text = resources.GetString("rulse.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Franklin Gothic Medium", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(254, 43);
            label1.Name = "label1";
            label1.Size = new Size(169, 44);
            label1.TabIndex = 6;
            label1.Text = "Правила";
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Franklin Gothic Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(460, 361);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(128, 35);
            button1.TabIndex = 7;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RulesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(689, 455);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(rulse);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RulesForm";
            Text = "Правила";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox rulse;
        private Label label1;
        private Button button1;
    }
}