using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;



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

        [TestMethod]
        public void CheckIfGameOver()
        {
            frmInvaders frm = new frmInvaders();
            frm.InitializeValues();
            Assert.AreEqual(false, frm.btnNovoJogo.Enabled);
            Assert.AreEqual(true, frm.gamestart);
            frm.GameOver();
            Assert.AreEqual(true, frm.btnNovoJogo.Enabled);
            Assert.AreEqual(false, frm.gamestart);
            frm.Dispose();
        }


    }
}
