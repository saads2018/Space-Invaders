using System;
using System.Windows.Forms;
using System.IO;
using static System.Console;
using System.ComponentModel;
using System.Media;

namespace WindowsFormsApplication1
{
    /*  Winforms Space Invaders
     *  This is a little space invaders inspired game made in windows forms
     *  
     *  Alessandro Gomez
     *  2010 - 2019
     */
    public partial class frmInvaders : Form
    {
        public static int numinvaders = 18;
        public bool gamestart = false;
        public bool invble = false;
        public bool tirodisponivel = true;
        public bool tirodisponivelmon = true;
        public int movimento = 5;
        public int movimento2 = 40;
        public int ciclos = 0;
        public int perkInUse = 0;
        public int aproximado = 0;
        public int score = 0;
        public string Name = "";
        public int canonMove = 0;
        public int randomPerk, location;
        public int perkCycles = 0;
        public int lives = 6;
        public PictureBox[] colecao = new PictureBox[numinvaders + 1];
        public PictureBox[] livesAvailable = new PictureBox[3];
        public PictureBox[] perks = new PictureBox[2];
        public int canonMovement = 40;
        public int cyclesCount = 1;
        public int livesCount = 1;
        public bool perkUse = false;
        public frmInvaders()
        {
            InitializeComponent();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (gamestart)
            {
                // Movimenta os Invaders (Move Invaders Left or Right)
                for (int i = 1; i <= numinvaders; i++)
                {
                    PictureBox img = colecao[i];
                    img.Left += movimento;
                }

                ciclos++;
                if (ciclos == 62 / cyclesCount)
                {
                    movimento *= -1;
                    ciclos = 0;

                    // Movimenta os Invaders um pouco Abaixo (Move invaders a little down)
                    for (int i = 1; i <= numinvaders; i++)
                    {
                        PictureBox img = colecao[i];
                        img.Top += movimento2;
                    }
                    aproximado++;

                    if (aproximado == 8)
                    {
                        // Gameover quando invaders atingem posição abaixo (GameOver by Invasion)
                        SoundPlayer simpleSound = new SoundPlayer("../Media/explosion.wav");
                        simpleSound.Play();

                        File.AppendAllText("HighScores.txt",
                             (Name + ":" + score + "   ") + Environment.NewLine);
                        lives = livesCount;
                        SetLives();
                        GameOver();
                        MessageBox.Show("Game Over!\nYou Lose");
                        picTiroMon.Visible = false;
                        picTiroJog.Visible = false;
                        timer1.Enabled = false;
                        if (movimento < 0)
                        {
                            movimento *= -1;
                        }
                        Application.DoEvents();

                    }
                }
            }
        }

        // Reinicia o game (Reset Routine)
        public void btnNovoJogo_Click_1(object sender, EventArgs e)
        {
            Console.Beep(1000, 100);
            if (gamestart == false)
            {
                InitializeValues();
            }
        }

        // Detecta teclas pressionadas (Player Input Routine)
        public void frmInvaders_KeyPress(object sender, KeyPressEventArgs e)
        {
            int n = e.KeyChar;

            CanonMovement(n);

            // Atirar (Shoot)
            if (gamestart && tirodisponivel && n == 32 && ((picJog.Left < 80) || ((picJog.Left > 230) && (picJog.Left < 490)) || (picJog.Left > 630)))
            {
                CanonShoot();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)

        {
            if (gamestart)
            {
                // Rotina que lida com tiro do jogador caso tenha atirado (If the player has shooted)
                if (picTiroJog.Visible == true)
                {
                    // Move o tiro acima (Move the player shoot)
                    picTiroJog.Top -= 10;

                    // Checa se o tiro acerta algum invader (Check if player shot collides with any alive Invader)
                    for (int j = 1; j <= numinvaders; j++)
                    {
                        PictureBox img = colecao[j];
                        if (img.Visible == true)
                        {
                            if (Math.Abs(img.Left - picTiroJog.Left) < 30 && Math.Abs(img.Top - picTiroJog.Top) < 10)
                            {
                                DestroyInvader(img);
                                break;
                            }
                        }
                    }

                    // Destroi o tiro do jogador se chegou ao limite (Destroy Shoot by reaching limit)
                    if (picTiroJog.Top < 25)
                    {
                        picTiroJog.Visible = false;
                        tirodisponivel = true;
                    }

                    // Jogador vence se derrotou todos invaders (When the player wins the game by killing all invaders)
                    if (score == 900)
                    {
                        File.AppendAllText("HighScores.txt",
                            (Name + ":" + score + "   ") + Environment.NewLine);
                        lives = livesCount;
                        SetLives();
                        MessageBox.Show("Congratulations!\nYou Win!");
                        if (movimento < 0)
                        {
                            movimento *= -1;
                        }
                        GameOver();
                    }
                }

                perks[0] = pictureBox5;
                perks[1] = pictureBox6;

                livesAvailable[0] = pictureBox2;
                livesAvailable[1] = pictureBox3;
                livesAvailable[2] = pictureBox4;

                // Atira aleatoriamente (Invaders shoots randomly)
                Random rand = new Random();
                int a = rand.Next(0, 25);

                if (tirodisponivelmon == true && a == 5)
                {
                    // Escolhe Quem Atira, Posiciona o Tiro e Aiva (Pick whom of the invaders will shoot)
                    // The .NET Random Upper is not inclusive!! This sucks!!!
                    int q = rand.Next(1, 19);
                    PictureBox img = colecao[q];

                    // The shooter must be alive
                    if (img.Visible == true)
                    {
                        picTiroMon.Visible = true;
                        picTiroMon.Left = img.Left;
                        picTiroMon.Top = img.Top + 40;
                        tirodisponivelmon = false;
                    }
                }

                // Caso algum invader tenha disparado (If some invader has shooted, move the shoot down)
                if (picTiroMon.Visible == true)
                {
                    // Move o tiro abaixo (Move the invader shoot a little down)
                    picTiroMon.Top += 10;

                    // Checa colisão com o Jogador (Check invader shoot collision with player)
                    PictureBox img = picJog;
                    if ((Math.Abs(img.Left - picTiroMon.Left) < 30 && Math.Abs(img.Top - picTiroMon.Top) < 10) && invble == false)
                    {
                        RemoveLives();
                        lives -= 1;
                        if (lives == 0)
                        {
                            // GameOver
                            SoundPlayer simpleSound = new SoundPlayer("../Media/explosion.wav");
                            simpleSound.Play();
                            File.AppendAllText("HighScores.txt",
                            (Name + ":" + score + "   ") + Environment.NewLine);
                            lives = livesCount;
                            SetLives();
                            picTiroMon.Visible = false;
                            picTiroJog.Visible = false;
                            tirodisponivelmon = true;
                            if (movimento < 0)
                            {
                                movimento *= -1;
                            }
                            GameOver();
                            MessageBox.Show("Game Over!\nYou Lose");
                            timer1.Enabled = false;
                            Application.DoEvents();

                        }
                    }

                    perkCycles++;
                    Random rnd = new Random();
                    if (perkCycles == 70)
                    {
                        randomPerk = rnd.Next(perks.Length);
                        location = rnd.Next(26, 752);
                        perkInUse = 0;
                        perkUse = false;
                        perks[randomPerk].Visible = true;
                        perks[randomPerk].Location = new System.Drawing.Point(location, 495);
                        perks[randomPerk].Left = location;
                    }

                    if (perkCycles == 150 && perkInUse == 0)
                    {
                        perkCycles = 0;
                        perks[randomPerk].Visible = false;
                    }


                    if (perks[0].Visible == true)
                    {
                        if (picJog.Left > perks[randomPerk].Left - 40 && picJog.Left < perks[randomPerk].Left + 40)
                        {
                            perks[0].Visible = false;
                            SpeedPerk();
                        }
                    }
                    else if (perks[1].Visible == true)
                    {
                        if (picJog.Left > perks[randomPerk].Left - 40 && picJog.Left < perks[randomPerk].Left + 40)
                        {
                            perks[1].Visible = false;
                            InvincibilityPerk();
                        }
                    }

                    if (perkUse)
                        perkInUse++;

                    if (perkInUse >= 170)
                    {
                        perkCycles = 0;
                        perkInUse = 0;
                        perkUse = false;
                        canonMovement = canonMove;
                        invble = false;
                    }

                    // Destroi o tiro caso chegue ao limite (Destroys the shoot if it reaches the lower limit)
                    if (picTiroMon.Top > 500 || ((picTiroMon.Top > 430) && ((picTiroMon.Left > 100) && (picTiroMon.Left < 240))) || ((picTiroMon.Top > 430) && ((picTiroMon.Left > 500) && (picTiroMon.Left < 630))))
                    {
                        picTiroMon.Visible = false;
                        tirodisponivelmon = true;
                    }

                }
            }
        }

        private void frmInvaders_Load(object sender, EventArgs e)
        {



            // Invaders
            colecao[1] = inv1;
            colecao[2] = inv2;
            colecao[3] = inv3;
            colecao[4] = inv4;
            colecao[5] = inv5;
            colecao[6] = inv6;
            colecao[7] = inv7;
            colecao[8] = inv8;
            colecao[9] = inv9;
            colecao[10] = inv10;
            colecao[11] = inv11;
            colecao[12] = inv12;
            colecao[13] = inv13;
            colecao[14] = inv14;
            colecao[15] = inv15;
            colecao[16] = inv16;
            colecao[17] = inv17;
            colecao[18] = inv18;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picJog_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        void RemoveLives()
        {
            if (lives % 2 == 0)
                livesAvailable[(lives / 2) - 1].Visible = false;
        }

        void SetLives()
        {
            for (int i = 0; i < 3; i++)
            {
                livesAvailable[i].Visible = true;
            }

            for (int i = 2; i > lives / 3; i--)
            {
                livesAvailable[i].Visible = false;
            }
        }


        public void CanonMovement(int n)
        {
            // Esquerda (Left)
            if (gamestart && (n == 52 || n == 97) && picJog.Left > 25)
            {
                picJog.Left -= canonMovement;
            }

            // Direita (Right)
            if (gamestart && (n == 54 || n == 100) && picJog.Left < 720)
            {
                picJog.Left += canonMovement;
            }
        }

        public void CanonShoot()
        {
            SoundPlayer simpleSound = new SoundPlayer("../Media/shoot.wav");
            simpleSound.Play();
            picTiroJog.Left = picJog.Left + 18;
            picTiroJog.Top = picJog.Top - 25;
            picTiroJog.Visible = true;
            tirodisponivel = false;
        }

        public void DestroyInvader(PictureBox img)
        {
            img.Visible = false;
            picTiroJog.Visible = false;
            score += 50;
            lblScore.Text = score.ToString();
            tirodisponivel = true;
            SoundPlayer simpleSound = new SoundPlayer("../Media/invaderkilled.wav");
            simpleSound.Play();
        }

        public void SpeedPerk()
        {
            perkUse = true;
            canonMovement += 10;
        }

        public void InvincibilityPerk()
        {
            perkUse = true;
            invble = true;
        }

        public void GameOver()
        {
            btnNovoJogo.Enabled = true;
            gamestart = false;
        }

        public void InitializeValues()
        {
            inv1.Visible = true;
            inv2.Visible = true;
            inv3.Visible = true;
            inv4.Visible = true;
            inv5.Visible = true;
            inv6.Visible = true;
            inv7.Visible = true;
            inv8.Visible = true;
            inv9.Visible = true;
            inv10.Visible = true;
            inv11.Visible = true;
            inv12.Visible = true;
            inv13.Visible = true;
            inv14.Visible = true;
            inv15.Visible = true;
            inv16.Visible = true;
            inv17.Visible = true;
            inv18.Visible = true;

            inv1.Top = 16;
            inv2.Top = 16;
            inv3.Top = 16;
            inv4.Top = 16;
            inv5.Top = 16;
            inv6.Top = 16;
            inv7.Top = 73;
            inv8.Top = 73;
            inv9.Top = 73;
            inv10.Top = 73;
            inv11.Top = 73;
            inv12.Top = 73;
            inv13.Top = 130;
            inv14.Top = 130;
            inv15.Top = 130;
            inv16.Top = 130;
            inv17.Top = 130;
            inv18.Top = 130;

            inv1.Left = 12;
            inv2.Left = 93;
            inv3.Left = 171;
            inv4.Left = 247;
            inv5.Left = 325;
            inv6.Left = 404;
            inv7.Left = 28;
            inv8.Left = 109;
            inv9.Left = 187;
            inv10.Left = 263;
            inv11.Left = 341;
            inv12.Left = 420;
            inv13.Left = 12;
            inv14.Left = 93;
            inv15.Left = 171;
            inv16.Left = 247;
            inv17.Left = 325;
            inv18.Left = 404;
            movimento2 = 40;
            ciclos = 0;
            aproximado = 0;
            score = 0;
            picTiroJog.Visible = false;
            picTiroMon.Visible = false;
            tirodisponivel = true;
            tirodisponivelmon = true;
            picJog.Left = 355;
            gamestart = true;
            timer1.Enabled = true;
            btnNovoJogo.Enabled = false;
            panel1.Focus();
            pictureBox5.Left = 20;
            pictureBox6.Left = 20;
            lblScore.Text = "0";

        }



    }
}
