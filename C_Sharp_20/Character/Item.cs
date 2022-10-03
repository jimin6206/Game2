using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_4_jm
{
    class Item : Character
    {
        public Item(Form1 form1)
        {
            MyPictureBox.Image = Properties.Resources.item_3;
            MyPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            MyPictureBox.Top = form1.ground4.Top - MyPictureBox.Height;
            MyPictureBox.Left = form1.ground4.Right - MyPictureBox.Width-50;

            MyPictureBox.Name = "Item";
            form1.Controls.Add(MyPictureBox);
        }

        public override void DownKey(KeyEventArgs e)
        { 

        }

        public override void UpKey(KeyEventArgs e)
        {

        }

        public override void Move()
        {
            if (CollisionManager.Instance.CheckCollider(this,ObjectPoolManager.Instance.Human))
            {
                ObjectPoolManager.Instance.Human.Hp.Width += 20;
                MyPictureBox.Top = 0;
                MyPictureBox.Left = 0;
                MyPictureBox.Visible = false;

            }
        }
    }
}
