using System;
using System.Drawing;
using System.Windows.Forms;

namespace C_Sharp_4_jm
{
    class Monster : Character
    {
        int time;

        public Monster(Form1 form1)
        {
            time = 0;
            this.form1 = form1;
            MyPictureBox.Image = Properties.Resources.Monster_Stay_1;
            MyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            MyPictureBox.Height = 100;
            MyPictureBox.Width = 120;


            goLeft = false;
            goRight = false;

            MyPictureBox.Top = form1.ground2.Top - MyPictureBox.Height;
            MyPictureBox.Left = (form1.ground2.Left + form1.ground2.Width / 2 - MyPictureBox.Width / 2);

            for (int i = 0; i < walkImages.GetLength(1); i++)
            {
                string name = "Monster_Walk_Left_" + (i + 1).ToString();
                walkImages[0, i] = (Image)Properties.Resources.ResourceManager.GetObject(name);
            }

            for (int i = 0; i < walkImages.GetLength(1); i++)
            {
                string name = "Monster_Walk_Right_" + (i + 1).ToString();
                walkImages[1, i] = (Image)Properties.Resources.ResourceManager.GetObject(name);
            }

            for (int i = 0; i < idleImages.GetLength(1)-1; i++)
            {
                string name = "Monster_Stay_" + (i + 1).ToString();
                idleImages[0, i] = (Image)Properties.Resources.ResourceManager.GetObject(name);
            }

            for (int i = 0; i < idleImages.GetLength(1)-1; i++)
            {
                string name = "Monster_Stay_Right_" + (i + 1).ToString();
                idleImages[1, i] = (Image)Properties.Resources.ResourceManager.GetObject(name);
            }

            Hp.BackColor = Color.Red;
            Hp.SizeMode = PictureBoxSizeMode.StretchImage;
            Hp.Width = MyPictureBox.Width;
            Hp.Height = 10;
            
            Hp.Top = MyPictureBox.Top - 20;
            Hp.Left = MyPictureBox.Left;
            
            Hp.Name = "HP";

            MyPictureBox.Name = "Monster";
            form1.Controls.Add(MyPictureBox);
            form1.Controls.Add(Hp);
            MyPictureBox.BringToFront();
            Hp.BringToFront();
        }

        public override void Move()
        {
            if(!MyPictureBox.Visible)
            {
                time++;

                if (time > 500)
                {
                    time = 0;
                    Hp.Width = MyPictureBox.Width;
                    MyPictureBox.Visible = true;
                }
                
            }

            Hp.Left = MyPictureBox.Left;
            aniState = State.WALK;


            switch (direction)
            {
                case Dir.LEFT:
                    MyPictureBox.Left -= 2;
                    break;
                case Dir.RIGHT:
                    MyPictureBox.Left += 2;
                    break;
            }

            if(MyPictureBox.Left < form1.ground2.Left)
            {
                direction = Dir.RIGHT;
            }

            if (MyPictureBox.Right > form1.ground2.Right)
            {
                direction = Dir.LEFT;
            }

            aniCount++;

            int dir = (int)direction;

            switch (aniState)
            {
                case State.IDLE:
                    if (aniCount >= 5)
                    {
                        aniCount = 0;
                    }
                    MyPictureBox.Image = idleImages[dir, aniCount];
                    break;
                case State.WALK:
                    if (aniCount >= 6)
                    {
                        aniCount = 0;
                    }
                    MyPictureBox.Image = walkImages[dir, aniCount];
                    break;
                case State.JUMP:
                    MyPictureBox.Image = jumpImages[dir, aniCount];
                    break;
            }

            if(Hp.Width < 10)
            {
                MyPictureBox.Visible = false;
            }





        }

    }
}
