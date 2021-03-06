﻿using System.Drawing;
using System;
using System.Globalization;

namespace OsuReplace
{
    class osuImage
    {
        public static void createAndSaveBackground(string imagePath, Color imageColor)
        {
            var image = new Bitmap(1920, 1080);
            var filledImage = Graphics.FromImage(image);

            using (SolidBrush B = new SolidBrush(Color.FromArgb(255, imageColor)))
                filledImage.FillRectangle(B, 0, 0, image.Width, image.Height);

            try
            {
                image.Save(imagePath);
            }

            catch (Exception)
            {
                Console.WriteLine("Error: Could not save solid color bitmap");
            }
        }

        public static Color colorFromString(string hexColor)
        {
            try
            {
                int RGBA = Int32.Parse(hexColor.Replace("#", ""), NumberStyles.HexNumber);
                return Color.FromArgb(RGBA);
            }

            catch (Exception)
            {
                Console.WriteLine(String.Format("Error: {0} is not a valid hexadecimal color", hexColor));
                return Color.Black;
            }
        }      
    }
}
