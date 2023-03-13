using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Zodiac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "berbec.txt";
            StreamReader x = new StreamReader(path);
            string text = x.ReadLine();
            textBox1.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "taur.txt";
            StreamReader x = new StreamReader(path);
            string text = x.ReadLine();
            textBox1.Text = text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "rac.txt";
            StreamReader x = new StreamReader(path);
            string text = x.ReadLine();
            textBox1.Text = text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "gemeni.txt";
            StreamReader x = new StreamReader(path);
            string text = x.ReadLine();
            textBox1.Text = text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "leu.txt";
            StreamReader x = new StreamReader(path);
            string text = x.ReadLine();
            textBox1.Text = text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "fecioara.txt";
            StreamReader x = new StreamReader(path);
            string text = x.ReadLine();
            textBox1.Text = text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "balanta.txt";
            StreamReader x = new StreamReader(path);
            string text = x.ReadLine();
            textBox1.Text = text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "scorpion.txt";
            StreamReader x = new StreamReader(path);
            string text = x.ReadLine();
            textBox1.Text = text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "capricorn.txt";
            StreamReader x = new StreamReader(path);
            string text = x.ReadLine();
            textBox1.Text = text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "varsator.txt";
            StreamReader x = new StreamReader(path);
            string text = x.ReadLine();
            textBox1.Text = text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "pesti.txt";
            StreamReader x = new StreamReader(path);
            string text = x.ReadLine();
            textBox1.Text = text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "sagetator.txt";
            StreamReader x = new StreamReader(path);
            string text = x.ReadLine();
            textBox1.Text = text;
        }
    }
}
