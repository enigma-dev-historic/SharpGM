using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpGM.Resources
{
    public class Sound
    {
        public byte[] data = new byte[0];

        public enum SoundKind
        {
            NORMAL,BACKGROUND,SPATIAL,MULTIMEDIA
        }

        public enum SoundType
        {
            MONO,STEREO,THREED
        }

        //NOTE: Kind is different than type in the GMX format
        public enum PSound
        {
            KIND,FILE_TYPE,FILE_NAME,CHORUS,ECHO,FLANGER,GARGLE,REVERB,VOLUME,PAN,PRELOAD,BIT_RATE,
            SAMPLE_RATE,TYPE,BIT_DEPTH,COMPRESSED,STREAMED,DECOMPRESS_ON_LOAD
        }

        private static readonly Dictionary<PSound,Object> DEFS = PropertyMap.makeDefaultMap<PSound>(
            SoundKind.NORMAL,"","",false,false,false,false,false,1.0,0.0,true,192,44100,16,0,false,false,false);

    }
}
