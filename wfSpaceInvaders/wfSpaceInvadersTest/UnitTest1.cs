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
        public void CheckIfValuesInitialized()
        {
            frmInvaders frm = new frmInvaders();
            frm.InitializeValues();
            Assert.AreEqual(12, frm.inv1.Left);
            Assert.AreEqual(16, frm.inv2.Top);
            Assert.AreEqual(0, frm.ciclos);
            Assert.AreEqual(0, frm.aproximado);
            Assert.AreEqual(0, frm.score);
            Assert.AreEqual(130, frm.inv15.Top);
            Assert.AreEqual(404, frm.inv18.Left);
            frm.Dispose();

        }

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
        public void CheckIfCanonShoots()
        {
            frmInvaders frm = new frmInvaders();
            frm.InitializeValues();
            frm.CanonShoot();
            bool visible = frm.picTiroJog.Visible;
            int x = frm.picJog.Top;
            Assert.AreEqual(373, frm.picTiroJog.Left);
            Assert.AreEqual(x - 25, frm.picTiroJog.Top);
            Assert.AreEqual(false, frm.tirodisponivel);
            frm.Dispose();
        }


        [TestMethod]
        public void CheckIfInvaderIsDestroyed()
        {
            frmInvaders frm = new frmInvaders();
            frm.InitializeValues();
            frm.DestroyInvader(frm.inv1);
            Assert.AreEqual(false, frm.inv1.Visible);
            Assert.AreEqual(false, frm.picTiroJog.Visible);
            Assert.AreEqual(50, frm.score);
            Assert.AreEqual(true, frm.tirodisponivel);
            frm.Dispose();
        }
    }
}