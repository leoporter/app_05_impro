using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImPro
{
    class Processing
    {
        public Processing()
        {

        }

        public static Bitmap imToGray(Bitmap newBitmap)
        {
            for (int i = 0; i < newBitmap.Width; i++)
            {
                for (int j = 0; j < newBitmap.Height; j++)
                {
                    Color c = newBitmap.GetPixel(i, j);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;
                    int gray = (byte)(0.299 * r + 0.587 * g + 0.114 * b);
                    r = gray;
                    g = gray;
                    b = gray;
                    newBitmap.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            return newBitmap;
        }

        public static int imCountPixels(Bitmap image)
        {
            int count = 0;
            HashSet<Color> colors = new HashSet<Color>();
            if (image != null)
            {
                for (int i = 0; i < image.Size.Width; i++)
                {
                    for (int j = 0; j < image.Size.Height; j++)
                    {
                        colors.Add(image.GetPixel(i, j));
                    }
                }
                count = colors.Count;
            }
            return count;
        }


        public static int[,] createMask(int dimension)                  // funkcja zwracająca dwuwymiarową tablicę
        {
            int[,] mask = new int[dimension,dimension];                 // tworzy dwuwymiarową macierz (maskę)
            for(int i=0; i<dimension; i++)
            {
                for(int j=0; j<dimension; j++)
                {
                    mask[i, j] = 1;
                }
            }
            return mask;
        }

        public static Bitmap imLowPassFilter(Bitmap newBitmap, int dimension)
        {
            int[,] mask = createMask(dimension);
            int[,] minor = new int[3,3];
            int edgeLeft = (dimension / 2) + 1;
            int edgeRight = newBitmap.Width - edgeLeft;
            int edgeUp = (dimension / 2) + 1;
            int edgeDown = newBitmap.Height - edgeUp;

            for (int i = edgeLeft; i < edgeRight; i++)
            {
                for (int j = edgeUp; j < edgeDown; j++)
                {

                }
            }
            return newBitmap;
        }

        public static Bitmap imAverageFilter(Bitmap newBitmap)
        {
            double[] tab = new double[9];
            double sum = 0;
            Color color;
            double av;
            byte value;
            for (int i = 1; i < newBitmap.Width-1; i++)
            {
                for (int j = 1; j < newBitmap.Height-1; j++)
                {
                    tab[0] = Convert.ToDouble(newBitmap.GetPixel(i-1,j-1).ToArgb());
                    tab[1] = Convert.ToDouble(newBitmap.GetPixel(i - 1, j).ToArgb());
                    tab[2] = Convert.ToDouble(newBitmap.GetPixel(i - 1, j + 1).ToArgb());
                    tab[3] = Convert.ToDouble(newBitmap.GetPixel(i, j - 1).ToArgb());
                    tab[4] = Convert.ToDouble(newBitmap.GetPixel(i, j).ToArgb());
                    tab[5] = Convert.ToDouble(newBitmap.GetPixel(i, j + 1).ToArgb());
                    tab[6] = Convert.ToDouble(newBitmap.GetPixel(i + 1, j - 1).ToArgb());
                    tab[7] = Convert.ToDouble(newBitmap.GetPixel(i + 1, j).ToArgb());
                    tab[8] = Convert.ToDouble(newBitmap.GetPixel(i + 1, j + 1).ToArgb());
                    sum = tab[0] + tab[1] + tab[2] + tab[3] + tab[4] + tab[5] + tab[6] + tab[7] + tab[8];
                    av = sum / 9;
                    value = Convert.ToByte(av);
                    color = Color.FromArgb(value);
                    newBitmap.SetPixel(i, j, color);
                }
            }
            return newBitmap;
        }

        public static Bitmap imSetColorFilter(Bitmap image, string colorFilterType)
        {
            Color c;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    c = image.GetPixel(i,j);
                    int nPixelR = 0;
                    int nPixelG = 0;
                    int nPixelB = 0;

                    if(colorFilterType == "Red")
                    {
                        nPixelR = c.R;
                        nPixelG = c.G - 255;
                        nPixelB = c.B - 255;
                    }

                    else if(colorFilterType == "Green")
                    {
                        nPixelR = c.R - 255;
                        nPixelG = c.G;
                        nPixelB = c.B - 255;
                    }

                    else if (colorFilterType == "Blue")
                    {
                        nPixelR = c.R - 255;
                        nPixelG = c.G - 255;
                        nPixelB = c.B;
                    }

                    nPixelR = Math.Max(nPixelR, 0);
                    nPixelR = Math.Min(255,nPixelR);

                    nPixelG = Math.Max(nPixelG, 0);
                    nPixelG = Math.Min(255, nPixelG);

                    nPixelB = Math.Max(nPixelB, 0);
                    nPixelB = Math.Min(255, nPixelB);

                    image.SetPixel(i,j,Color.FromArgb((byte)nPixelR, (byte)nPixelG, (byte)nPixelB));
                }
            }
            return image;
        }

        public static Bitmap imSetBrightness(Bitmap image, int brightness)
        {
            Bitmap temp = image;
            Bitmap clone = (Bitmap)temp.Clone();
            Color c;

            if (brightness < -255)
            {
                brightness = -255;
            }
            if(brightness > 255)
            {
                brightness = 255;
            }

            for (int i = 0; i < clone.Width; i++)
            {
                for (int j = 0; j < clone.Height; j++)
                {
                    c = clone.GetPixel(i, j);
                    int cR = c.R + brightness;
                    int cG = c.G + brightness;
                    int cB = c.B + brightness;

                    if (cR < 0) cR = 1;
                    if (cR > 255) cR = 255;
                    if (cG < 0) cG = 1;
                    if (cG > 255) cG = 255;
                    if (cB < 0) cB = 1;
                    if (cB > 255) cB = 255;

                    clone.SetPixel(i,j,Color.FromArgb((byte)cR, (byte)cG, (byte)cB));
                }
            }

            return clone;
        }

        public static Bitmap imSetInvert(Bitmap image)
        {
            Bitmap temp = image;
            Bitmap clone = (Bitmap)temp.Clone();
            Color c;
            for (int i = 0; i < clone.Width; i++)
            {
                for (int j = 0; j < clone.Height; j++)
                {
                    c = clone.GetPixel(i,j);
                    clone.SetPixel(i,j,Color.FromArgb(255-c.R, 255-c.G, 255-c.B));
                }
            }
            return clone;
        }
    }
}
