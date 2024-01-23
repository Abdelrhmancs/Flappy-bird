using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
namespace WindowsFormsApp3
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GameOver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.humangamer = new System.Windows.Forms.PictureBox();
            this.wall1 = new System.Windows.Forms.PictureBox();
            this.wall2 = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.backgroundOfGame = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.humangamer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundOfGame)).BeginInit();
            this.SuspendLayout();
            // 
            // GameOver
            // 
            this.GameOver.Location = new System.Drawing.Point(0, 0);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(100, 23);
            this.GameOver.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(317, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 41);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humangamer
            // 
            this.humangamer.Image = global::WindowsFormsApp3.Properties.Resources.صورة_واتساب_بتاريخ_2023_11_24_في_01_52_36_41310940;
            this.humangamer.Location = new System.Drawing.Point(250, 200);
            this.humangamer.Name = "humangamer";
            this.humangamer.Size = new System.Drawing.Size(50, 50);
            this.humangamer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.humangamer.TabIndex = 0;
            this.humangamer.TabStop = false;
            // 
            // wall1
            // 
            this.wall1.Image = global::WindowsFormsApp3.Properties.Resources.صورة_واتساب_بتاريخ_2023_11_24_في_01_34_53_194e8e4a;
            this.wall1.Location = new System.Drawing.Point(500, 0);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(45, 100);
            this.wall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wall1.TabIndex = 1;
            this.wall1.TabStop = false;
            // 
            // wall2
            // 
            this.wall2.Image = global::WindowsFormsApp3.Properties.Resources.صورة_واتساب_بتاريخ_2023_11_24_في_01_34_12_ed622ca6;
            this.wall2.Location = new System.Drawing.Point(500, 210);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(50, 190);
            this.wall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wall2.TabIndex = 2;
            this.wall2.TabStop = false;
            // 
            // floor
            // 
            this.floor.Image = global::WindowsFormsApp3.Properties.Resources.صورة_واتساب_بتاريخ_2023_11_24_في_01_35_32_3e26307a;
            this.floor.Location = new System.Drawing.Point(0, 400);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(800, 60);
            this.floor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floor.TabIndex = 3;
            this.floor.TabStop = false;
            //  
            // backgroundOfGame
            // 
            this.backgroundOfGame.Image = global::WindowsFormsApp3.Properties.Resources.صورة_واتساب_بتاريخ_2023_11_24_في_02_05_23_8864673c;
            this.backgroundOfGame.Location = new System.Drawing.Point(0, 0);
            this.backgroundOfGame.Name = "backgroundOfGame";
            this.backgroundOfGame.Size = new System.Drawing.Size(800, 450);
            this.backgroundOfGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundOfGame.TabIndex = 4;
            this.backgroundOfGame.TabStop = false;
            this.backgroundOfGame.Click += new System.EventHandler(this.backgroundOfGame_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.humangamer);
            this.Controls.Add(this.wall1);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.backgroundOfGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.humangamer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundOfGame)).EndInit();
            this.ResumeLayout(false);

        }
        private PictureBox humangamer;
        private PictureBox wall1;
        private PictureBox wall2;
        private PictureBox floor;
        private PictureBox backgroundOfGame;
        #endregion

        private Timer timer1;
        private BackgroundWorker backgroundWorker1;
        private Label GameOver;
        private Label label1;
    }
}





