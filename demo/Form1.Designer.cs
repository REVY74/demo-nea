namespace demo
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
            gametimer = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            PLAYER1 = new Label();
            PLAYER2 = new Label();
            PLAYER2HEALTH = new ProgressBar();
            SuspendLayout();
            // 
            // gametimer
            // 
            gametimer.Enabled = true;
            gametimer.Interval = 20;
            gametimer.Tick += GameTimeEvent;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(196, 23);
            progressBar1.TabIndex = 0;
            progressBar1.Value = 100;
            progressBar1.Click += progressBar1_Click;
            // 
            // PLAYER1
            // 
            PLAYER1.AutoSize = true;
            PLAYER1.BackColor = Color.DodgerBlue;
            PLAYER1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PLAYER1.ForeColor = Color.White;
            PLAYER1.Location = new Point(0, 29);
            PLAYER1.Name = "PLAYER1";
            PLAYER1.Size = new Size(58, 15);
            PLAYER1.TabIndex = 1;
            PLAYER1.Text = "PLAYER 1";
            PLAYER1.Click += label1_Click;
            // 
            // PLAYER2
            // 
            PLAYER2.AutoSize = true;
            PLAYER2.BackColor = Color.Red;
            PLAYER2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PLAYER2.ForeColor = Color.White;
            PLAYER2.Location = new Point(744, 29);
            PLAYER2.Name = "PLAYER2";
            PLAYER2.Size = new Size(55, 15);
            PLAYER2.TabIndex = 2;
            PLAYER2.Text = "PLAYER2";
            PLAYER2.Click += PLAYER2_Click;
            // 
            // PLAYER2HEALTH
            // 
            PLAYER2HEALTH.Location = new Point(626, 3);
            PLAYER2HEALTH.Name = "PLAYER2HEALTH";
            PLAYER2HEALTH.Size = new Size(173, 23);
            PLAYER2HEALTH.TabIndex = 3;
            PLAYER2HEALTH.Value = 100;
            PLAYER2HEALTH.Click += PLAYER2HEALTH_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Controls.Add(PLAYER2HEALTH);
            Controls.Add(PLAYER2);
            Controls.Add(PLAYER1);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            Paint += FromPaintEvent;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer gametimer;
        private ProgressBar progressBar1;
        private Label PLAYER1;
        private Label PLAYER2;
        private ProgressBar PLAYER2HEALTH;
    }
}
