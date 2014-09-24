using System;
using System.Drawing.Imaging;
using System.Windows;
using System.Drawing;

namespace Helpers
{
    class ScreenHelper
    {
        public static void SaveAllScreens( string fileName)
        {
            int screenWidth = Convert.ToInt32(SystemParameters.VirtualScreenWidth);
            int screenHeight = Convert.ToInt32(SystemParameters.VirtualScreenHeight);
            int screenLeft = Convert.ToInt32(SystemParameters.VirtualScreenLeft);
            int screenTop = Convert.ToInt32(SystemParameters.VirtualScreenTop);
            using (Bitmap bmp = new Bitmap(screenWidth, screenHeight, PixelFormat.Format32bppArgb))
            {
                using (Graphics gr = Graphics.FromImage(bmp))
                { 
                    gr.CopyFromScreen(screenLeft, screenTop, 0, 0, bmp.Size);
                    bmp.Save(fileName);
                }
            }
        }
    }
}
