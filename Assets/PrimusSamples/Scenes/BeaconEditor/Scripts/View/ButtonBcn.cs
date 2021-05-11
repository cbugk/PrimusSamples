using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace PrimusSamples.BeaconEditor.View
{
    public class ButtonBcn : MonoBehaviour
    {
        private TMP_Text _text;

        public string Text
        {
            get => _text.text;
            set => _text.text = value;
        }

        private void Awake()
        {
            _text = GetComponentInChildren<TMP_Text>();
        }
        public void OnClick() { }
    }
}

