using System;

namespace DP.Prototypes
{
    public class Prototype : ICloneable
    {
        public object Clone()
        {
            return new Prototype();
        }
    }
}