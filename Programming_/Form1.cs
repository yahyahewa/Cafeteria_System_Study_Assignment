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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menuStrip1.BackColor = ColorTranslator.FromHtml("#ebeec1");
            panel1.BackColor = ColorTranslator.FromHtml("#ebeec1");
            panel2.BackColor = ColorTranslator.FromHtml("#fbdd6d");
            panel3.BackColor = ColorTranslator.FromHtml("#e27556");
            panel4.BackColor = ColorTranslator.FromHtml("#a03954");
            panel5.BackColor = ColorTranslator.FromHtml("#54315b");
            this.BackColor = ColorTranslator.FromHtml("#123456");
            listBox1.BackColor = ColorTranslator.FromHtml("#66a182");
            listBox1.ForeColor = ColorTranslator.FromHtml("#ffdab5");
            button25.BackColor = ColorTranslator.FromHtml("#ffffff");
            button26.BackColor = ColorTranslator.FromHtml("#fbdd6d");
            this.AutoScroll = true;
            button25.BackColor = Color.MediumPurple;
            //.AutoScroll = true;
            button26.Text = "FULL SCREEN";
        }
        int l1 = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                price = price - 1;
                l1 = l1 - 1;
                label1.Text = l1.ToString();
            }
            int lenght = listBox1.Items.Count;
            for (int a = 0; a < lenght; a++)
            {
                if (listBox1.Items[a].ToString() == "Espresso        1.0$")
                {
                    listBox1.Items.RemoveAt(a);
                    break;
                }
            }
        }
        double price = 0.0;
        private void button3_Click(object sender, EventArgs e)
        {
            l1 = l1 + 1;
            label1.Text = l1.ToString();
            price = price + 1;
            listBox1.Items.Add("Espresso        1.0$");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com/");
            webBrowser1.Visible = false;
            webBrowser1.Width = 590;
            textBox2.UseSystemPasswordChar = true;
            panel6.Visible = false;
            button26.Visible = false;
            button26.Width = webBrowser1.Width;
        }
        int l2 = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if (label2.Text != "0")
            {
                price = price - 1;
                l2 = l2 - 1;
                label2.Text = l2.ToString();
            }
            int lenght = listBox1.Items.Count;
            for (int a = 0; a < lenght; a++)
            {
                if (listBox1.Items[a].ToString() == "Cappuccino   1.0$")
                {
                    listBox1.Items.RemoveAt(a);
                    break;
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cappuccino   1.0$");
            price = price + 1;
            l2 = l2 + 1;
            label2.Text = l2.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            l4 = l4 + 1;
            label4.Text = l4.ToString();
            price = price + 1;
            listBox1.Items.Add("Lato              1.0$");
        }
        int l4 = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            if (label4.Text != "0")
            {
                price = price - 1;
                l4 = l4 - 1;
                label4.Text = l4.ToString();
            }
            int lenght = listBox1.Items.Count;
            for (int a = 0; a < lenght; a++)
            {
                if (listBox1.Items[a].ToString() == "Lato              1.0$")
                {
                    listBox1.Items.RemoveAt(a);
                    break;
                }
            }
        }
        bool p1 = false;
        private void label3_Click(object sender, EventArgs e)
        {
            if (p1 == false)
            {
                p1 = true;
                timer1.Enabled = true;
                panel3.Visible = false;
                panel4.Visible = false;
            }
            else
            {
                panel3.Visible = true;
                panel4.Visible = true;
                p1 = false;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (p1 == true)
            {
                panel2.Height = panel2.Height + 5;
                if (panel2.Height >= 200)
                {
                    timer1.Enabled = false;
                }
            }
            if (p1 == false)
            {
                panel2.Height = panel2.Height - 5;
                if (panel2.Height <= 90)
                {
                    timer1.Enabled = false;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (p2 == true)
            {
                panel3.Height = panel3.Height + 5;
                if (panel3.Height >= 200)
                {
                    timer2.Enabled = false;
                }
            }
            if (p2 == false)
            {
                panel3.Height = panel3.Height - 5;
                if (panel3.Height <= 90)
                {
                    timer2.Enabled = false;
                    panel4.Visible = true;
                    panel5.Visible = true;
                }
            }
        }
        bool p2 = false;
        private void label8_Click(object sender, EventArgs e)
        {
            if (p2 == false)
            {
                p2 = true;
                timer2.Enabled = true;
                panel4.Visible = false;
                panel5.Visible = false;
            }
            else
            {
                p2 = false;
                timer2.Enabled = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            l14 = l14 + 1;
            label14.Text = l14.ToString();
            price = price + 1.5;
            listBox1.Items.Add("Besan Ladoo           1.5$");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            l13 = l13 + 1;
            price = price + 1.3;
            label13.Text = l13.ToString();
            listBox1.Items.Add("Sesame Sweet Balls 1.3$");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            l12 = l12 + 1;
            price = price + 1.2;
            listBox1.Items.Add("Soan Papdi             1.2$");
        }
        int l14 = 0;
        private void button13_Click(object sender, EventArgs e)
        {
            if (label14.Text != "0")
            {
                l14 = l14 - 1;
                label14.Text = l14.ToString();
                price = price - 1.5;
            }
            int lenght = listBox1.Items.Count;
            for (int a = 0; a < lenght; a++)
            {
                if (listBox1.Items[a].ToString() == "Besan Ladoo           1.5$")
                {
                    listBox1.Items.RemoveAt(a);
                    break;
                }
            }
        }
        int l13 = 0;
        private void button11_Click(object sender, EventArgs e)
        {
            if (label13.Text != "0")
            {
                price = price - 1.3;
                l13 = l13 - 1;
                label13.Text = l13.ToString();
            }
            int lenght = listBox1.Items.Count;
            for (int a = 0; a < lenght; a++)
            {
                if (listBox1.Items[a].ToString()== "Sesame Sweet Balls 1.3$")
                {
                    listBox1.Items.RemoveAt(a);
                    break;
                }
            }
        }
        int l12 = 0;
        private void button9_Click(object sender, EventArgs e)
        {
            if (label11.Text != "0")
            {
                price = price - 1.2;
                l12 = l12 - 1;
                label12.Text = l12.ToString();
            }
            int lenght = listBox1.Items.Count;
            for (int a = 0; a < lenght; a++)
            {
                if (listBox1.Items[a].ToString() == "Soan Papdi             1.2$")
                {
                    listBox1.Items.RemoveAt(a);
                    break;
                }
            }
        }
        bool p3 = false;
        private void label21_Click(object sender, EventArgs e)
        {
            if (p3 == false)
            {
                p3 = true;
                timer3.Enabled = true;
                panel5.Visible = false;
            }
            else
            {
                p3 = false;
                timer3.Enabled = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            if (p3 == true)
            {
                panel4.Height = panel4.Height + 5;
                if (panel4.Height >= 200)
                {
                    timer3.Enabled = false;
                }
            }
            if (p3 == false)
            {
                panel4.Height = panel4.Height - 5;
                if (panel4.Height <= 90)
                {
                    timer3.Enabled = false;
                    panel5.Visible = true;
                }
            }
        }
        bool p4 = false;
        private void label22_Click(object sender, EventArgs e)
        {
            if (p4 == false)
            {
                p4 = true;
                timer4.Enabled = true;
            }
            else
            {
                p4 = false;
                timer4.Enabled = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            if (p4 == true)
            {
                panel5.Height = panel5.Height + 5;
                if (panel5.Height >= 200)
                {
                    timer4.Enabled = false;
                }
            }
            if (p4 == false)
            {
                panel5.Height = panel5.Height - 5;
                if (panel5.Height <= 90)
                {
                    timer4.Enabled = false;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
        int l20 = 0;
        private void button22_Click(object sender, EventArgs e)
        {
            l20 = l20 + 1;
            label20.Text = l20.ToString();
            price = price + 1.2;
            listBox1.Items.Add("Hamburger       1.2$");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            l19 = l19 + 1;
            label19.Text = l19.ToString();
            price = price + 1.3;
            listBox1.Items.Add("Cheeseburger    1.3$");
        }
        int l19 = 0;
        private void button19_Click(object sender, EventArgs e)
        {
            if (label19.Text != "0")
            {
                l19 = l19 - 1;
                label19.Text = l19.ToString();
                price = price - 1.3;
            }
            int lenght = listBox1.Items.Count;
            for (int a = 0; a < lenght; a++)
            {
                if (listBox1.Items[a].ToString() == "Cheeseburger    1.3$")
                {
                    listBox1.Items.RemoveAt(a);
                    break;
                }
            }

        }
        int l18 = 0;
        private void button18_Click(object sender, EventArgs e)
        {
            l18 = l18 + 1;
            label18.Text = l18.ToString();
            price = price + 1.1;
            listBox1.Items.Add("Sandwich         1.1$");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label18.Text != "0")
            {
                l18 = l18 - 1;
                label18.Text = l18.ToString();
                price = price - 1.1;
            }
            int lenght = listBox1.Items.Count;
            for (int a = 0; a < lenght; a++)
            {
                if (listBox1.Items[a].ToString() == "Sandwich         1.1$")
                {
                    listBox1.Items.RemoveAt(a);
                    break;
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (label20.Text != "0")
            {
                price = price - 1.2;
                l20 = l20 - 1;
                label20.Text = l20.ToString();
            }
            int lenght = listBox1.Items.Count;
            for (int a = 0; a < lenght; a++)
            {
                if (listBox1.Items[a].ToString() == "Hamburger       1.2$")
                {
                    listBox1.Items.RemoveAt(a);
                    break;
                }
            }

        }
        int l31 = 0;
        private void button24_Click(object sender, EventArgs e)
        {
            price = price + 0.25;
            l31 = l31 + 1;
            label31.Text = l31.ToString();
            listBox1.Items.Add("Water 0.5L            0.25$");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (label31.Text != "0")
            {
                price = price - 0.25;
                l31 = l31 - 1;
                label31.Text = l31.ToString();
            }
            int lenght = listBox1.Items.Count;
            for (int a = 0; a < lenght; a++)
            {
                if (listBox1.Items[a].ToString() == "Water 0.5L            0.25$")
                {
                    listBox1.Items.RemoveAt(a);
                    break;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            price = price + 0.4;
            l30 = l30 + 1;
            label30.Text = l30.ToString();
            listBox1.Items.Add("Water 1L                 0.4$");
        }
        int l30 = 0;
        private void button15_Click(object sender, EventArgs e)
        {
            if (label30.Text != "0")
            {
                price = price - 0.4;
                l30 = l30 - 1;
                label30.Text = l30.ToString();
            }
            int lenght = listBox1.Items.Count;
            for (int a = 0; a < lenght; a++)
            {
                if (listBox1.Items[a].ToString() == "Water 1L                 0.4$")
                {
                    listBox1.Items.RemoveAt(a);
                    break;
                }
            }
        }
        int l29;
        private void button1_Click(object sender, EventArgs e)
        {
            if (label29.Text != "0")
            {
                price = price - 1;
                l29 = l29 - 1;
                label29.Text = l29.ToString();
            }
            int lenght = listBox1.Items.Count;
            for (int a = 0; a < lenght; a++)
            {
                if (listBox1.Items[a].ToString() == "Fruit juice               1.0$")
                {
                    listBox1.Items.RemoveAt(a);
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            price = price + 1;
            l29 = l29 + 1;
            label29.Text = l29.ToString();
            listBox1.Items.Add("Fruit juice               1.0$");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (price < 0)
            {
                price = 0;
                label25.Text = "Price: " + price + " $";
            }
            else //if(price>0)
            {
                label25.Text = "Price: " + price + " $";
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Form3 op = new Form3();
                op.Show();
                this.Hide();
            }
            else if (textBox1.Text == "kazher" && textBox2.Text == "kazher")
            {

            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void label24_Click(object sender, EventArgs e)
        {
            if (price != 0)
            {
                MessageBox.Show("You Send items","Hi Dear");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void costumerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            textBox1.Focus();
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label34_MouseHover(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void label34_MouseLeave(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void browserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer6.Enabled = true;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (browserToolStripMenuItem.Text == "open Browser")
            {
                this.Width = this.Width + 450;
                if (this.Width >= 1300)
                {
                    button26.Visible = true;
                    this.Width = 1300;
                    timer6.Stop();
                    webBrowser1.Visible = true;
                    browserToolStripMenuItem.Text = "close Browser";
                }
            }
            else
            {
                this.Width = this.Width - 450;
                if (this.Width <= 700)
                {
                    button26.Visible = false;
                    this.Width = 700;
                    timer6.Stop();
                    browserToolStripMenuItem.Text = "open Browser";
                    webBrowser1.Visible = false;
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Class1.a = webBrowser1.Url.ToString();
            this.Hide();
            Form4 op = new Form4();
            op.Show();
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void button27_Click(object sender, EventArgs e)
        {
        }
    }
}
