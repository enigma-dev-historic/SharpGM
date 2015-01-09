using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpGM.Resources
{
    class GmObject
    {

        public enum PhysicsShape
        {
            CIRCLE,BOX,SHAPE
        }

        public enum PGmObject
        {
            SPRITE,SOLID,VISIBLE,DEPTH,PERSISTENT,PARENT,MASK,PHYSICS_OBJECT,PHYSICS_SENSOR,PHYSICS_SHAPE,
            PHYSICS_DENSITY,PHYSICS_RESTITUTION,PHYSICS_GROUP,PHYSICS_DAMPING_LINEAR,
            PHYSICS_DAMPING_ANGULAR,PHYSICS_FRICTION,PHYSICS_AWAKE,PHYSICS_KINEMATIC
        }

        private static readonly Dictionary<PGmObject,Object> DEFS = PropertyMap.makeDefaultMap<PGmObject>(
            null,false,true,0,false,null,null,false,false,PhysicsShape.CIRCLE,0.5,0.1,0,0.1,0.1,0.2,true,false);

    }
}
