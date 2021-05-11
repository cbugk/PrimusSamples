using System;
using UnityEngine;

namespace PrimusSamples.BeaconEditor.View
{
    public class PnlListBcn : MonoBehaviour
    {
        [NonSerialized] public ScrlListBcn ScrollListBeacon;

        private void Awake()
        {
            ScrollListBeacon = GetComponentInChildren<ScrlListBcn>();
        }
    }
}