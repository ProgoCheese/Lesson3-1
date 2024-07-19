using System.Drawing;

namespace ImageTest
{
    class Program
    {
        /// Черное белое
        //static void Main(string[] args)
        //{
        //    Bitmap image = new Bitmap("image.jpg");

        //    for (int y = 0; y < image.Height; ++y)
        //    {
        //        for (int x = 0; x < image.Width; ++x)
        //        {
        //            Color pixel = image.GetPixel(x, y);
        //            int color = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
        //            Color newColor = Color.FromArgb(color, color, color);

        //            image.SetPixel(x, y, newColor);
        //        }
        //    }

        //    image.Save("outGray.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

        //}

        ///Размытие
        static void Main(string[] args)
        {
            Bitmap image = new Bitmap("image.jpg");

            Bitmap blurImage = new Bitmap("image.jpg");

            for (int y = 1; y < image.Height - 1; ++y)
            {
                for (int x = 1; x < image.Width - 1; ++x)
                {
                    Color pixel = image.GetPixel(x, y);
                    Color pixel1 = image.GetPixel(x - 1, y - 1);
                    Color pixel2 = image.GetPixel(x, y - 1);
                    Color pixel3 = image.GetPixel(x + 1, y - 1);
                    Color pixel4 = image.GetPixel(x - 1, y);
                    Color pixel6 = image.GetPixel(x + 1, y);
                    Color pixel7 = image.GetPixel(x - 1, y + 1);
                    Color pixel8 = image.GetPixel(x, y + 1);
                    Color pixel9 = image.GetPixel(x + 1, y + 1);

                    int colorR = (pixel.R + pixel1.R + pixel2.R + pixel3.R + pixel4.R + pixel6.R + pixel7.R + pixel8.R + pixel9.R) / 9;
                    int colorG = (pixel.G + pixel1.G + pixel2.G + pixel3.G + pixel4.G + pixel6.G + pixel7.G + pixel8.G + pixel9.G) / 9;
                    int colorB = (pixel.B + pixel1.B + pixel2.B + pixel3.B + pixel4.B + pixel6.B + pixel7.B + pixel8.B + pixel9.B) / 9;

                    Color newColor = Color.FromArgb(colorR, colorG, colorB);

                    blurImage.SetPixel(x, y, newColor);
                }
            }

            blurImage.Save("outBlur.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

        }
    }
}
