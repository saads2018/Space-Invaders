using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using static System.Console;


namespace WindowsFormsApplication1
{
    public partial class HighScores : Form
    {
        public string[] lines = File.ReadAllLines("HighScores.txt");

        public HighScores()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            DialogResult = DialogResult.None;
            DisplayHighScores();
        }

        private void HighScores_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.Beep(1000, 100);
            DialogResult = DialogResult.Cancel;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DisplayHighScores()
        {
            long i;
            long end = lines.Length;


            for (i = 0; i < end; i++)
            {
                label2.Text += lines[i] + Environment.NewLine;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
