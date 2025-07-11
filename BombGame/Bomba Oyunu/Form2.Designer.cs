namespace Bomba_Oyunu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            tryagainbutton = new Button();
            exitgamebutton = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1015, 356);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(404, 256);
            label2.Name = "label2";
            label2.Size = new Size(0, 65);
            label2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1015, 356);
            label1.TabIndex = 0;
            label1.Text = "Game Over!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tryagainbutton
            // 
            tryagainbutton.Cursor = Cursors.Hand;
            tryagainbutton.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tryagainbutton.Location = new Point(77, 382);
            tryagainbutton.Name = "tryagainbutton";
            tryagainbutton.Size = new Size(402, 78);
            tryagainbutton.TabIndex = 1;
            tryagainbutton.Text = "Try Again";
            tryagainbutton.UseVisualStyleBackColor = true;
            tryagainbutton.Click += button1_Click;
            // 
            // exitgamebutton
            // 
            exitgamebutton.Cursor = Cursors.Hand;
            exitgamebutton.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            exitgamebutton.Location = new Point(547, 382);
            exitgamebutton.Name = "exitgamebutton";
            exitgamebutton.Size = new Size(402, 78);
            exitgamebutton.TabIndex = 2;
            exitgamebutton.Text = "Exit The Game";
            exitgamebutton.UseVisualStyleBackColor = true;
            exitgamebutton.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(842, 481);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 3;
            label3.Text = "Made by Özgür Kadakal";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1019, 510);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(exitgamebutton);
            Controls.Add(tryagainbutton);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bomb Escape";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button tryagainbutton;
        private Button exitgamebutton;
        private Label label3;
    }
}