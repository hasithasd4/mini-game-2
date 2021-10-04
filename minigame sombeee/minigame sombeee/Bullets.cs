using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace minigame_sombeee
{
    class Bullets
    {

        public string direction;
        public int bulletleft;
        public int bulletTop;

        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bullettimer = new Timer();


        public void Makebullet(Form form)
        {
            bullet.BackColor = Color.White;
            bullet.Size = new Size(5, 5);
            bullet.Tag = "bullet";
            bullet.Left = bulletleft;
            bullet.Top = bulletTop;
            bullet.BringToFront();

            form.Controls.Add(bullet);

            bullettimer.Interval = speed;
            bullettimer.Tick += new EventHandler(BulletTimerEvent);
            bullettimer.Start();

          

        }

        private void BulletTimerEvent(object secder , EventArgs e)
        {
             if(direction == "left")
            {
                bullet.Left -= speed;
            }
            if (direction == "right")
            {
                bullet.Left += speed;
            }
            if (direction == "up")
            {
                bullet.Top -= speed;
            }
            if (direction == "down")
            {
                bullet.Top += speed;
            }


            if(bullet.Left<10|| bullet.Left>860 || bullet.Top < 10 || bullet.Top > 600)
            {
                bullettimer.Stop();
                bullettimer.Dispose();
                bullet.Dispose();
                bullettimer = null;
                bullet = null;
            }
        }




    }
}
