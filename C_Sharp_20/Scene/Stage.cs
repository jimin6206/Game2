using System;
using System.Windows.Forms;

namespace C_Sharp_4_jm
{
    class Stage : IScene
    {
        public Stage(Form1 form1)
        {
            foreach (Control control in form1.Controls)
            {
                if (control is PictureBox && control.Tag == "ground")
                {
                    control.Visible = true;

                }
            }
            ObjectPoolManager.Instance.CreateCharacters(form1);
        }

        public void DownKey(KeyEventArgs e)
        {
            ObjectPoolManager.Instance.Human.DownKey(e);
            foreach (var bullet in ObjectPoolManager.Instance.bullets)
            {
                bullet.DownKey(e);
            }
            ObjectPoolManager.Instance.bullets2.DownKey(e);
        }

        public void UpKey(KeyEventArgs e)
        {
            ObjectPoolManager.Instance.Human.UpKey(e);
        }

        public void Progress()
        {
            ObjectPoolManager.Instance.Human.Move();
            ObjectPoolManager.Instance.Monster.Move();
            foreach (var bullet in ObjectPoolManager.Instance.bullets)
            {
                bullet.Move();
            }
            ObjectPoolManager.Instance.Item.Move();
            ObjectPoolManager.Instance.Monster2.Move();
            ObjectPoolManager.Instance.bullets2.Move();

        }

        public void Render()
        {

        }

    }


}
