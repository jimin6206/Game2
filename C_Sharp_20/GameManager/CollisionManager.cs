
using System.Security.Permissions;
using System.Windows.Forms;

namespace C_Sharp_4_jm
{
    class CollisionManager
    {
        static CollisionManager instance = null; 

        static public CollisionManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CollisionManager();
                }

                return instance;
            }

        }


        public bool CheckCollider(Character a, Character b)
        {
            if(a.MyPictureBox.Bounds.IntersectsWith(b.MyPictureBox.Bounds))
            {
                return true;
            }

            return false;
        }

        public bool CheckCollider(Character a, PictureBox b)
        {
            if((b.Top <= a.MyPictureBox.Bottom && b.Top >= a.MyPictureBox.Top + (a.MyPictureBox.Height / 2) ) && (b.Left < a.MyPictureBox.Right - a.MyPictureBox.Width/2 && b.Right > a.MyPictureBox.Left + a.MyPictureBox.Width / 2))
            {
                return true;
            }


            return false;
        }
    }
}
