using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Bomba_Oyunu
{
    public partial class Form2 : Form
    {

        Form1 game;

        int incomingScore = 0;
       
        SoundPlayer sound2 = new SoundPlayer(Resources.gameover2);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        public Form2(Form1 frm, int Score)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            this.MouseDown += Form2_MouseDown;

            game = frm;

            incomingScore = Score;
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 newGame = new Form1();
            newGame.Show();
            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {


            sound2.Play();

            label2.Text = "Score : " + incomingScore;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
