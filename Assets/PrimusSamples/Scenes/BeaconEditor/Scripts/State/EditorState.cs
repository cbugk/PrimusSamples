using System;
using Primus.Core.Serialization;

namespace PrimusSamples.BeaconEditor.State
{
    [Serializable]
    public class BeaconEditor
    {
        public readonly string Version = "v0.0.1_sample";
        public string Name = "";
        public State.Beacon[] BeaconStates;
    }
}