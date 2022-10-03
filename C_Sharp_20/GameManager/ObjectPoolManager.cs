
namespace C_Sharp_4_jm
{
    class ObjectPoolManager
    {
        static ObjectPoolManager instance = null;

        static public ObjectPoolManager Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ObjectPoolManager();
                }

                return instance;
            }
        }


        public Character Human { get; private set; }
        public Character Monster { get; private set; }

        public Character Monster2 { get; private set; }

        public Character[] bullets;
        public Character bullets2 { get; private set; }

        public Character Item { get; private set; }

        public void CreateCharacters(Form1 form1)
        {
            Human = new Human(form1);
            Monster = new Monster(form1);
            Monster2 = new Monster2(form1);
;
            Item = new Item(form1);

            bullets = new Bullet[5];

            bullets2 = new Bullet2(form1);

            for(int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new Bullet(form1);
            }
        }
    }
}
