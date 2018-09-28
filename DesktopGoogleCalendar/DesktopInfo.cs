using System;
using System.Windows.Forms;

namespace DesktopGoogleCalendar
{
    class DesktopInfo
    {
        private int height;
        private int width;
        private int xMin;
        private int xMax;

        public DesktopInfo()
        {
            width = SystemInformation.VirtualScreen.Width;
            height = SystemInformation.VirtualScreen.Height;

            foreach(Screen s in Screen.AllScreens)
            {
                xMax = Math.Max(xMax, s.Bounds.Right);
                xMin = Math.Min(xMin, s.Bounds.Left);
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
        }

        public int XMax
        {
            get
            {
                return xMax;
            }
        }

        public int XMin
        {
            get
            {
                return xMin;
            }
        }
    }
}
