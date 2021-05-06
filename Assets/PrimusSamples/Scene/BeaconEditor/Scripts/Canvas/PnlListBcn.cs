using System;
using UnityEngine;

namespace PrimusSamples.BeaconEditor.Canvas
{
    public class PnlListBcn : MonoBehaviour
    {
        [NonSerialized] public ScrollListBcn ScrollListBeacon;

        private void Awake()
        {
            ScrollListBeacon = GetComponentInChildren<ScrollListBcn>();
        }
    }
}