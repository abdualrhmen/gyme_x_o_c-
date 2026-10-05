using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using game_x_o.Properties;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntiome;

namespace game_x_o
{
    public partial class Form1 : Form
    {
        stgamestatu gamestatus;
        enplayer playerturn = enplayer.player1;
        enum enplayer
        {
          player1,
          player2
          

            }
        enum enwinner
        {
            player1,
            player2,
            draw,
            gameinprogress
        }
        struct stgamestatu
        {
            public enwinner Winner;
            public bool gameover;
            public short playcount;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white=Color.FromArgb(255,255,255);
            Pen whitepen=new Pen(white);
            whitepen.Width = 15;
            whitepen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitepen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(whitepen, 200, 200, 550, 200);
            e.Graphics.DrawLine(whitepen, 200, 360, 550, 360);
            e.Graphics.DrawLine(whitepen, 310, 80, 310, 470);
            e.Graphics.DrawLine(whitepen, 440, 80, 440, 470);

        }

        public void ChangeImage(Button btn)
        {
           if (btn.Tag.ToString()== "?")
                switch (playerturn)
                {
                    case enplayer.player1:
                        btn.Image = Image.FromFile(@"D:\saels mangment\abdu.png");
                        playerturn = enplayer.player2;
                        lblturn.Text = "player 2";
                        btn.Tag = "abdu";
                       // checkwinner();
                        break;
                    case enplayer.player2:
                        btn.Image = Image.FromFile(@"D:\seals mangment\yassin.png");
                        playerturn = enplayer.player1;
                        lblturn.Text="player 1"

                        
                }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }
      
    }

}
