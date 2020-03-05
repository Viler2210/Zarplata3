using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zarplata3
{
    public partial class FormManeger : Form
    {
        public FormManeger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f2 = new FormCoefficient();
            f2.Show();
            f2.Top = this.Top;
            f2.Show();
            this.Hide();
        }
    }
}
