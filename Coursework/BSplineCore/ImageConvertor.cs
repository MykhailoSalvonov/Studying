using System.Drawing;

namespace BSplineCore
{
    public class ImageConvertor
    {
        public static byte[,,] ConvertImageTo3DArray(string imagePath)
        {
            Bitmap bitmap = new Bitmap(imagePath);
            int width = bitmap.Width;
            int height = bitmap.Height;

            byte[,,] rgbArray = new byte[width, height, 3];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixel = bitmap.GetPixel(x, y);

                    rgbArray[x, y, 0] = pixel.R;
                    rgbArray[x, y, 1] = pixel.G;
                    rgbArray[x, y, 2] = pixel.B;
                }
            }

            bitmap.Dispose();
            return rgbArray;
        }
    }
}
