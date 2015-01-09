using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpGM.Resources
{
    class Sprite
    {

        public enum BBMode
        {
            AUTO, FULL, MANUAL
        }

        public enum Effects
        {
            INVERT, FLIP, ROTATE
        }

        public enum MaskShape
        {
            PRECISE, RECTANGLE, DISK, DIAMOND, POLYGON
        }

        public enum PSprite
        {
            TRANSPARENT, SHAPE, ALPHA_TOLERANCE, SEPARATE_MASK, SMOOTH_EDGES, PRELOAD, ORIGIN_X, ORIGIN_Y, BB_MODE,
            BB_LEFT, BB_RIGHT, BB_TOP, BB_BOTTOM, TILE_HORIZONTALLY, TILE_VERTICALLY, FOR3D
        }

        private static readonly Dictionary<PSprite,Object> DEFS = PropertyMap.makeDefaultMap<PSprite>(
            false,MaskShape.RECTANGLE,0,false,false,true,0,0,BBMode.AUTO,0,31,0,31,false,false,false);

    }
}
