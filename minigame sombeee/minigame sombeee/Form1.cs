using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minigame_sombeee
{
    public partial class Form1 : Form
    {
        bool goleft, goright, godown, goup, gameover;
        string Facing = "up";
        int playerhealth = 100;
        int speed = 10;
        int ammo1 = 10;
        int zombispeed = 1;
        int score1 = 0;
        Random randNum = new Random ();
        List<PictureBox> zombiList = new List<PictureBox>();
         

        public Form1()
        {
            InitializeComponent();
            Restartgame();
        }

        private void maingametimer(object sender, EventArgs e)
        {
            if(playerhealth > 1)
            {
                progressBar1.Value = playerhealth;
            }
            else
            {
                gameover = true;
                player.Image = Properties.Resources.dead;
                gameTimer.Stop();
                
                bullet2.Text = "Bullets : " + ammo1;
                score2.Text = "Score : " + score1;
                gameov.Text = "Game over !!!!";
                group.Show();
            }
            ammo.Text = "Ammmo : " + ammo1;
            score.Text = "Score : " + score1;

            if(goleft == true && player.Left > 0)
            {
                player.Left -= speed;
            }
            if(goright==true&&player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }
            if (goup == true && player.Top > 40)
            {
                player.Top -= speed;
            }
            if (godown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (
                        player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo1 += 5;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "zombie")
                {

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerhealth -= 1;
                    }


                    if (x.Left > player.Left)
                    {
                        x.Left -= zombispeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;

                    }

                    if (x.Left < player.Left)
                    {
                        x.Left += zombispeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;

                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zombispeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;

                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zombispeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;

                    }

                }

                foreach(Control j in this.Controls )
                {
                   if (j is PictureBox&& (string)j.Tag== "bullet"&& x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score1++;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                             this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombiList.Remove(((PictureBox)x));
                            makezombes();
                        }
                    }
                }




            
            }


        }

        private void Keydown(object sender, KeyEventArgs e)
        {

            if (gameover == true)
            {
                return;
            }




            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                Facing = "left";
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                Facing = "right";
                player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                Facing = "up";
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                Facing = "down";
                player.Image = Properties.Resources.down;
            }
        }

        private void Keyup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
              
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;

            }

            if (e.KeyCode == Keys.Up)
            {
                goup = false;

            }

            if (e.KeyCode == Keys.Down)
            {
                godown = false;

            }
            if (e.KeyCode == Keys.Space && ammo1 >0 )
            {
                ammo1--;
                Shootbullet(Facing);

                if(ammo1 < 2)
                {
                    DropAmmo();
                }

            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Shootbullet(string direction)
        {
            Bullets shootBullet = new Bullets();
            shootBullet.direction = direction;
            shootBullet.bulletleft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.Makebullet(this);
        }

        private void makezombes()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = randNum.Next(0, 900);
            zombie.Top = randNum.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombiList.Add(zombie);
            this.Controls.Add(zombie);
            player.BringToFront(); 
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(10, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
        }

        private void Restartgame()
        {
            player.Image = Properties.Resources.up;
            foreach(PictureBox i in zombiList)
            {
                this.Controls.Remove(i);
            }
            zombiList.Clear();
            for(int i = 0; i < 3; i++)
            {
                makezombes();
            }

            goup = false;
            godown = false;
            goleft = false;
            goright = false;

            playerhealth = 100;
            score1 = 0;
            ammo1 = 10;
            gameTimer.Start();

            group.Hide();


        }

    }
}
