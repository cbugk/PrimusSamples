using System;
using UnityEngine;
using Primus.Toolbox.Beacon;
using Primus.Toolbox.View;
using PrimusSamples.BeaconEditor.Beacon;

namespace PrimusSamples.BeaconEditor.View
{
    public class PnlSelectionBcn : MonoBehaviour
    {
        [NonSerialized] public BasePanelBeacon<TypeBcn>[] PanelBeacons;
        public GameObject BeaconInstance
        {
            get => _beaconInstance;
            set
            {
                OnBeaconChanged(value);
            }
        }

        private int _panelIndex;
        private GameObject _beaconInstance;

        private void Awake()
        {
            _beaconInstance = null;
            _panelIndex = -1;

            PanelBeacons = new BasePanelBeacon<TypeBcn>[3]
            {
                GetComponentInChildren<PnlBcnBlue>(),
                GetComponentInChildren<PnlBcnGreen>(),
                GetComponentInChildren<PnlBcnRed>()
            };
        }

        private void Start()
        {
            foreach (Component panel in PanelBeacons)
            {
                panel.gameObject.SetActive(false);
            }
        }

        private void Update()
        {
        }

        /// <summary>Updates children beacon panels' states.</summary>
        private void OnBeaconChanged(GameObject newBeaconInstance)
        {
            // If beacon instance did not change
            if (_beaconInstance == newBeaconInstance)
            {
                return;
            }

            // If null, disable previously active panel.
            if (!newBeaconInstance)
            {
                DisablePanelBeacon(_panelIndex);
                _panelIndex = -1;
            }
            // Else, disable previously active panel and enable new one.
            else
            {
                // Disable previous panel.            
                DisablePanelBeacon(_panelIndex);
                // Enable new panel and set new panel index.
                EnablePanelBeacon(newBeaconInstance, true);
            }

            // Save new instance
            _beaconInstance = newBeaconInstance;
        }

        private void DisablePanelBeacon(int index)
        {
            if (0 <= index)
            {
                PanelBeacons[index].ClearBeacon();
                PanelBeacons[index].gameObject.SetActive(false);
            }
        }

        private void EnablePanelBeacon(GameObject beaconInstance, bool saveIndex)
        {
            TypeBcn beaconTitle = beaconInstance.GetComponent<BaseBeacon<TypeBcn>>().BiblionTitle;

            int index = TitleToIndex(beaconTitle);

            if (0 <= index)
            {
                PanelBeacons[index].gameObject.SetActive(true);

                switch (beaconTitle)
                {
                    case TypeBcn.BLUE:
                        ((PnlBcnBlue)PanelBeacons[index]).Beacon = beaconInstance.GetComponent<Beacon.Blue>();
                        break;
                    case TypeBcn.GREEN:
                        ((PnlBcnGreen)PanelBeacons[index]).Beacon = beaconInstance.GetComponent<Beacon.Green>();
                        break;
                    case TypeBcn.RED:
                        ((PnlBcnRed)PanelBeacons[index]).Beacon = beaconInstance.GetComponent<Beacon.Red>();
                        break;
                }

                PanelBeacons[index].UpdatePanelRotation();
                PanelBeacons[index].UpdateFieldName();

                if (saveIndex)
                {
                    _panelIndex = index;
                }
            }
        }

        private int TitleToIndex(TypeBcn biblionTitle)
        {
            int index = -1;
            switch (biblionTitle)
            {
                case TypeBcn.BLUE:
                    index = 0;
                    break;
                case TypeBcn.GREEN:
                    index = 1;
                    break;
                case TypeBcn.RED:
                    index = 2;
                    break;
            }
            return index;
        }
    }
}
