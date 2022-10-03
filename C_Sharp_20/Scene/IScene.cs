using System;
using System.Windows.Forms;

namespace C_Sharp_4_jm
{
    interface IScene
    {
        
        void Progress();
        void Render();

        void DownKey(KeyEventArgs e);
        void UpKey(KeyEventArgs e);



    }
}
