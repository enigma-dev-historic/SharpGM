using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace SharpGM.Resources
{
    class Background
    {
        private Image backgroundImage = null;

        public enum PBackground
        {
            TRANSPARENT, SMOOTH_EDGES, PRELOAD, USE_AS_TILESET, TILE_WIDTH, TILE_HEIGHT, H_OFFSET, V_OFFSET, H_SEP,
            V_SEP, TILE_HORIZONTALLY, TILE_VERTICALLY, FOR3D
        };

        public static readonly Dictionary<PBackground, object> DEFS = PropertyMap.makeDefaultMap<PBackground>(false,false,false,false,16,16,0,0,0,0,false,false,false);

        public Background()
        {

        }

    }
}
