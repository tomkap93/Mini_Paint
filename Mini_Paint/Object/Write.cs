using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Paint.Object
{
    class Write
    {
      
        public void WriteFile(PictureBox picture, string nazwa)
        {
            if (nazwa != "")
            {
                try
                {
                    picture.Image.Save(nazwa);
                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd zapisu pliku " + nazwa, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nazwa = "";
                }
            }

        }

 
    }
}
