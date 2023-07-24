using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Text = "Admin";
            this.BackColor = ColorTranslator.FromHtml("#ebeec1");
            tabPage1.Text = "Item";
            tabPage2.Text = "Employee";
            tabPage1.BackColor =ColorTranslator.FromHtml("#fbdd6d");
            dataGridView1.Rows.Add("Espreeso","Yes","humberger","","","1");
            dataGridView1.Rows.Add("", "", "Chessburger", "","Water 0.150", "3");
            dataGridView1.Rows.Add("Lato", "No","", "BesanLadoo","", "5");
            dataGridView1.Rows.Add("", "", "Sandwich", "","", "7");
            dataGridView1.Rows.Add("Lato", "No", "humberger", "", "", "2");
            dataGridView1.Rows.Add("Cappucino", "Yes", "humberger", "", "", "6");
            this.BackColor = ColorTranslator.FromHtml("#123456");
            dataGridView1.Rows.Add("Lato", "No", "", "BesanLadoo", "", "5");
            dataGridView1.Rows.Add("Lato", "No", "humberger", "", "", "2");
            dataGridView1.Rows.Add("Lato", "No", "humberger", "", "", "2");
            tabPage2.BackColor = ColorTranslator.FromHtml("#66a182");
            tabPage1.BackColor = ColorTranslator.FromHtml("#66a182");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 op = new Form1();
            op.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {   }
        string path = "";
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                OpenFileDialog op = new OpenFileDialog();
                op.ShowDialog();
                path = op.FileName;
                pictureBox1.Image = new Bitmap(path);
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> yahya = new List<string>();
            yahya.Add(textBox1.Text);
            yahya.Add(textBox2.Text);
            for (int i = 0; i < yahya.Count; i++)
            {
                MessageBox.Show(yahya[i]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        public static int row = 1;
        string[,] table = new string[20, 7];

        public void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || comboBox1.Text != "" || textBox3.Text != "")
            {
                int stop = 0;
                try
                {
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (table[i, 0] == null)
                            {
                                table[i, j] = (i + 1).ToString(); stop = stop + 1;
                                table[i, j + 1] = textBox1.Text; stop = stop + 1;
                                table[i, j + 2] = textBox3.Text; stop = stop + 1;
                                table[i, j + 3] = textBox2.Text; stop = stop + 1;
                                table[i, j + 4] = comboBox1.Text; stop = stop + 1;
                                stop = stop + 1;
                                if (radioButton1.Checked) { table[i, j + 5] = "Male"; }
                                if (radioButton2.Checked) { table[i, j + 5] = "Female"; }
                                table[i, j + 6] = path;
                                path = null;
                                stop = stop + 1;
                                {
                                    break;
                                }
                            }
                        }
                        if (stop == 7)
                        {
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("please input all information");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
           
        }
        int seaarch = 0;
        private void button2_Click_2(object sender, EventArgs e)
        {
            if (seaarch < 0)
            {
                seaarch = 0;
                emp(seaarch);
            }
           else if (seaarch == 0)
            {
                emp(seaarch);
                seaarch = seaarch + 1;
            }
            else if (seaarch > 0 )
            {
                emp(seaarch);
                seaarch = seaarch + 1;
            }
        }
        public void emp(int searc)
        {
            try
            {
                label1.Text = "Name: " + table[searc, 1];
                label2.Text = "Age: " + table[searc, 2];
                label3.Text = "Ph.Number: " + table[searc, 3];
                label9.Text = "Authority: " + table[searc, 4];
                if (table[searc, 5] == "Male") { radioButton1.Checked = true; }
                else if (table[searc, 5] == "Female") { radioButton2.Checked = true; }
                pictureBox1.Image = new Bitmap(table[searc, 6]);


            }
            catch
            {
                seaarch = seaarch - 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (seaarch < 0)
            {
                seaarch = 0;
                emp(seaarch);
            }
            else if (seaarch == 0)
            {
                emp(seaarch);
                seaarch = seaarch - 1;
            }
            else if (seaarch > 0)
            {
                emp(seaarch);
                seaarch = seaarch - 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                table[seaarch, 0] = null;
                table[seaarch, 1] = null;
                table[seaarch, 2] = null;
                table[seaarch, 3] = null;
                table[seaarch, 4] = null;
                table[seaarch, 5] = null;
                table[seaarch, 6] = null;
            }
            catch
            {
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
