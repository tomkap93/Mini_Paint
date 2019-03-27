using Mini_Paint.Class;
using Mini_Paint.Object;
using Mini_Paint.Trans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Paint
{
    public partial class miniPaint : Form
    {
        #region Zmienne
        private Graphics g;
        private Point p = Point.Empty;
        private Pen pioro;
        private Bitmap copyPicture;
        private Bitmap savePicture;
        TransImage transImage;
        private string sciezka = "";
        Write write = new Write();

   

        #endregion
        #region Konstruktor
        public miniPaint()
        {
            InitializeComponent();
            
              pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
           g = Graphics.FromImage(pictureBox.Image);
            pioro = new Pen(Color.Black);
            nud_widthpen.Value = (decimal)pioro.Width;
            transImage = new TransImage((Bitmap)pictureBox.Image);
            copyPicture =new Bitmap( pictureBox.Image);
            savePicture = new Bitmap(pictureBox.Image);
            
           
        }
    
        #endregion

        #region Metody

        public void Change()
        {
            gb_rysuj.Visible = !gb_rysuj.Visible;
            gb_trans.Visible = !gb_trans.Visible;
            change_b.Text = gb_rysuj.Visible ? "Transformacje" : "Rysowanie";

            if (gb_trans.Visible)
            {
               
                UpdatePicture();
                g = null;
            }
            else
            {
         
                copyPicture = new Bitmap(pictureBox.Image);
                g = Graphics.FromImage(pictureBox.Image);
            }


        }

        public void  UpdatePicture()
        {
            transImage.Picture = (Bitmap)pictureBox.Image;
        }

        #endregion

        #region Zdarzenia

        #region Rysuj
        private void b_rysuj_Click(object sender, EventArgs e)
        {
            g = Graphics.FromImage(pictureBox.Image);
        }
        private void kolor_b_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = kolor_b.BackColor;
            dialog.ShowDialog();
            kolor_b.BackColor = dialog.Color;
            pioro.Color = dialog.Color;
         
           
        }

        private void nud_widthpen_ValueChanged(object sender, EventArgs e)
        {
            pioro.Width = Convert.ToInt64(nud_widthpen.Value);
        }
        #endregion

        #region Transformacje
        private void b_szarosc_Click(object sender, EventArgs e)
        {
            pictureBox.Image = transImage.Picture = transImage.Trans(0, TransImage.TransKind.GreyScale);


        }

        private void b_negatyw_Click(object sender, EventArgs e)
        {

            pictureBox.Image = transImage.Picture = transImage.Trans(0, TransImage.TransKind.Negative);

          
        }

        private void tb_jasnosc_MouseUp(object sender, MouseEventArgs e)
        {

            pictureBox.Image  = transImage.Trans(tb_jasnosc.Value, TransImage.TransKind.Brightness);
        }


        private void tb_binaryzacja_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox.Image = transImage.Trans(tb_binaryzacja.Value, TransImage.TransKind.Binarization);
        }

        private void mouse_MouseEnter(object sender, EventArgs e)
        {
            UpdatePicture();
        }
        #endregion

        #region PictureBox
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && g !=null)
            {
                g.DrawLine(pioro, p, e.Location);
                p = e.Location;

                pictureBox.Refresh();
              
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && g != null)
                p = e.Location;


        }

        #endregion

        #region Inne
        private void wyczyćGrafikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (g==null)
            {
                g = Graphics.FromImage(pictureBox.Image);
                g.Clear(Color.White);
                g = null;
            }
            else
            {
                g.Clear(Color.White);
            }
       
            pictureBox.Refresh();
            copyPicture = new Bitmap(pictureBox.Image);
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpPage helpPage = new HelpPage();
        }

        private void change_b_Click(object sender, EventArgs e)
        {
            Change();
        }


        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sciezka == "")
            {
                zapiszJakoToolStripMenuItem_Click(sender, e);
            }
            else
            {

                write.WriteFile(pictureBox, sciezka);
                savePicture = new Bitmap(pictureBox.Image);

            }

          
        }



        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String filter = "JPEG files (*.jpg)|*.jpg| Bitmaps (*.bmp)|*.bmp";

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            if (filter.Length > 0) { dlg.Filter = filter; }

            if (dlg.ShowDialog(this) != DialogResult.Cancel)
            {
                if (dlg.FileName != null)
                {
                    pictureBox.Image = new Bitmap(dlg.FileName);
                    UpdatePicture();
                    tb_jasnosc.Value = 0;
                    tb_binaryzacja.Value = 0;
                    transImage = new TransImage((Bitmap)pictureBox.Image);
                    savePicture = new Bitmap(pictureBox.Image);

                    if (gb_rysuj.Visible)
                    {
                        copyPicture = new Bitmap(pictureBox.Image);
                        g = Graphics.FromImage(pictureBox.Image);
                    }
                  

                }
            }
        }
        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (gb_trans.Visible)
            {
                pictureBox.Image = transImage.Picture = transImage.CopyPicture;
                tb_jasnosc.Value = 0;
                tb_binaryzacja.Value = 0;
            }
            else
            {
                pictureBox.Image = copyPicture;
                copyPicture = new Bitmap(pictureBox.Image);
                pictureBox.Refresh();
                g = Graphics.FromImage(pictureBox.Image);
            }

        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "bmp|*.bmp";
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                sciezka = dialog.FileName;
                write.WriteFile(pictureBox, sciezka);
                savePicture = new Bitmap(pictureBox.Image);
            }
                

     
           
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wyczyćGrafikeToolStripMenuItem_Click(sender, e);
            sciezka = "";
        }
        #endregion

        #endregion




    }
}
