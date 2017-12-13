using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        PictureBox[] pictureBoxs = new PictureBox[9];



        public Form1()
        {
            InitializeComponent();

            pictureBoxs[0] = pictureBox1;
            pictureBoxs[1] = pictureBox2;
            pictureBoxs[2] = pictureBox3;
            pictureBoxs[3] = pictureBox4;
            pictureBoxs[4] = pictureBox5;
            pictureBoxs[5] = pictureBox6;
            pictureBoxs[6] = pictureBox7;
            pictureBoxs[7] = pictureBox8;
            pictureBoxs[8] = pictureBox9;
        }

        List<PictureBox> pictureBoxes = new List<PictureBox>();

        private void button1_Click(object sender, EventArgs e)
        {
            Random gen = new Random();
            int [] tab = new int[9];
            for(int i = 0; i < 9; i++)
            {
                tab[i] = gen.Next(1, 9);
            }

                pictureBoxs[tab[0]].Image = WindowsFormsApp6.Properties.Resources._1;
            pictureBoxs[tab[1]].Image = WindowsFormsApp6.Properties.Resources._2;
            pictureBoxs[tab[2]].Image = WindowsFormsApp6.Properties.Resources._3;
            pictureBoxs[tab[3]].Image = WindowsFormsApp6.Properties.Resources._4;
            pictureBoxs[tab[4]].Image = WindowsFormsApp6.Properties.Resources._5;
            pictureBoxs[tab[5]].Image = WindowsFormsApp6.Properties.Resources._6;
            pictureBoxs[tab[6]].Image = WindowsFormsApp6.Properties.Resources._7;
            pictureBoxs[tab[7]].Image = WindowsFormsApp6.Properties.Resources._8;
            pictureBoxs[tab[8]].Image = WindowsFormsApp6.Properties.Resources._9;
        }

        










        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
