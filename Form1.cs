using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Объявление необходимых переменных
            int x, y, zn, temp, count=0;
            double z=0.0;
            char[] zz;
            zz = new char[17];
            //Задание входных переменных
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            //Определение выходной переменной на основании правил
            if (x==y)
            {
                textBox3.Text = "0";
                textBox4.Text = "0";
            } else
            if (x > y)
            {
                if (x < 2 && y < 2)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }
                if (x < 2 && y >= 0 && y < 4)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }
                if (x < 2 && y >= 2 && y < 6)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }
                if (x < 2 && y >= 4)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }

                if (x >= 0 && x < 4 && y < 2)
                {
                    count = count + 1;
                    zz[count] = 'S';
                }
                if (x >= 0 && x < 4 && y >= 0 && y < 4)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }
                if (x >= 0 && x < 4 && y >= 2 && y < 6)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }
                if (x >= 0 && x < 4 && y >= 4)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }

                if (x >= 2 && x < 6 && y < 2)
                {
                    count = count + 1;
                    zz[count] = 'M';
                }
                if (x >= 2 && x < 6 && y >= 0 && y < 4)
                {
                    count = count + 1;
                    zz[count] = 'S';
                }
                if (x >= 2 && x < 6 && y >= 2 && y < 6)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }
                if (x >= 2 && x < 6 && y >= 4)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }

                if (x >= 4 && y < 2)
                {
                    count = count + 1;
                    zz[count] = 'L';
                }
                if (x >= 4 && y >= 0 && y < 4)
                {
                    count = count + 1;
                    zz[count] = 'M';
                }
                if (x >= 4 && y >= 2 && y < 6)
                {
                    count = count + 1;
                    zz[count] = 'S';
                }
                if (x >= 4 && y >= 4)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }

                for (int i = 1; i <= count; i++)
                {
                    listBox1.Items.Add(Convert.ToString(zz[i]));
                    if (zz[i] == 'Z')
                    {
                        zn = 0;
                        z = z + zn;
                    }
                    if (zz[i] == 'S')
                    {
                        zn = 2;
                        z = z + zn;
                    }
                    if (zz[i] == 'M')
                    {
                        zn = 4;
                        z = z + zn;
                    }
                    if (zz[i] == 'L')
                    {
                        zn = 6;
                        z = z + zn;
                    }
                }
                z = z / count;
                textBox3.Text = Convert.ToString(z);
                textBox4.Text = "0";
            } else
            {
                temp = x;
                x = y;
                y = temp;
                if (x < 2 && y < 2)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }
                if (x < 2 && y >= 0 && y < 4)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }
                if (x < 2 && y >= 2 && y < 6)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }
                if (x < 2 && y >= 4)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }

                if (x >= 0 && x < 4 && y < 2)
                {
                    count = count + 1;
                    zz[count] = 'S';
                }
                if (x >= 0 && x < 4 && y >= 0 && y < 4)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }
                if (x >= 0 && x < 4 && y >= 2 && y < 6)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }
                if (x >= 0 && x < 4 && y >= 4)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }

                if (x >= 2 && x < 6 && y < 2)
                {
                    count = count + 1;
                    zz[count] = 'M';
                }
                if (x >= 2 && x < 6 && y >= 0 && y < 4)
                {
                    count = count + 1;
                    zz[count] = 'S';
                }
                if (x >= 2 && x < 6 && y >= 2 && y < 6)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }
                if (x >= 2 && x < 6 && y >= 4)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }

                if (x >= 4 && y < 2)
                {
                    count = count + 1;
                    zz[count] = 'L';
                }
                if (x >= 4 && y >= 0 && y < 4)
                {
                    count = count + 1;
                    zz[count] = 'M';
                }
                if (x >= 4 && y >= 2 && y < 6)
                {
                    count = count + 1;
                    zz[count] = 'S';
                }
                if (x >= 4 && y >= 4)
                {
                    count = count + 1;
                    zz[count] = 'Z';
                }

                for (int i = 1; i <= count; i++)
                {
                    listBox1.Items.Add(Convert.ToString(zz[i]));
                    if (zz[i] == 'Z')
                    {
                        zn = 0;
                        z = z + zn;
                    }
                    if (zz[i] == 'S')
                    {
                        zn = 2;
                        z = z + zn;
                    }
                    if (zz[i] == 'M')
                    {
                        zn = 4;
                        z = z + zn;
                    }
                    if (zz[i] == 'L')
                    {
                        zn = 6;
                        z = z + zn;
                    }
                }
                z = z / count;
                textBox3.Text = "0";
                textBox4.Text = Convert.ToString(z);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int x, y, zn, temp, count = 0;
            double z = 0.0;
            char[] zz;
            zz = new char[17];
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            listBox1.Items.Clear();
        }
    }
}
