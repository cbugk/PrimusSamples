using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
using Primus.Core.Serialization;

namespace PrimusSamples.BeaconEditor.IO
{
    [Serializable]
    public class EditorState
    {
        public readonly string Version = "v0.0.1_sample";
        public string Name = "";
        public BeaconState[] BeaconStates;

        [Serializable]
        public class BeaconState
        {
            public string Name;
            public string Type;
            public Float3 Position;
            public float RotationAngle;
        }
    }
}