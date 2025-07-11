namespace Bomba_Oyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            scorelabel = new Label();
            playerpicture = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            closebutton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)playerpicture).BeginInit();
            SuspendLayout();
            // 
            // scorelabel
            // 
            scorelabel.AutoSize = true;
            scorelabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            scorelabel.Location = new Point(821, 30);
            scorelabel.Name = "scorelabel";
            scorelabel.Size = new Size(134, 40);
            scorelabel.TabIndex = 0;
            scorelabel.Text = "Score : 0";
            // 
            // playerpicture
            // 
            playerpicture.Image = Resources.Standing_Man;
            playerpicture.Location = new Point(493, 380);
            playerpicture.Name = "playerpicture";
            playerpicture.Size = new Size(46, 105);
            playerpicture.SizeMode = PictureBoxSizeMode.CenterImage;
            playerpicture.TabIndex = 1;
            playerpicture.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1;
            timer2.Tick += timer2_Tick;
            // 
            // closebutton
            // 
            closebutton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            closebutton.Location = new Point(863, 458);
            closebutton.Name = "closebutton";
            closebutton.Size = new Size(144, 40);
            closebutton.TabIndex = 2;
            closebutton.Text = "Close";
            closebutton.UseVisualStyleBackColor = true;
            closebutton.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(32, 13);
            label1.TabIndex = 3;
            label1.Text = "V 1.1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 510);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(closebutton);
            Controls.Add(playerpicture);
            Controls.Add(scorelabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bomb Escape";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)playerpicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label scorelabel;
        private PictureBox playerpicture;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button closebutton;
        private Label label1;
    }
}
