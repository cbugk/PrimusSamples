using System.Collections.Generic;
using Primus.Toolbox.Beacon;

namespace PrimusSamples.BeaconEditor.Beacon
{
    public class Red : BaseBeacon<BeaconType>
    {
        private List<Green> _childrenGreen;
        protected override void Awake()
        {
            base.Awake();
            BiblionTitle = BeaconType.RED;
            _childrenGreen = new List<Green>();
        }
    }
}