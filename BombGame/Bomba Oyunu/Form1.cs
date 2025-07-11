using System.Media;
using System.Resources;
using System.Runtime.InteropServices;

namespace Bomba_Oyunu
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;


        Random xRandom = new Random();
        PictureBox bomb = new PictureBox();
        PictureBox bomb2 = new PictureBox();
        PictureBox bomb3 = new PictureBox();
        PictureBox bomb4 = new PictureBox();

        Form2 gameover;

        SoundPlayer sound = new SoundPlayer(Resources.explosion);

        public int score = 0;
    
        int maxvalue = 0;
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            this.MouseDown += Form1_MouseDown;

            closebutton.Click += btnExit_Click;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            playerpicture.BackColor = Color.Transparent;
            playerpicture.Parent = this;
            this.KeyPreview = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            maxvalue = this.ClientSize.Width - 50;

            bomb = new PictureBox();
            bomb.Image = Resources.grenade;
            bomb.SizeMode = PictureBoxSizeMode.Zoom;
            bomb.Size = new Size(50, 50);
            bomb.Location = new Point(xRandom.Next(0, maxvalue), 20);
            bomb.BackColor = Color.Transparent;
            bomb.Parent = this;
            this.Controls.Add(bomb);

            bomb2 = new PictureBox();
            bomb2.Image = Resources.grenade;
            bomb2.SizeMode = PictureBoxSizeMode.Zoom;
            bomb2.Size = new Size(50, 50);
            bomb2.Location = new Point(xRandom.Next(0, maxvalue), 20);
            bomb2.BackColor = Color.Transparent;
            bomb2.Parent = this;
            this.Controls.Add(bomb2);

            bomb3 = new PictureBox();
            bomb3.Image = Resources.grenade;
            bomb3.SizeMode = PictureBoxSizeMode.Zoom;
            bomb3.Size = new Size(50, 50);
            bomb3.Location = new Point(xRandom.Next(0, maxvalue), 20);
            bomb3.BackColor = Color.Transparent;
            bomb3.Parent = this;
            this.Controls.Add(bomb3);

            bomb4 = new PictureBox();
            bomb4.Image = Resources.grenade;
            bomb4.SizeMode = PictureBoxSizeMode.Zoom;
            bomb4.Size = new Size(50, 50);
            bomb4.Location = new Point(xRandom.Next(0, maxvalue), 20);
            bomb4.BackColor = Color.Transparent;
            bomb4.Parent = this;
            this.Controls.Add(bomb4);

            score += 4;

            scorelabel.Text = "Score : " + score;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (bomb != null)
            {
                
                bomb.Location = new Point(bomb.Location.X, bomb.Location.Y + 7);

                
                if (bomb.Location.Y > this.ClientSize.Height)
                {
                    this.Controls.Remove(bomb);   
                    bomb.Dispose();

            
                }
            }

            if (bomb2 != null)
            {
                bomb2.Location = new Point(bomb2.Location.X, bomb2.Location.Y + 7);

                if (bomb2.Location.Y > this.ClientSize.Height)
                {
                    this.Controls.Remove(bomb2);
                    bomb2.Dispose();
                    
                }
            }

            if (bomb3 != null)
            {
                bomb3.Location = new Point(bomb3.Location.X, bomb3.Location.Y + 7);

                if (bomb3.Location.Y > this.ClientSize.Height)
                {
                    this.Controls.Remove(bomb3);
                    bomb3.Dispose();
                    
                }
            }

            if (bomb4 != null)
            {
                bomb4.Location = new Point(bomb4.Location.X, bomb4.Location.Y + 7);

                if (bomb4.Location.Y > this.ClientSize.Height) { 
           
                    this.Controls.Remove(bomb4);
                    bomb4.Dispose();
                    
                }
            }


            if (bomb.Bounds.IntersectsWith(playerpicture.Bounds) || bomb2.Bounds.IntersectsWith(playerpicture.Bounds) || bomb3.Bounds.IntersectsWith(playerpicture.Bounds) || bomb4.Bounds.IntersectsWith(playerpicture.Bounds))
            {
    
                timer1.Stop();
                timer2.Stop();

                sound.PlaySync();

                Form2 gameover = new Form2(this, score);

                gameover.Show();
                this.Hide();

            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            int newX = playerpicture.Location.X;

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                newX -= 20;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                newX += 20;
            }


            if (newX < 0)
            {

                newX = 0;

            }
                

            int maxX = this.ClientSize.Width - playerpicture.Width;

            if (newX > maxX)
            {

                newX = maxX;

            }

            playerpicture.Location = new Point(newX, playerpicture.Location.Y);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
