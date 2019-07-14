namespace Breakout
{
    partial class Board
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
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.Plat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plat)).BeginInit();
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Red;
            this.Ball.Location = new System.Drawing.Point(271, 277);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(31, 28);
            this.Ball.TabIndex = 0;
            this.Ball.TabStop = false;
            // 
            // Time
            // 
            this.Time.Interval = 1;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // Plat
            // 
            this.Plat.BackColor = System.Drawing.Color.Black;
            this.Plat.Location = new System.Drawing.Point(195, 456);
            this.Plat.Name = "Plat";
            this.Plat.Size = new System.Drawing.Size(190, 21);
            this.Plat.TabIndex = 1;
            this.Plat.TabStop = false;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(596, 520);
            this.Controls.Add(this.Plat);
            this.Controls.Add(this.Ball);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Board";
            this.Text = "Breakout";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Board_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.PictureBox Plat;
    }
}

