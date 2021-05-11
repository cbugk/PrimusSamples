using System;
using UnityEngine;
using Primus.Toolbox.Service;
using PrimusSamples.BibliothecaSample.Biblion;
using PrimusSamples.BibliothecaSample.View;

namespace PrimusSamples.BibliothecaSample.Service
{
    /// <summary>Registry for intra-scenary components.</summary>
    public class YellowPages
        : BaseYellowPagesSingleton<YellowPages, ManagerView, Input>
    {
        public ManagerView MngrView { get; private set; }
        public Bibliotheca Bibliotheca { get; private set; }
        public Patron Patron { get; private set; }
        public override Input InputActions { get => Init.Service.YellowPages.Instance.InputActions; }

        protected override void Awake()
        {
            base.Awake();

            OnSceneActivated();

            ValidateFields();
        }

        protected override void ValidateFields()
        {
            base.ValidateFields();

            if (Bibliotheca == null) { throw new System.MissingMemberException("Bibliotheca"); }
            if (Patron == null) { throw new System.MissingMemberException("Patron"); }
        }

        public override void OnSceneActivated()
        {
            base.OnSceneActivated();

            Bibliotheca = FindObjectOfType<Bibliotheca>();
            Patron = FindObjectOfType<Patron>();
        }
    }
}