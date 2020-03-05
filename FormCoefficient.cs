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
    public partial class FormCoefficient : Form
    {
        public FormCoefficient()
        {
            InitializeComponent();
        }

        private void coefficientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coefficientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zarplata2DataSet);

        }

        private void FormCoefficient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zarplata2DataSet.Coefficient". При необходимости она может быть перемещена или удалена.
            this.coefficientTableAdapter.Fill(this.zarplata2DataSet.Coefficient);

        }

        private void k_U_OTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new FormRedakCoefficient();
            f2.Show();
            f2.Top = this.Top;
            f2.Show();
            this.Hide();
        }
    }
}
