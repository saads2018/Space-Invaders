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
    public partial class PlayerName : Form
    {
        public PlayerName()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            DialogResult = DialogResult.None;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult newGame = new DialogResult();
            frmInvaders frm = new frmInvaders();
            frm.Name = textBox1.Text;

            if (radioButton1.Checked)
                frm.picJog.Image = Properties.Resources.jogador;
            else if (radioButton2.Checked)
                frm.picJog.Image = Image.FromFile("../Pics/ClassicLaser.png");
            else if (radioButton3.Checked)
                frm.picJog.Image = Image.FromFile("../Pics/ModernLaser.png");

            PictureBox img=frm.inv1;

            if (radioButton6.Checked)
            {
                frm.pictureBox1.Image = null;
                img.Image = Properties.Resources.invader;
                frm.pícParede1.Image = Properties.Resources.barreira;
                frm.pícParede2.Image = Properties.Resources.barreira;
            }
            else if (radioButton5.Checked)
            {
                frm.pictureBox1.Image = Image.FromFile("../Pics/ClassicBackground.jpg");
                img.Image= Image.FromFile("../Pics/ClassicEnemy.png");
                frm.pícParede1.Image = Image.FromFile("../Pics/ClassicBunk.png");
                frm.pícParede2.Image = Image.FromFile("../Pics/ClassicBunk.png");
             
            }
            else if (radioButton4.Checked)
            {
                frm.pictureBox1.Image = Image.FromFile("../Pics/Modern.jpg");
                img.Image = Image.FromFile("../Pics/ModernEnemy.png");
                frm.pícParede1.Image = Image.FromFile("../Pics/ModernBunker.png");
                frm.pícParede2.Image = Image.FromFile("../Pics/ModernBunker.png");

            }


            frm.inv1.Image = img.Image;
            frm.inv2.Image = img.Image;
            frm.inv3.Image = img.Image;
            frm.inv4.Image = img.Image;
            frm.inv5.Image = img.Image;
            frm.inv6.Image = img.Image;
            frm.inv7.Image = img.Image;
            frm.inv8.Image = img.Image;
            frm.inv9.Image = img.Image;
            frm.inv10.Image = img.Image;
            frm.inv11.Image = img.Image;
            frm.inv12.Image = img.Image;
            frm.inv13.Image = img.Image;
            frm.inv14.Image = img.Image;
            frm.inv15.Image = img.Image;
            frm.inv16.Image = img.Image;
            frm.inv17.Image = img.Image;
            frm.inv18.Image = img.Image;

            newGame = frm.ShowDialog();
            DialogResult = DialogResult.Cancel;
            
        }

        private void PlayerName_Load(object sender, EventArgs e)
        {

        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        
    }
}
