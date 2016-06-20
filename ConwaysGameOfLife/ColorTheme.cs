using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConwaysGameOfLife
{
    class ColorTheme
    {
        private Color myForeground;
        private Color myBackground;

        public ColorTheme(Color foreground, Color background)
        {
            myForeground = foreground;
            myBackground = background;
        }

        public Color GetForeground()
        {
            return myForeground;
        }
        public Color GetBackground()
        {
            return myBackground;
        }
    }
}
