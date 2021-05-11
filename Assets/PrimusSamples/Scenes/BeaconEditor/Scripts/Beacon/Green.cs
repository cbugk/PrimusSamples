using System;
using UnityEngine;
using Primus.Core.Bibliotheca;
using Primus.Toolbox.Beacon;

namespace PrimusSamples.BeaconEditor.Beacon
{
    public class Green : BaseBeacon<TypeBcn>
    {
        protected override void Awake()
        {
            base.Awake();
            BiblionTitle = TypeBcn.GREEN;
        }
    }
}