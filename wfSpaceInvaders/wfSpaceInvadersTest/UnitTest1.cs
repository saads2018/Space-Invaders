using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
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


namespace wfSpaceInvadersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckCanonMovement()
        {
            frmInvaders frm = new frmInvaders();
            frm.InitializeValues();
            int pressLeftArrowKey = 97;
            frm.CanonMovement(pressLeftArrowKey);
            Assert.AreEqual(315, frm.picJog.Left);
            int pressRightArrowKey = 100;
            frm.CanonMovement(pressRightArrowKey);
            Assert.AreEqual(355, frm.picJog.Left);
            frm.Dispose();
        }



        [TestMethod]
        public void CheckDifficulty()
        {
            PlayerName pl = new PlayerName();
            pl.frm.InitializeValues();
            pl.chooseDifficulty(2);
            Assert.AreEqual(15, pl.frm.canonMovement);
            Assert.AreEqual(10, pl.frm.movimento);
            Assert.AreEqual(2, pl.frm.cyclesCount);
            Assert.AreEqual(4, pl.frm.lives);
            Assert.AreEqual(15, pl.frm.canonMovement);
            pl.Dispose();
        }

        [TestMethod]
        public void CheckUsernameInputSuccessful()
        {
            PlayerName pl = new PlayerName();
            pl.textBox1.Text = "";
            pl.enterUsername();
            Assert.AreEqual("Username Missing", pl.frm.Name);
            pl.textBox1.Text = "Saad";
            pl.enterUsername();
            Assert.AreEqual("Saad", pl.frm.Name);
            pl.Dispose();
        }


    }
}
