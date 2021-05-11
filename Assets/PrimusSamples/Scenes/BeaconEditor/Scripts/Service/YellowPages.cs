using System;
using UnityEngine;
using Primus.Core.Singleton;
using PrimusSamples.BeaconEditor.Beacon;
using PrimusSamples.BeaconEditor.View;

namespace PrimusSamples.BeaconEditor.Service
{
    public class YellowPages : BaseMonoSingleton<YellowPages>
    {
        public BibliothecaBcn Bibliotheca { get; private set; }
        public BackgroundQuad Bckgrnd { get; private set; }
        public ManagerView MngrView { get; private set; }
        public ManagerBeacon MngrBcn { get; private set; }
        //public Input InputActions { get => Init.Service.YellowPages.Instance.InputActions; }

        protected override void Awake()
        {
            base.Awake();

            OnSceneActivated();

            ValidateFields();
        }

        private void ValidateFields()
        {
            if (Bibliotheca == null) { throw new System.MissingMemberException("Bibliotheca"); }
            if (Bckgrnd == null) { throw new System.MissingMemberException("BackgroundQuad"); }
            if (MngrView == null) { throw new System.MissingMemberException("ManagerView"); }
            if (MngrBcn == null) { throw new System.MissingMemberException("ManagerBeacon"); }
        }

        public void OnSceneActivated()
        {
            Bibliotheca = FindObjectOfType<BibliothecaBcn>();
            Bckgrnd = FindObjectOfType<BackgroundQuad>();
            MngrView = FindObjectOfType<ManagerView>();
            MngrBcn = FindObjectOfType<ManagerBeacon>();
        }
    }
}