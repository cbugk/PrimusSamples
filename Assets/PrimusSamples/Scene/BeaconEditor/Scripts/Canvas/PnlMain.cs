using System;
using UnityEngine;

namespace PrimusSamples.BeaconEditor.Canvas
{
    public class PnlMain : MonoBehaviour
    {
        [NonSerialized] public DropdownBcn DropdownBeacon;
        private void Awake()
        {
            DropdownBeacon = gameObject.GetComponentInChildren<DropdownBcn>();
        }

        private void Start()
        {
            if (DropdownBeacon)
            {
                DropdownBeacon.AddListener(value => MgrScene.Instance.BeaconTypeSelectedDropdown = DropdownBeacon.GetTitle(value));
            }
        }
    }
}
