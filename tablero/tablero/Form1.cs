using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tablero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            contador = 0;
        }
        int contador;
        string imagen;
        int[,] pos = new int[3,3];
        private void pintar(int f, int c)
        {
            if (contador % 2 == 0)
            {
                imagen = "x.png";
                pos[f, c] = 1;
            }

            else
            {
                imagen = "o.png";
                pos[f,c] = 2;
            }
            contador++;
        }
        private void XoO(int f, int j)
        {
            if (pos[f, j] == 1)
                MessageBox.Show("ganador X");
            if (pos[f, j] == 2)
                MessageBox.Show("ganador O");
        }

        private void comprobar()
        {
            for (int j = 0; j < 3; j++)
            {
                if (pos[0, j] == pos[1, j] && pos[2, j] == pos[1, j])
                {
                    XoO(0, j);  
                }
            }
            for (int j = 0; j < 3; j++)
            {
                if (pos[j, 0] == pos[j, 1] && pos[j, 2] == pos[j, 1])
                {
                    XoO(j, 0);
                }
            }
            if (pos[0, 0] == pos[1, 1] && pos[2, 2] == pos[1, 1])
            {
                XoO(0, 0); ;
            }
            if (pos[0, 2] == pos[1, 1] && pos[2, 0] == pos[1, 1])
            {
                XoO(0, 2);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pintar(0,0);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(imagen);
            comprobar();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pintar(2,1);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.Image = Image.FromFile(imagen);
            comprobar();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pintar(2,2);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.Image = Image.FromFile(imagen);
            comprobar();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pintar(1,0);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile(imagen);
            comprobar();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pintar(1,1);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile(imagen);
            comprobar();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pintar(1,2);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile(imagen);
            comprobar();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pintar(0,2);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile(imagen);
            comprobar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pintar(0,1);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile(imagen);
            comprobar();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pintar(2,0);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Image.FromFile(imagen);
            comprobar();
        }
    }
}
