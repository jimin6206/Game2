using System;
using System.Windows.Forms;

namespace C_Sharp_4_jm
{
    public partial class Form1 : Form
    {

        IScene currentScene;
  
        public Form1()
        {
            InitializeComponent();
            currentScene = new Stage(this);


        }

        private void DownKey(object sender, KeyEventArgs e)
        {
            
            currentScene.DownKey(e);

        }

        private void UpKey(object sender, KeyEventArgs e)
        {
            currentScene.UpKey(e);
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            
            currentScene.Progress();
            currentScene.Render();

            



        }
    }
}
