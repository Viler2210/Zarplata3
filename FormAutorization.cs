using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zarplata3
{
    public partial class FormAutorization : Form
    {

        public FormAutorization()
        {
            InitializeComponent();
        }
        int a = 0, b = 15, s = 0, d = 15;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string loginUser = textBox1.Text;
                string passUser = textBox2.Text;
                ClassIniDataBase db = new ClassIniDataBase();
                DataTable table = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand commandagent = new SqlCommand(@"SELECT * FROM [User] WHERE Login = @uL AND Password = @uP AND Role= 'Maneger'", db.GetConnection());
                commandagent.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandagent.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter.SelectCommand = commandagent;
                adapter.Fill(table);
                DataTable table1 = new DataTable();
                SqlDataAdapter adapter1 = new SqlDataAdapter();
                SqlCommand commandclient = new SqlCommand(@"SELECT * FROM [User] WHERE Login = @uL AND Password = @uP AND Role = 'executor'", db.GetConnection());
                commandclient.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandclient.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter1.SelectCommand = commandclient;
                adapter1.Fill(table1);
                if (table.Rows.Count > 0)
                {
                    Form ifrm = new FormManeger();
                    ifrm.Left = this.Left;
                    ifrm.Top = this.Top;
                    ifrm.Show();
                    this.Hide();
                }
                else
                {
                    if (table1.Rows.Count > 0)
                    {
                        Form efrm = new Formexecutor();
                        efrm.Show();
                        efrm.Top = this.Top;
                        efrm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Не верный логин или пароль");
                        textBox1.Clear();
                        textBox2.Clear();
                        a++;
                        if (a == 3)
                        {
                            timer1.Enabled = true;
                            button1.Enabled = false;
                            label4.Visible = true;
                            button2.Enabled = false;
                            textBox1.Enabled = false;
                            textBox2.Enabled = false;
                        }
                    }
                }
            }


            finally { }

        }

        private void butInput_Click(object sender, EventArgs e)

        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b > 0)
            {
                b--;
                label4.Text = ("Вы заблокированы. Пожалуйста подождите: " + b);
                if (b == 0)
                {
                    b = d;
                    d += 5;
                    timer1.Enabled = false;
                    button1.Enabled = true;
                    label4.Visible = false;
                    button2.Enabled = true;
                    label4.Text = "";
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                }
            }
            s++;
        }
    }
}







