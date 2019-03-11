using Mini_Paint.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Paint.Trans
{
    public class TransImage
    {
        public enum TransKind
        {
            Brightness, GreyScale, Binarization, Negative
        }

        private Bitmap picture;
    
        private Bitmap copyPicture; 

        public TransImage(Bitmap img)
        {
            this.copyPicture = this.picture = img;
        }
        public Bitmap Picture
        {
            get
            {
                return picture;
            }
            set
            {
                picture = value;
            }
        }

        public Bitmap CopyPicture
        {
            get
            {
                return copyPicture;
            }
        }
     
        
        public Bitmap Trans(int step, TransKind  transkind)
        {
            if (copyPicture.PixelFormat != PixelFormat.Format8bppIndexed && copyPicture.PixelFormat != PixelFormat.Format24bppRgb)
            {
                Bitmap bmp = new Bitmap(copyPicture.Width, copyPicture.Height, PixelFormat.Format24bppRgb);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawImage(copyPicture, 0, 0, copyPicture.Width, copyPicture.Height);
                g.Dispose();
                copyPicture = bmp;
                picture = bmp;
            } 

            PixelFormat formatObrazka = (picture.PixelFormat == PixelFormat.Format8bppIndexed) ? PixelFormat.Format8bppIndexed : PixelFormat.Format24bppRgb;
            Bitmap newPicture = new Bitmap(copyPicture.Width, copyPicture.Height, PixelFormat.Format24bppRgb);


                switch (transkind)
                {
                    case TransKind.Brightness:

                        newPicture =   BrightnessTrans.Brightness(picture, newPicture, formatObrazka, step);
                        break;

                    case TransKind.GreyScale:

                        GreyScaleTran.GreyScale(picture, copyPicture, newPicture, formatObrazka);
                        break;


                    case TransKind.Negative:

                        newPicture = NegativeTrans.Negative(picture, copyPicture, newPicture, formatObrazka);
                        break;
                    case TransKind.Binarization:

                        newPicture = BinarizationTrans.Binarization(picture, copyPicture, newPicture, formatObrazka, step);
                        break;
                }
            

                return newPicture;
            
        }
    }
}
