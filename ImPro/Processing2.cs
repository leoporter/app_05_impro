using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImPro
{
    class Processing2
    {
        public static Bitmap imSetRGBWeights(Bitmap image, decimal wR, decimal wG, decimal wB)
        {
            Bitmap temp = image;
            Bitmap clone = (Bitmap)temp.Clone();
            Color c;
            for (int i = 0; i < clone.Width; i++)
            {
                for (int j = 0; j < clone.Height; j++)
                {
                    c = clone.GetPixel(i, j);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;
                    int gray = (byte)(wR * r + wG * g + wB * b);
                    r = gray;
                    g = gray;
                    b = gray;
                    clone.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            return clone;
        }

        public static Bitmap imRotate(Bitmap image)
        {
            Bitmap temp = (Bitmap)image;
            Bitmap bmap = (Bitmap)temp.Clone();
            bmap.RotateFlip(RotateFlipType.Rotate180FlipY);
            image = (Bitmap)bmap.Clone();
            return image;
        }
    }
}
