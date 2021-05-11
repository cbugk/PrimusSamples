using System;
using Primus.Core.Serialization;

namespace PrimusSamples.BeaconEditor.State
{
    [Serializable]
    public class Beacon
    {
        public string Name;
        public string Type;
        public Float3 Position;
        public float Radius;
        public float RotationAngle;
    }
}