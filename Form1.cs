using System;
using System.Windows.Forms;

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
        public bool tirodisponivel = true;
        public bool tirodisponivelmon = true;
        public int movimento = 5;
        public int movimento2 = 40;
        public int ciclos = 0;
        public int aproximado = 0;
        public int score = 0;

        public PictureBox[] colecao = new PictureBox[numinvaders + 1];

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
                if (ciclos == 62)
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
                        btnNovoJogo.Enabled = true;
                        gamestart = false;
                        MessageBox.Show("Fim Do Jogo!\nVocê Perdeu\nGame Over!\nYou Lose");
                        picTiroMon.Visible = false;
                        picTiroJog.Visible = false;
                        timer1.Enabled = false;
                        Application.DoEvents();
                    }
                }
            }
        }

        // Reinicia o game (Reset Routine)
        public void btnNovoJogo_Click(object sender, EventArgs e)
        {
            if (gamestart == false)
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
                movimento = 5;
                movimento2 = 40;
                ciclos = 0;
                aproximado = 0;
                score = 0;
                picTiroJog.Visible = false;
                picTiroMon.Visible = false;
                tirodisponivel = true;
                tirodisponivelmon = true;
                picJog.Left = 345;
                gamestart = true;
                timer1.Enabled = true;
                btnNovoJogo.Enabled = false;
                panel1.Focus();
                lblScore.Text = "Score: 0";
            }
        }

        // Detecta teclas pressionadas (Player Input Routine)
        public void frmInvaders_KeyPress(object sender, KeyPressEventArgs e)
        {
            int n = e.KeyChar;

            // Esquerda (Left)
            if (gamestart && (n == 52 || n == 97) && picJog.Left > 25)
            {
                picJog.Left -= 15;
            }

            // Direita (Right)
            if (gamestart && (n == 54 || n == 100) && picJog.Left < 720)
            {
                picJog.Left += 15;
            }

            // Atirar (Shoot)
            if (gamestart && tirodisponivel && n == 32 && ((picJog.Left < 80) || ((picJog.Left > 230) && (picJog.Left < 490)) || (picJog.Left > 630)))
            {
                picTiroJog.Left = picJog.Left + 18;
                picTiroJog.Top = picJog.Top - 25;
                picTiroJog.Visible = true;
                tirodisponivel = false;
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
                                img.Visible = false;
                                picTiroJog.Visible = false;
                                score += 50;
                                lblScore.Text = "Score: " + score;
                                tirodisponivel = true;
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
                        MessageBox.Show("Parabéns!!!\nVocê Venceu!\nCongratulations!\nYou Win!");
                        btnNovoJogo.Enabled = true;
                        gamestart = false;
                    }
                }

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

                    if (Math.Abs(img.Left - picTiroMon.Left) < 30 && Math.Abs(img.Top - picTiroMon.Top) < 10)
                    {
                        // GameOver
                        picTiroMon.Visible = false;
                        picTiroJog.Visible = false;
                        tirodisponivelmon = true;
                        btnNovoJogo.Enabled = true;
                        gamestart = false;
                        MessageBox.Show("Fim Do Jogo!\nVocê Perdeu\nGame Over!\nYou Lose");
                        timer1.Enabled = false;
                        Application.DoEvents();
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
            MessageBox.Show("Bem Vindo Ao Winforms Space Invaders!!!\nWelcome to Winforms Space Invaders\nNum 4 ou A - Esquerda (Left)\nNum 6 ou D - Direita (Right)\nSpace - Atirar (Shoot)");

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
    }
}
