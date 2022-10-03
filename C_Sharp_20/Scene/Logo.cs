using System;
using System.Windows.Forms;


namespace C_Sharp_4_jm
{
    class Logo : IScene
    {
        public PictureBox LogoPictureBox;

        public Logo(Form1 form1)
        {
            foreach (Control control in form1.Controls)
            {
                if (control is PictureBox && control.Tag == "ground")
                {
                    control.Visible = false;
                }
            }

            LogoPictureBox = new PictureBox();
            LogoPictureBox.Image = Properties.Resources.start_02;
            LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoPictureBox.Width = form1.Width;
            LogoPictureBox.Height = form1.Height;
            LogoPictureBox.Top = 0;
            LogoPictureBox.Left = 0;
            LogoPictureBox.Name = "LogoPicture";

            form1.Controls.Add(LogoPictureBox);

        }

        public void DownKey(KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                
            }
        }
        public void UpKey(KeyEventArgs e)
        {

        }

        public void Progress()
        {
           
        }

        public void Render()
        {

        }
    }
}
