using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Primus.Toolbox.UI;
using PrimusSamples.BeaconEditor.Beacon;

namespace PrimusSamples.BeaconEditor.Canvas
{
    public class PnlBcnBlue : BasePnlBcn<BeaconType>
    {
        private Beacon.Blue _beaconBlue;
        public new Beacon.Blue Beacon { get => _beaconBlue; set { _beaconBlue = value; base.Beacon = value; } }

        protected override void Awake()
        {
            base.Awake();
        }

        protected virtual void Update()
        {
        }

        internal void ManualUpdate()
        {
            Beacon.RotationAngle -= 20.0f * Time.deltaTime;
        }
    }
}
