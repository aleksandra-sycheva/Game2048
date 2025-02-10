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
    public partial class RulesForm : System.Windows.Forms.Form
    {
        private WelcomeForm _form2;
        public RulesForm(WelcomeForm form2)
        {
            InitializeComponent();
            _form2 = form2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _form2.Show();
        }
    }
}
