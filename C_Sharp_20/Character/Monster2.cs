using System;
using System.Drawing;
using System.Windows.Forms;

namespace C_Sharp_4_jm
{
    class Monster2 : Character
    {
        int time;

        public Monster2(Form1 form1)
        {
            time = 0;
            this.form1 = form1;
            MyPictureBox.Image = Properties.Resources.Monster2_Left_01;
            MyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            MyPictureBox.Height = 100;
            MyPictureBox.Width = 120;


            goLeft = false;
            goRight = false;

            MyPictureBox.Top = form1.ground5.Top - MyPictureBox.Height;
            MyPictureBox.Left = (form1.ground5.Left + form1.ground2.Width / 2 - MyPictureBox.Width / 2);

            for (int i = 0; i < walkImages.GetLength(1); i++)
            {
                string name = "Monster2_Walk_Left_0" + (i + 1).ToString();
                walkImages[0, i] = (Image)Properties.Resources.ResourceManager.GetObject(name);
            }

            for (int i = 0; i < walkImages.GetLength(1); i++)
            {
                string name = "Monster2_Walk_Right_0" + (i + 1).ToString();
                walkImages[1, i] = (Image)Properties.Resources.ResourceManager.GetObject(name);
            }

            for (int i = 0; i < idleImages.GetLength(1) - 1; i++)
            {
                string name = "Monster2_Left_0" + (i + 1).ToString();
                idleImages[0, i] = (Image)Properties.Resources.ResourceManager.GetObject(name);
            }

            for (int i = 0; i < idleImages.GetLength(1) - 1; i++)
            {
                string name = "Monster_Right_0" + (i + 1).ToString();
                idleImages[1, i] = (Image)Properties.Resources.ResourceManager.GetObject(name);
            }

            Hp.BackColor = Color.Red;
            Hp.SizeMode = PictureBoxSizeMode.StretchImage;
            Hp.Width = MyPictureBox.Width;
            Hp.Height = 10;

            Hp.Top = MyPictureBox.Top - 20;
            Hp.Left = MyPictureBox.Left;

            Hp.Name = "HP2";

            MyPictureBox.Name = "Monster2";
            form1.Controls.Add(MyPictureBox);
            form1.Controls.Add(Hp);
            MyPictureBox.BringToFront();
            Hp.BringToFront();
        }

        public override void Move()
        {
            if (!MyPictureBox.Visible)
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

            if (MyPictureBox.Left < form1.ground5.Left)
            {
                direction = Dir.RIGHT;
            }

            if (MyPictureBox.Right > form1.ground5.Right)
            {
                direction = Dir.LEFT;
            }

            aniCount++;

            if (aniCount >= 6)
            {
                aniCount = 0;
            }
            int dir = (int)direction;

            switch (aniState)
            {
                case State.IDLE:
                    MyPictureBox.Image = idleImages[dir, aniCount];
                    break;
                case State.WALK:

                    MyPictureBox.Image = walkImages[dir, aniCount];
                    break;
                case State.JUMP:
                    MyPictureBox.Image = jumpImages[dir, aniCount];
                    break;
            }

            if (Hp.Width < 10)
            {
                MyPictureBox.Visible = false;
            }
        }
    }
}
