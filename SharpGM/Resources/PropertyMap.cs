using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpGM.Resources
{
    class PropertyMap
    {
        public static Dictionary<enumeration, object> makeDefaultMap<enumeration>(params object[] values)
        {
            Dictionary<enumeration, object> ret = new Dictionary<enumeration, object>();
            Array names = Enum.GetValues(typeof(enumeration));
            // if values.Length is larger than names.Length than the user specified to initialize more values than is necessary
            for (int i = 0; i < values.Length; i++) {
                ret.Add((enumeration)names.GetValue(0), values[i]);
            }

            return ret;
        }
    }
}
