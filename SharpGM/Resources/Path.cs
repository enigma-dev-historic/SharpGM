using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpGM.Resources
{
    class Path
    {

        public enum PPath
        {
            SMOOTH, CLOSED, PRECISION, BACKGROUND_ROOM, SNAP_X, SNAP_Y
        }

        public static readonly Dictionary<PPath, object> DEFS = PropertyMap.makeDefaultMap<PPath>(false, true, 4, null, 16, 16);

    }
}
