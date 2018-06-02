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
    }
}
