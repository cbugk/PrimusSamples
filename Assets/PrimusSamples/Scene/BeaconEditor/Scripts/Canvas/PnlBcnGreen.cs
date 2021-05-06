using Primus.Toolbox.UI;
using PrimusSamples.BeaconEditor.Beacon;

namespace PrimusSamples.BeaconEditor.Canvas
{
    public class PnlBcnGreen : BasePnlBcn<BeaconType>
    {
        private Beacon.Green _beaconGreen;
        public new Beacon.Green Beacon { get => _beaconGreen; set { _beaconGreen = value; base.Beacon = value; } }
    }
}

