using System;
using System.Windows.Forms;

namespace C_Sharp_4_jm
{
    class Bullet : Character
    {

        public Bullet(Form1 form1)
        {
            MyPictureBox.Visible = false;
            MyPictureBox.Image = Properties.Resources.bullet_Right_01;
            MyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            MyPictureBox.Width = 40;
            MyPictureBox.Height = 30;
            MyPictureBox.Name = "Bullet";
            form1.Controls.Add(MyPictureBox);
            this.form1 = form1;

        }

        public override void DownKey(KeyEventArgs e)
        {

        }


        public override void UpKey(KeyEventArgs e)
        {

        }

        public override void Move()
        {

            switch (direction)
            {
                case Dir.RIGHT:
                    MyPictureBox.Left += 5;
                    break;
                case Dir.LEFT:

                    MyPictureBox.Left -= 5;
                    break;
            }

            if (MyPictureBox.Right < 0 || MyPictureBox.Left > form1.Width)
            {
                MyPictureBox.Visible = false;
            }

            if (CollisionManager.Instance.CheckCollider(this, ObjectPoolManager.Instance.Monster) && ObjectPoolManager.Instance.Monster.MyPictureBox.Visible)
            {
                MyPictureBox.Visible = false;
                MyPictureBox.Top = 0;
                MyPictureBox.Left = 0;
                ObjectPoolManager.Instance.Monster.Hp.Width -= 10;
            }

            if (CollisionManager.Instance.CheckCollider(this, ObjectPoolManager.Instance.Monster2) && ObjectPoolManager.Instance.Monster2.MyPictureBox.Visible)
            {
                MyPictureBox.Visible = false;
                MyPictureBox.Top = 0;
                MyPictureBox.Left = 0;
                ObjectPoolManager.Instance.Monster2.Hp.Width -= 10;

            }

            

        }

    }
}
