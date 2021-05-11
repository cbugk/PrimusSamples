using Primus.Toolbox.View;
using PrimusSamples.BeaconEditor.Beacon;

namespace PrimusSamples.BeaconEditor.View
{
    public class PnlBcnGreen : BasePanelBeacon<TypeBcn>
    {
        private Beacon.Green _beaconGreen;
        public new Beacon.Green Beacon { get => _beaconGreen; set { _beaconGreen = value; base.Beacon = value; } }
    }
}

