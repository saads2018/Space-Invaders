﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult newGame = new DialogResult();
            frmInvaders frm = new frmInvaders();
            newGame = frm.ShowDialog();
            
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           MessageBox.Show("Welcome to Space Invaders!\nNum 4 or A - To Move Left\nNum 6 or D - To Move Right\nSpace - To Shoot");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            DialogResult hs = new DialogResult();
            HighScores frm = new HighScores();
            hs = frm.ShowDialog();

        }



  
        

    }
}