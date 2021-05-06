using System;
using UnityEngine;
using UnityEngine.UI;

namespace PrimusSamples.BeaconEditor.Canvas
{
    public class MgrCanvas
        : MonoBehaviour
    {
        public bool HasInitialized { get; private set; }
        [NonSerialized] public PnlListBcn PanelListBeacon;
        [NonSerialized] public PnlMain PanelMain;
        [NonSerialized] public PnlSelectionBcn PanelSelectionBeacon;
        [NonSerialized] public PnlMenuEsc PanelEscMenu;

        private void Awake()
        {
            HasInitialized = false;

            PanelMain = GetComponentInChildren<PnlMain>();
            PanelSelectionBeacon = GetComponentInChildren<PnlSelectionBcn>();
            PanelEscMenu = GetComponentInChildren<PnlMenuEsc>();
            PanelListBeacon = GetComponentInChildren<PnlListBcn>();
        }
        private void Start()
        {
            if (PanelEscMenu != null)
            {
                PanelEscMenu.gameObject.SetActive(false);
            }
            if (PanelListBeacon != null)
            {
                PanelListBeacon.gameObject.SetActive(false);
            }

            if (!HasInitialized)
            {
                AddListeners();
            }
            HasInitialized = true;
        }

        private void OnEnable()
        {
            if (HasInitialized)
            {
                AddListeners();
            }
        }

        private void OnDisable()
        {
            RemoveListeners();
        }

        private void AddListeners()
        {
            // Set listeners for Canvas elements
            PanelEscMenu.ButtonImport.onClick.AddListener(MgrScene.Instance.LoadState);
            PanelEscMenu.ButtonExport.onClick.AddListener(MgrScene.Instance.SaveState);
            PanelEscMenu.ButtonRefresh.onClick.AddListener(ClearAndPopulateListButtonBeacon);
        }

        private void RemoveListeners()
        {
            // Unset listeners for Canvas elements
            PanelEscMenu.ButtonImport.onClick.RemoveListener(MgrScene.Instance.LoadState);
            PanelEscMenu.ButtonExport.onClick.RemoveListener(MgrScene.Instance.SaveState);
            PanelEscMenu.ButtonRefresh.onClick.RemoveListener(ClearAndPopulateListButtonBeacon);
        }

        internal void ClearAndPopulateListButtonBeacon()
        {
            PanelListBeacon.ScrollListBeacon.ClearAndPopulate();
        }
    }
}
