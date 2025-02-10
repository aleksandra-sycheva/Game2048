using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2048
{
    public partial class WelcomeForm : System.Windows.Forms.Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            RulesForm form3 = new RulesForm(this);
            form3.Show();
            this.Hide();
        }

        private void buttonGame_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userName.Text))
            {
                MessageBox.Show("Заполнены не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GameForm form1 = new GameForm(userName.Text);
            form1.Show();
            this.Hide();
        }
    }
}
