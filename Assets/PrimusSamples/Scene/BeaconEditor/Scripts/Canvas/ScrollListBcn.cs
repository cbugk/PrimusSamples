using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PrimusSamples.BeaconEditor.Canvas
{
    public class ScrollListBcn : MonoBehaviour
    {
        [SerializeField] private ButtonBcn _buttonPrefab;
        [NonSerialized] public List<GameObject> ButtonInstances;
        private GameObject _buttonInstanceCache;
        private RectTransform _viewPortTransform;
        private RectTransform _contentTransform;
        private List<GameObject> BeaconInstances { get => MgrScene.Instance.BeaconInstances; }
        private Vector2 _sizeDeltaCache;



        private void Awake()
        {
            ButtonInstances = new List<GameObject>();
            _viewPortTransform = GetComponentInChildren<Mask>().GetComponent<RectTransform>();
            _contentTransform = GetComponentInChildren<ContentSizeFitter>().GetComponent<RectTransform>();
        }

        public void AddButton(string name)
        {
            _buttonInstanceCache = GameObject.Instantiate(_buttonPrefab.gameObject);

            _buttonInstanceCache.GetComponent<ButtonBcn>().Text = name;

            _buttonInstanceCache.transform.SetParent(_contentTransform);

            RectTransform buttonTransform = _buttonInstanceCache.GetComponent<RectTransform>();
            _sizeDeltaCache.x = _viewPortTransform.sizeDelta.x;
            _sizeDeltaCache.y = buttonTransform.sizeDelta.y;
            buttonTransform.sizeDelta = _sizeDeltaCache;

            ButtonInstances.Add(_buttonInstanceCache);
        }

        public void ClearAndPopulate()
        {
            ButtonInstances.Clear();

            foreach (ButtonBcn buttonInstance in _contentTransform.GetComponentsInChildren<ButtonBcn>())
            {
                GameObject.Destroy(buttonInstance.gameObject);
            }

            for (int index = 0; index < BeaconInstances.Count; index++)
            {
                AddButton(BeaconInstances[index].name);
            }
            _buttonInstanceCache = null;
        }
    }
}
