using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpGM.Resources
{
    class Font
    {
        public enum PFont
        {
            FONT_NAME, SIZE, BOLD, ITALIC, ANTIALIAS, CHARSET
        }

        public static readonly Dictionary<PFont, object> DEFS = PropertyMap.makeDefaultMap<PFont>("Arial", 12, false, false, 3, 0);

    }
}
