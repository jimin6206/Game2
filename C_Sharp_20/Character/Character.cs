using System;
using System.Drawing;
using System.Windows.Forms;


namespace C_Sharp_4_jm
{
    enum Dir
    {
        LEFT,
        RIGHT,
    }

    enum State
    {
        IDLE,
        WALK,
        JUMP,
        FIGHT,
        DAMAGE,
    }

    class Character
    {
        public float t = 0f;
        public const float G = 9.81f;
        public const float Vo = 12f;

        public Image[,] walkImages;
        public Image[,] idleImages;
        public Image[,] jumpImages;
        public Image[,] fightImages;
        public Image[,] damageImages;

        public Dir direction;
        public State aniState;

        protected bool goLeft;
        protected bool goRight;

        protected Form1 form1;

        public bool jump;
        public bool jumpAct;
        public bool fight;
        public bool damage;

        public PictureBox MyPictureBox { get; }
        public PictureBox Hp { get; }
        public int aniCount = 0 ;

        public Character()
        {
            aniState = State.IDLE;
            direction = Dir.RIGHT;

            idleImages = new Image[2, 6];
            walkImages = new Image[2, 6];
            jumpImages = new Image[2, 6];
            fightImages = new Image[2, 6];
            damageImages = new Image[2, 6];

            MyPictureBox = new PictureBox();
            Hp = new PictureBox();
            MyPictureBox.BackColor = Color.Transparent;

        }


        public virtual void DownKey(KeyEventArgs e)
        {

        }

        public virtual void UpKey(KeyEventArgs e)
        {

        }

        public virtual void Move()
        {

        }
    }

}
