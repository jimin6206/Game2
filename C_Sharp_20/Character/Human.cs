using System.Windows.Forms;
using System.Drawing;

namespace C_Sharp_4_jm
{
    class Human : Character
    {
        public Human(Form1 form1)
        {
            jump = false;
            jumpAct = false;
            goLeft = false;
            goRight = false;
            fight = false;
            damage = false;


            MyPictureBox.Image = Properties.Resources.Stay_1;
            MyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            MyPictureBox.Width = 70;
            MyPictureBox.Height = 110;


            MyPictureBox.Top = 200;
            MyPictureBox.Left = 100;

            for (int i = 0; i < walkImages.GetLength(1); i++)
            {
                string name = "Walk_Left_" + (i + 1).ToString();
                walkImages[0, i] = (Image)Properties.Resources.ResourceManager.GetObject(name);
            }

            for (int i = 0; i < walkImages.GetLength(1); i++)
            {
                string name = "Walk_Right_" + (i + 1).ToString();
                walkImages[1, i] = (Image)Properties.Resources.ResourceManager.GetObject(name);
            }

            for (int i = 0; i < idleImages.GetLength(1); i++)
            {
                string name = "Stay_" + (i + 1).ToString();
                idleImages[0, i] = (Image)Properties.Resources.ResourceManager.GetObject(name);
            }

            for (int i = 0; i < idleImages.GetLength(1); i++)
            {
                string name = "Stay_Right_" + (i + 1).ToString();
                idleImages[1, i] = (Image)Properties.Resources.ResourceManager.GetObject(name);
            }

            for (int i = 0; i < 4; i++)
            {
                string name = "fight_0" + (i + 1).ToString();
                fightImages[0, i] = (Image)Properties.Resources.ResourceManager.GetObject(name);
            }

            fightImages[0, 4] = (Image)Properties.Resources.fight_03;
            fightImages[0, 5] = (Image)Properties.Resources.fight_04;

            for (int i = 0; i < 4; i++)
            {
                string name = "fight_Right_0" + (i + 1).ToString();
                fightImages[1, i] = (Image)Properties.Resources.ResourceManager.GetObject(name);
            }

            fightImages[1, 4] = (Image)Properties.Resources.fight_Right_03;
            fightImages[1, 5] = (Image)Properties.Resources.fight_Right_04;

            for (int i = 0; i < damageImages.GetLength(1); i++)
            {
                string name = "Collision_01";
                damageImages[0, i] = (Image)Properties.Resources.ResourceManager.GetObject(name);
            }

            for (int i = 0; i < damageImages.GetLength(1); i++)
            {
                string name = "Collision_Right_01";
                damageImages[1, i] = (Image)Properties.Resources.ResourceManager.GetObject(name);
            }

            Hp.BackColor = Color.Red;
            Hp.SizeMode = PictureBoxSizeMode.StretchImage;
            Hp.Width = MyPictureBox.Width;
            Hp.Height = 10;

            Hp.Top = MyPictureBox.Top - 20;
            Hp.Left = MyPictureBox.Left;

            Hp.Name = "HP";

            MyPictureBox.Name = "Human";
            this.form1 = form1;
            form1.Controls.Add(MyPictureBox);
            form1.Controls.Add(Hp);

            MyPictureBox.BringToFront();
            Hp.BringToFront();

        }

        public override void DownKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                direction = Dir.LEFT;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                direction = Dir.RIGHT;
            }

            if (e.KeyCode == Keys.Space)
            {
                if (!jumpAct)
                {
                    t = 0;
                    jump = true;
                    MyPictureBox.Top -= 1;
                }
            }

            if (e.KeyCode == Keys.Q)
            {
                fight = true;
                foreach (var bullet in ObjectPoolManager.Instance.bullets)
                {
                    if (!bullet.MyPictureBox.Visible)
                    {

                        bullet.direction = direction;

                        switch (direction)
                        {
                            case Dir.RIGHT:
                                bullet.MyPictureBox.Image = Properties.Resources.bullet_Right_01;
                                bullet.MyPictureBox.Top = MyPictureBox.Top + 25;
                                bullet.MyPictureBox.Left = MyPictureBox.Right;
                                break;
                            case Dir.LEFT:
                                bullet.MyPictureBox.Image = Properties.Resources.bullet_01;
                                bullet.MyPictureBox.Top = MyPictureBox.Top + 25;
                                bullet.MyPictureBox.Left = MyPictureBox.Left - MyPictureBox.Width;
                                break;
                        }

                        bullet.MyPictureBox.Visible = true;
                        break;
                    }

                }

            }

            if (e.KeyCode == Keys.W)
            {

                fight = true;

                if (!ObjectPoolManager.Instance.bullets2.MyPictureBox.Visible)
                {
                    ObjectPoolManager.Instance.bullets2.direction = direction;

                    switch (direction)
                    {
                        case Dir.RIGHT:
                            ObjectPoolManager.Instance.bullets2.MyPictureBox.Image = Properties.Resources.bullet_Right_02;
                            ObjectPoolManager.Instance.bullets2.MyPictureBox.Top = MyPictureBox.Top + 25;
                            ObjectPoolManager.Instance.bullets2.MyPictureBox.Left = MyPictureBox.Right;
                            break;
                        case Dir.LEFT:
                            ObjectPoolManager.Instance.bullets2.MyPictureBox.Image = Properties.Resources.bullet_02;
                            ObjectPoolManager.Instance.bullets2.MyPictureBox.Top = MyPictureBox.Top + 25;
                            ObjectPoolManager.Instance.bullets2.MyPictureBox.Left = MyPictureBox.Left - MyPictureBox.Width;
                            break;
                    }

                    ObjectPoolManager.Instance.bullets2.MyPictureBox.Visible = true;
                }




            }

        }



        public override void UpKey(KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

        }

        public override void Move()
        {
            base.Move();

            Hp.Top = MyPictureBox.Top - 20;
            Hp.Left = MyPictureBox.Left;

            aniState = State.IDLE;

            if (goLeft)
            {
                aniState = State.WALK;
                MyPictureBox.Left -= 5;
            }

            if (goRight)
            {
                aniState = State.WALK;
                MyPictureBox.Left += 5;
            }

            if (fight)
            {
                aniState = State.FIGHT;
            }

            if (damage)
            {
                aniState = State.DAMAGE;
                if (direction == Dir.LEFT)
                {
                    MyPictureBox.Left += 10;
                }
                if (direction == Dir.RIGHT)
                {
                    MyPictureBox.Left -= 10;
                }
            }


            aniCount++;

            if (aniCount >= 6)
            {
                aniCount = 0;
                if (aniState == State.FIGHT)
                {
                    fight = false;
                }
                if (aniState == State.DAMAGE)
                {
                    damage = false;
                }
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
                case State.FIGHT:
                    MyPictureBox.Image = fightImages[dir, aniCount];
                    break;
                case State.DAMAGE:
                    MyPictureBox.Image = damageImages[dir, aniCount];
                    break;
            }

            t += 0.1f;


            foreach (Control control in form1.Controls)
            {
                if (control is PictureBox && control.Tag == "ground")
                {

                    if (CollisionManager.Instance.CheckCollider(this, (PictureBox)control))
                    {
                        t = 0;
                        jump = false;
                        MyPictureBox.Top = control.Top - MyPictureBox.Height;

                    }
                }
            }


            if (jump)
            {
                jumpAct = true;
                MyPictureBox.Top += (int)((-Vo * t) + (G * t * t * 0.5f));
            }

            else
            {
                jumpAct = false;
                MyPictureBox.Top += (int)(G * t * t * 0.5f);
            }

            if ((CollisionManager.Instance.CheckCollider(this, ObjectPoolManager.Instance.Monster) && ObjectPoolManager.Instance.Monster.MyPictureBox.Visible) || (CollisionManager.Instance.CheckCollider(this, ObjectPoolManager.Instance.Monster2) && ObjectPoolManager.Instance.Monster2.MyPictureBox.Visible))
            {
                damage = true;
                Hp.Width -= 5;
            }

            if (MyPictureBox.Top > form1.Bottom)
            {
                MyPictureBox.Top = form1.ground1.Top - MyPictureBox.Height;
                MyPictureBox.Left = form1.ground1.Left;
            }


        }

    }
    
}
