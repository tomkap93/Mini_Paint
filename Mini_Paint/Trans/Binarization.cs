using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Paint.Class
{
    class BinarizationTrans
    {
        static public Bitmap Binarization(Bitmap picture, Bitmap copyPicture, Bitmap newPicture, PixelFormat formatObrazka, int step)
        {
       
            BitmapData dataOut = newPicture.LockBits(new Rectangle(0, 0, picture.Width, picture.Height), ImageLockMode.ReadWrite, formatObrazka);

            BitmapData dataIn = picture.LockBits(new Rectangle(0, 0, picture.Width, picture.Height), ImageLockMode.ReadOnly, formatObrazka);
            unsafe
            {

                byte* wskWyjsciowy = (byte*)dataOut.Scan0;
                byte* wskWejsciowy = (byte*)dataIn.Scan0;

                int nOffset = dataIn.Stride - picture.Width * 3;

              
                for (int y = 0; y < copyPicture.Height; y++)
                {
                    for (int x = 0; x < copyPicture.Width; x++)
                    {
                        if ((wskWejsciowy[0] + wskWejsciowy[1] + wskWejsciowy[2]) / 3 < step)
                        {
                            wskWyjsciowy[0] = wskWyjsciowy[1] = wskWyjsciowy[2] = 0;
                        }
                        else
                        {
                            wskWyjsciowy[0] = wskWyjsciowy[1] = wskWyjsciowy[2] = 255;
                        }
                        wskWejsciowy += 3; wskWyjsciowy += 3;
                    }
                    wskWejsciowy += nOffset; wskWyjsciowy += nOffset;
                }
                picture.UnlockBits(dataIn);
                newPicture.UnlockBits(dataOut);

                return newPicture;
            }
        }

    

    }
}
