﻿using System.Drawing;
namespace WindowsFormsApplication1
{
    partial class frmInvaders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvaders));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.picTiroMon = new System.Windows.Forms.PictureBox();
            this.picTiroJog = new System.Windows.Forms.PictureBox();
            this.picJog = new System.Windows.Forms.PictureBox();
            this.pícParede2 = new System.Windows.Forms.PictureBox();
            this.pícParede1 = new System.Windows.Forms.PictureBox();
            this.inv18 = new System.Windows.Forms.PictureBox();
            this.inv16 = new System.Windows.Forms.PictureBox();
            this.inv12 = new System.Windows.Forms.PictureBox();
            this.inv10 = new System.Windows.Forms.PictureBox();
            this.inv14 = new System.Windows.Forms.PictureBox();
            this.inv6 = new System.Windows.Forms.PictureBox();
            this.inv8 = new System.Windows.Forms.PictureBox();
            this.inv17 = new System.Windows.Forms.PictureBox();
            this.inv4 = new System.Windows.Forms.PictureBox();
            this.inv11 = new System.Windows.Forms.PictureBox();
            this.inv15 = new System.Windows.Forms.PictureBox();
            this.inv2 = new System.Windows.Forms.PictureBox();
            this.inv9 = new System.Windows.Forms.PictureBox();
            this.inv13 = new System.Windows.Forms.PictureBox();
            this.inv5 = new System.Windows.Forms.PictureBox();
            this.inv7 = new System.Windows.Forms.PictureBox();
            this.inv3 = new System.Windows.Forms.PictureBox();
            this.inv1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTiroMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTiroJog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pícParede2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pícParede1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.picTiroMon);
            this.panel1.Controls.Add(this.picTiroJog);
            this.panel1.Controls.Add(this.picJog);
            this.panel1.Controls.Add(this.pícParede2);
            this.panel1.Controls.Add(this.pícParede1);
            this.panel1.Controls.Add(this.inv18);
            this.panel1.Controls.Add(this.inv16);
            this.panel1.Controls.Add(this.inv12);
            this.panel1.Controls.Add(this.inv10);
            this.panel1.Controls.Add(this.inv14);
            this.panel1.Controls.Add(this.inv6);
            this.panel1.Controls.Add(this.inv8);
            this.panel1.Controls.Add(this.inv17);
            this.panel1.Controls.Add(this.inv4);
            this.panel1.Controls.Add(this.inv11);
            this.panel1.Controls.Add(this.inv15);
            this.panel1.Controls.Add(this.inv2);
            this.panel1.Controls.Add(this.inv9);
            this.panel1.Controls.Add(this.inv13);
            this.panel1.Controls.Add(this.inv5);
            this.panel1.Controls.Add(this.inv7);
            this.panel1.Controls.Add(this.inv3);
            this.panel1.Controls.Add(this.inv1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 540);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(73, 495);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 37);
            this.pictureBox6.TabIndex = 28;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(26, 495);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 37);
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // picTiroMon
            // 
            this.picTiroMon.Image = global::WindowsFormsApplication1.Properties.Resources.tiro1;
            this.picTiroMon.Location = new System.Drawing.Point(738, 451);
            this.picTiroMon.Name = "picTiroMon";
            this.picTiroMon.Size = new System.Drawing.Size(10, 34);
            this.picTiroMon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTiroMon.TabIndex = 26;
            this.picTiroMon.TabStop = false;
            this.picTiroMon.Visible = false;
            // 
            // picTiroJog
            // 
            this.picTiroJog.Image = global::WindowsFormsApplication1.Properties.Resources.tiro1;
            this.picTiroJog.Location = new System.Drawing.Point(712, 451);
            this.picTiroJog.Name = "picTiroJog";
            this.picTiroJog.Size = new System.Drawing.Size(10, 34);
            this.picTiroJog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTiroJog.TabIndex = 25;
            this.picTiroJog.TabStop = false;
            this.picTiroJog.Visible = false;
            // 
            // picJog
            // 
            this.picJog.BackColor = System.Drawing.Color.Transparent;
            this.picJog.Image = ((System.Drawing.Image)(resources.GetObject("picJog.Image")));
            this.picJog.Location = new System.Drawing.Point(355, 487);
            this.picJog.Name = "picJog";
            this.picJog.Size = new System.Drawing.Size(40, 45);
            this.picJog.TabIndex = 24;
            this.picJog.TabStop = false;
            // 
            // pícParede2
            // 
            this.pícParede2.Image = global::WindowsFormsApplication1.Properties.Resources.barreira;
            this.pícParede2.Location = new System.Drawing.Point(524, 450);
            this.pícParede2.Name = "pícParede2";
            this.pícParede2.Size = new System.Drawing.Size(134, 35);
            this.pícParede2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pícParede2.TabIndex = 23;
            this.pícParede2.TabStop = false;
            // 
            // pícParede1
            // 
            this.pícParede1.Image = global::WindowsFormsApplication1.Properties.Resources.barreira;
            this.pícParede1.Location = new System.Drawing.Point(125, 450);
            this.pícParede1.Name = "pícParede1";
            this.pícParede1.Size = new System.Drawing.Size(134, 35);
            this.pícParede1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pícParede1.TabIndex = 22;
            this.pícParede1.TabStop = false;
            // 
            // inv18
            // 
            this.inv18.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv18.Location = new System.Drawing.Point(418, 122);
            this.inv18.Name = "inv18";
            this.inv18.Size = new System.Drawing.Size(40, 38);
            this.inv18.TabIndex = 20;
            this.inv18.TabStop = false;
            // 
            // inv16
            // 
            this.inv16.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv16.Location = new System.Drawing.Point(261, 122);
            this.inv16.Name = "inv16";
            this.inv16.Size = new System.Drawing.Size(40, 38);
            this.inv16.TabIndex = 19;
            this.inv16.TabStop = false;
            // 
            // inv12
            // 
            this.inv12.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv12.Location = new System.Drawing.Point(434, 65);
            this.inv12.Name = "inv12";
            this.inv12.Size = new System.Drawing.Size(40, 38);
            this.inv12.TabIndex = 18;
            this.inv12.TabStop = false;
            // 
            // inv10
            // 
            this.inv10.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv10.Location = new System.Drawing.Point(277, 65);
            this.inv10.Name = "inv10";
            this.inv10.Size = new System.Drawing.Size(40, 38);
            this.inv10.TabIndex = 17;
            this.inv10.TabStop = false;
            // 
            // inv14
            // 
            this.inv14.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv14.Location = new System.Drawing.Point(107, 122);
            this.inv14.Name = "inv14";
            this.inv14.Size = new System.Drawing.Size(40, 38);
            this.inv14.TabIndex = 16;
            this.inv14.TabStop = false;
            // 
            // inv6
            // 
            this.inv6.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv6.Location = new System.Drawing.Point(418, 8);
            this.inv6.Name = "inv6";
            this.inv6.Size = new System.Drawing.Size(40, 38);
            this.inv6.TabIndex = 21;
            this.inv6.TabStop = false;
            // 
            // inv8
            // 
            this.inv8.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv8.Location = new System.Drawing.Point(123, 65);
            this.inv8.Name = "inv8";
            this.inv8.Size = new System.Drawing.Size(40, 38);
            this.inv8.TabIndex = 4;
            this.inv8.TabStop = false;
            // 
            // inv17
            // 
            this.inv17.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv17.Location = new System.Drawing.Point(339, 122);
            this.inv17.Name = "inv17";
            this.inv17.Size = new System.Drawing.Size(40, 38);
            this.inv17.TabIndex = 13;
            this.inv17.TabStop = false;
            // 
            // inv4
            // 
            this.inv4.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv4.Location = new System.Drawing.Point(261, 8);
            this.inv4.Name = "inv4";
            this.inv4.Size = new System.Drawing.Size(40, 38);
            this.inv4.TabIndex = 12;
            this.inv4.TabStop = false;
            // 
            // inv11
            // 
            this.inv11.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv11.Location = new System.Drawing.Point(355, 65);
            this.inv11.Name = "inv11";
            this.inv11.Size = new System.Drawing.Size(40, 38);
            this.inv11.TabIndex = 11;
            this.inv11.TabStop = false;
            // 
            // inv15
            // 
            this.inv15.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv15.Location = new System.Drawing.Point(185, 122);
            this.inv15.Name = "inv15";
            this.inv15.Size = new System.Drawing.Size(40, 38);
            this.inv15.TabIndex = 10;
            this.inv15.TabStop = false;
            // 
            // inv2
            // 
            this.inv2.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv2.Location = new System.Drawing.Point(107, 8);
            this.inv2.Name = "inv2";
            this.inv2.Size = new System.Drawing.Size(40, 38);
            this.inv2.TabIndex = 9;
            this.inv2.TabStop = false;
            // 
            // inv9
            // 
            this.inv9.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv9.Location = new System.Drawing.Point(201, 65);
            this.inv9.Name = "inv9";
            this.inv9.Size = new System.Drawing.Size(40, 38);
            this.inv9.TabIndex = 8;
            this.inv9.TabStop = false;
            // 
            // inv13
            // 
            this.inv13.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv13.Location = new System.Drawing.Point(26, 122);
            this.inv13.Name = "inv13";
            this.inv13.Size = new System.Drawing.Size(40, 38);
            this.inv13.TabIndex = 7;
            this.inv13.TabStop = false;
            // 
            // inv5
            // 
            this.inv5.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv5.Location = new System.Drawing.Point(339, 8);
            this.inv5.Name = "inv5";
            this.inv5.Size = new System.Drawing.Size(40, 38);
            this.inv5.TabIndex = 6;
            this.inv5.TabStop = false;
            // 
            // inv7
            // 
            this.inv7.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv7.Location = new System.Drawing.Point(42, 65);
            this.inv7.Name = "inv7";
            this.inv7.Size = new System.Drawing.Size(40, 38);
            this.inv7.TabIndex = 5;
            this.inv7.TabStop = false;
            // 
            // inv3
            // 
            this.inv3.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv3.Location = new System.Drawing.Point(185, 8);
            this.inv3.Name = "inv3";
            this.inv3.Size = new System.Drawing.Size(40, 38);
            this.inv3.TabIndex = 14;
            this.inv3.TabStop = false;
            // 
            // inv1
            // 
            this.inv1.Image = global::WindowsFormsApplication1.Properties.Resources.invader;
            this.inv1.Location = new System.Drawing.Point(26, 8);
            this.inv1.Name = "inv1";
            this.inv1.Size = new System.Drawing.Size(40, 38);
            this.inv1.TabIndex = 15;
            this.inv1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 541);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("ArcadeClassic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Lime;
            this.lblScore.Location = new System.Drawing.Point(197, 20);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(37, 37);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.BackColor = System.Drawing.Color.Lime;
            this.btnNovoJogo.Font = new System.Drawing.Font("ArcadeClassic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoJogo.Location = new System.Drawing.Point(292, 1);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(225, 64);
            this.btnNovoJogo.TabIndex = 4;
            this.btnNovoJogo.Text = "Start Game";
            this.btnNovoJogo.UseVisualStyleBackColor = false;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(523, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 70);
            this.panel2.TabIndex = 27;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(222, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 45);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(158, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 45);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(97, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 45);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ArcadeClassic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIVES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblScore);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 70);
            this.panel3.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ArcadeClassic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "X       SCORE";
            // 
            // frmInvaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 613);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmInvaders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winforms Space Invaders (by Alessandro Gomez)";
            this.Load += new System.EventHandler(this.frmInvaders_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmInvaders_KeyPress);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTiroMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTiroJog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pícParede2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pícParede1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox picTiroMon;
        public System.Windows.Forms.PictureBox picTiroJog;
        public System.Windows.Forms.PictureBox picJog;
        public System.Windows.Forms.PictureBox pícParede2;
        public System.Windows.Forms.PictureBox pícParede1;
        public System.Windows.Forms.PictureBox inv18;
        public System.Windows.Forms.PictureBox inv16;
        public System.Windows.Forms.PictureBox inv12;
        public System.Windows.Forms.PictureBox inv10;
        public System.Windows.Forms.PictureBox inv14;
        public System.Windows.Forms.PictureBox inv6;
        public System.Windows.Forms.PictureBox inv8;
        public System.Windows.Forms.PictureBox inv17;
        public System.Windows.Forms.PictureBox inv4;
        public System.Windows.Forms.PictureBox inv11;
        public System.Windows.Forms.PictureBox inv15;
        public System.Windows.Forms.PictureBox inv2;
        public System.Windows.Forms.PictureBox inv9;
        public System.Windows.Forms.PictureBox inv13;
        public System.Windows.Forms.PictureBox inv5;
        public System.Windows.Forms.PictureBox inv7;
        public System.Windows.Forms.PictureBox inv3;
        public System.Windows.Forms.PictureBox inv1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblScore;
        public System.Windows.Forms.Button btnNovoJogo;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.PictureBox pictureBox5;
    }
}

