// i honestly think this is the simplest and laziest app i ever made
// feel free to get inspired from this "code"

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scammer_Toolkit_X
{
    public partial class Form1 : Form
    {

        public int Points = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.support.me");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.gotoassist.com");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.google.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Points = Points + 5;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Points = Points + 5;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Points = Points + 10;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Points = Points + 15;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Points = Points + 5;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Points = Points + 10;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Points = Points + 5;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Points = Points + 15;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Points = Points + 20;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Points = Points + 5;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Points = Points + 5;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Points = Points + 15;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Points = Points + 25;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Points = Points + 5;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Points = Points + 15;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Points = Points + 20;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Points = Points + 5;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Points = Points + 5;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Points = Points + 5;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Points = Points + 5;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Points = 0;
            label1.Text = "Scammer points: " + Points.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://github.com/swoopae/scammertoolkitx/");
        }
    }
}
