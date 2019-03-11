using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Paint.Class
{
    public class BrightnessTrans
    {

        static public Bitmap Brightness(Bitmap picture, Bitmap newPicture, PixelFormat formatObrazka, int step)
        {
            BitmapData dataOut = newPicture.LockBits(new Rectangle(0, 0, picture.Width, picture.Height), ImageLockMode.ReadWrite, formatObrazka);

            BitmapData dataIn = picture.LockBits(new Rectangle(0, 0, picture.Width, picture.Height), ImageLockMode.ReadOnly, formatObrazka);
            unsafe
            {

                byte* wskWyjsciowy = (byte*)dataOut.Scan0;
                byte* wskWejsciowy = (byte*)dataIn.Scan0;

                int nOffset = dataIn.Stride - picture.Width * 3;

                int nowaWartosc = 0;
                for (int y = 0; y < picture.Height; y++)
                {
                    for (int x = 0; x < picture.Width * 3; x++)
                    {
                        nowaWartosc = (int)(wskWejsciowy[0] + step);
                        if (nowaWartosc < 0) nowaWartosc = 0;
                        if (nowaWartosc > 255) nowaWartosc = 255;

                        wskWyjsciowy[0] = (byte)nowaWartosc;

                        wskWyjsciowy++; wskWejsciowy++;
                    }
                    wskWyjsciowy += nOffset; wskWejsciowy += nOffset;
                }
                picture.UnlockBits(dataIn);
                newPicture.UnlockBits(dataOut);

                return newPicture;
            }
        }
    }
}
