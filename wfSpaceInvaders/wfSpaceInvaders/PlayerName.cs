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
        public frmInvaders frm = new frmInvaders();
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
            Console.Beep(1000, 100);
            DialogResult newGame = new DialogResult();
            enterUsername();

            PictureBox img1 = frm.picJog;
            if (radioButton1.Checked)
            {
                frm.picJog.Image = Properties.Resources.jogador;
                img1.Image = frm.picJog.Image;
            }
            else if (radioButton2.Checked)
            {
                frm.picJog.Image = Image.FromFile("../Pics/ClassicLaser.png");
                img1.Image = frm.picJog.Image;
            }
            else if (radioButton3.Checked)
            {
                frm.picJog.Image = Image.FromFile("../Pics/ModernLaser.png");
                img1.Image = frm.picJog.Image;
            }

            frm.pictureBox2.Image = img1.Image;
            frm.pictureBox3.Image = img1.Image;
            frm.pictureBox4.Image = img1.Image;

            PictureBox img = frm.inv1;

            if (radioButton6.Checked)
            {
                chooseGameTheme(1);
            }
            else if (radioButton5.Checked)
            {
                chooseGameTheme(2);
            }
            else if (radioButton4.Checked)
            {
                chooseGameTheme(3);
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

            if (radioButton9.Checked)
            {
                chooseDifficulty(1);
            }
            else if (radioButton8.Checked)
            {
                chooseDifficulty(2);
            }
            else if (radioButton7.Checked)
            {
                chooseDifficulty(3);
            }


            newGame = frm.ShowDialog();
            DialogResult = DialogResult.Cancel;

        }

        private void PlayerName_Load(object sender, EventArgs e)
        {

        }

        public void chooseDifficulty(int choice)
        {
            if (choice == 1)
            {
                frm.canonMovement = 25;
                frm.canonMove = 25;
                frm.movimento = 5;
                frm.cyclesCount = 1;
                frm.lives = 6;
                frm.livesCount = 6;
            }
            else if (choice == 2)
            {
                frm.canonMovement = 15;
                frm.canonMove = 15;
                frm.movimento = 10;
                frm.cyclesCount = 2;
                frm.lives = 4;
                frm.pictureBox4.Visible = false;
                frm.livesCount = 4;
            }
            else if (choice == 3)
            {
                frm.canonMovement = 5;
                frm.canonMove = 5;
                frm.movimento = 15;
                frm.cyclesCount = 3;
                frm.lives = 2;
                frm.livesCount = 2;
                frm.pictureBox4.Visible = false;
                frm.pictureBox3.Visible = false;
            }
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

        public void chooseGameTheme(int choice)
        {
            PictureBox img = frm.inv1;
            if (choice == 1)
            {
                frm.pictureBox1.Image = null;
                img.Image = Properties.Resources.invader;
                frm.pícParede1.Image = Properties.Resources.barreira;
                frm.pícParede2.Image = Properties.Resources.barreira;
            }
            else if (choice == 2)
            {
                frm.pictureBox1.Image = Image.FromFile("../Pics/ClassicBackground.jpg");
                img.Image = Image.FromFile("../Pics/ClassicEnemy.png");
                frm.pícParede1.Image = Image.FromFile("../Pics/ClassicBunk.png");
                frm.pícParede2.Image = Image.FromFile("../Pics/ClassicBunk.png");
            }
            else if (choice == 3)
            {
                frm.pictureBox1.Image = Image.FromFile("../Pics/Modern.jpg");
                img.Image = Image.FromFile("../Pics/ModernEnemy.png");
                frm.pícParede1.Image = Image.FromFile("../Pics/ModernBunker.png");
                frm.pícParede2.Image = Image.FromFile("../Pics/ModernBunker.png");
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

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void enterUsername()
        {
            if (textBox1.Text == "")
                frm.Name = "Username Missing";
            else
                frm.Name = textBox1.Text;
        }



    }
}
