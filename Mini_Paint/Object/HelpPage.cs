using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Paint.Class
{
    public class HelpPage
    {
        static string sciezka = Environment.CurrentDirectory + "\\Pomoc.pdf";

        public HelpPage()
        {
            OtworzPDF();
        }

        private void OtworzPDF()
        {
            try
            {
                System.Diagnostics.Process.Start(sciezka);
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpienie jakiegoś błedu przy otwieraniu pliku " + sciezka, "Błąd.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
