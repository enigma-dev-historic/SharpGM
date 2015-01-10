using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SharpGM.Resources
{
    class GameInformation
    {
        public static readonly Color DEFAULT_COLOR = ColorTranslator.FromHtml("#FFFFE1");
        /*
        * the default rtf string is almost exactly the same as in fresh gm files
        * (no linebreaks in this one)
        */
        public static readonly string DEFAULT_TEXT = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033"
            + "{\\fonttbl{\\f0\\fnil Arial;}}{\\colortbl ;\\red0\\green0\\blue0;}"
            + "\\viewkind4\\uc1\\pard\\cf1\\f0\\fs24}";

        public enum PGameInformation
        {
            BACKGROUND_COLOR, EMBED_GAME_WINDOW, FORM_CAPTION, LEFT, TOP, WIDTH, HEIGHT, SHOW_BORDER, ALLOW_RESIZE,
            STAY_ON_TOP, PAUSE_GAME, TEXT
        }

        public static readonly Dictionary<PGameInformation, object> DEFS = PropertyMap.makeDefaultMap<PGameInformation>(
            DEFAULT_COLOR, false, "", -1, -1, 600, 400, true, true, false, true, DEFAULT_TEXT);

    }
}
