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
            File.AppendAllText("HighScores.txt",
            (Environment.NewLine+textBox1.Text+":"));
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


    }
}
