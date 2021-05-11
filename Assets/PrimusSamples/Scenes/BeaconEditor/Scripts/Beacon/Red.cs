using System.Collections.Generic;
using Primus.Toolbox.Beacon;

namespace PrimusSamples.BeaconEditor.Beacon
{
    public class Red : BaseBeacon<TypeBcn>
    {
        private List<Green> _childrenGreen;
        protected override void Awake()
        {
            base.Awake();
            BiblionTitle = TypeBcn.RED;
            _childrenGreen = new List<Green>();
        }
    }
}