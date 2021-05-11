using System;
using UnityEngine;
using PrimusSamples.BeaconEditor.Service;

namespace PrimusSamples.BeaconEditor.View
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
                DropdownBeacon.AddListener(value => YellowPages.Instance.MngrBcn.BeaconTypeSelectedDropdown = DropdownBeacon.GetTitle(value));
            }
        }
    }
}
