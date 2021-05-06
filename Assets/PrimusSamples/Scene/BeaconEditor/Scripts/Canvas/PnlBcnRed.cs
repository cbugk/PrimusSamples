using UnityEngine;
using UnityEngine.UI;
using Primus.Toolbox.UI;
using PrimusSamples.BeaconEditor.Beacon;

namespace PrimusSamples.BeaconEditor.Canvas
{
    public class PnlBcnRed : BasePnlBcn<BeaconType>
    {
        private Beacon.Red _beaconRed;
        public new Beacon.Red Beacon { get => _beaconRed; set { _beaconRed = value; base.Beacon = value; } }
        public ScrollRect rect;

        protected override void Awake()
        {
            base.Awake();

            rect = GetComponentInChildren<ScrollRect>();
        }
    }
}
