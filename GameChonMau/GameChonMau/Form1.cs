using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameChonMau
{
    public partial class Form1 : Form
    {
        int k; // đánh dấu
        int point = 0; // điểm đạt được
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetColor();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (k == 4) {
                point++;
                label1.Text = point.ToString();
                SetColor();
            }
        }
        public void SetColor()
        {
            Random p = new Random();
            
            int x = p.Next(0, 255);
            int y = p.Next(0, 255);         // màu ngẫu nhiên
            int z = p.Next(30, 255);

            Random q = new Random();
            k = q.Next(1,9);        // ô ngẫu nhiên khác màu
           
            if (k == 1)
            {
                button1.BackColor = Color.FromArgb(x, y, z - 30);
           
            }
            else button1.BackColor = Color.FromArgb(x, y, z);
            if (k == 2)
            {
                button2.BackColor = Color.FromArgb(x, y, z - 30);
                
            }
            else button2.BackColor = Color.FromArgb(x, y, z);
            if (k == 3)
            {
                button3.BackColor = Color.FromArgb(x, y, z - 30);
              
            }
            else button3.BackColor = Color.FromArgb(x, y, z);
            if (k == 4)
            {
                button4.BackColor = Color.FromArgb(x, y, z - 30);
                
            }
            else button4.BackColor = Color.FromArgb(x, y, z);
            if (k == 5)
            {
                button5.BackColor = Color.FromArgb(x, y, z - 30);
               
            }
            else button5.BackColor = Color.FromArgb(x, y, z);
            if (k == 6)
            {
                button6.BackColor = Color.FromArgb(x, y, z - 30);
            }

            else button6.BackColor = Color.FromArgb(x, y, z);
            if (k == 7)
            {
                button7.BackColor = Color.FromArgb(x, y, z - 30);
                
            }
            else button7.BackColor = Color.FromArgb(x, y, z);
            if (k == 8)
            {
                button8.BackColor = Color.FromArgb(x, y, z - 30);
              
            }
            else button8.BackColor = Color.FromArgb(x, y, z);
            if (k == 9)
            {
                button9.BackColor = Color.FromArgb(x, y, z - 30);
               
            }
            else button9.BackColor = Color.FromArgb(x, y, z);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (k == 5)
            {
                point++;
                label1.Text = point.ToString();
                SetColor();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (k == 1)
            {
                point++;
                label1.Text = point.ToString();
                SetColor();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (k == 2)
            {
                point++;
                label1.Text = point.ToString();
                SetColor();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (k == 3)
            {
                point++;
                label1.Text = point.ToString();
                SetColor();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (k == 6)
            {
                point++;
                label1.Text = point.ToString();
                SetColor();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (k == 7)
            {
                point++;
                label1.Text = point.ToString();
                SetColor();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (k == 8)
            {
                point++;
                label1.Text = point.ToString();
                SetColor();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (k == 9)
            {
                point++;
                label1.Text = point.ToString();
                SetColor();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
