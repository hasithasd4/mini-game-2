namespace minigame_sombeee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ammo = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.health = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.group = new System.Windows.Forms.GroupBox();
            this.bullet2 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.gameov = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // ammo
            // 
            this.ammo.AutoSize = true;
            this.ammo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammo.ForeColor = System.Drawing.SystemColors.Control;
            this.ammo.Location = new System.Drawing.Point(12, 15);
            this.ammo.Name = "ammo";
            this.ammo.Size = new System.Drawing.Size(107, 29);
            this.ammo.TabIndex = 2;
            this.ammo.Text = "Bullets :";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.Control;
            this.score.Location = new System.Drawing.Point(304, 15);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(96, 29);
            this.score.TabIndex = 3;
            this.score.Text = "Score :";
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health.ForeColor = System.Drawing.SystemColors.Control;
            this.health.Location = new System.Drawing.Point(557, 9);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(102, 29);
            this.health.TabIndex = 4;
            this.health.Text = "Health :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(675, 15);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(235, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 100;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.maingametimer);
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.Gray;
            this.group.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.group.Controls.Add(this.close);
            this.group.Controls.Add(this.restart);
            this.group.Controls.Add(this.gameov);
            this.group.Controls.Add(this.score2);
            this.group.Controls.Add(this.bullet2);
            this.group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group.Location = new System.Drawing.Point(17, 541);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(886, 102);
            this.group.TabIndex = 7;
            this.group.TabStop = false;
            // 
            // bullet2
            // 
            this.bullet2.AutoSize = true;
            this.bullet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bullet2.ForeColor = System.Drawing.SystemColors.Control;
            this.bullet2.Location = new System.Drawing.Point(29, 21);
            this.bullet2.Name = "bullet2";
            this.bullet2.Size = new System.Drawing.Size(107, 29);
            this.bullet2.TabIndex = 8;
            this.bullet2.Text = "Bullets :";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.ForeColor = System.Drawing.SystemColors.Control;
            this.score2.Location = new System.Drawing.Point(29, 50);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(96, 29);
            this.score2.TabIndex = 8;
            this.score2.Text = "Score :";
            // 
            // gameov
            // 
            this.gameov.AutoSize = true;
            this.gameov.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameov.ForeColor = System.Drawing.Color.Red;
            this.gameov.Location = new System.Drawing.Point(340, 21);
            this.gameov.Name = "gameov";
            this.gameov.Size = new System.Drawing.Size(147, 44);
            this.gameov.TabIndex = 9;
            this.gameov.Text = "Score :";
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.Location = new System.Drawing.Point(620, 29);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(111, 39);
            this.restart.TabIndex = 10;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(759, 29);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(111, 40);
            this.close.TabIndex = 11;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::minigame_sombeee.Properties.Resources.Screenshot__391_;
            this.pictureBox1.Location = new System.Drawing.Point(831, 608);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::minigame_sombeee.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(348, 541);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 6;
            this.player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(922, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.group);
            this.Controls.Add(this.player);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.health);
            this.Controls.Add(this.score);
            this.Controls.Add(this.ammo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "සොම්බි මරමු";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyup);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ammo;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label health;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label gameov;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label bullet2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

