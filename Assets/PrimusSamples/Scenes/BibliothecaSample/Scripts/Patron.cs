using UnityEngine;
using PrimusSamples.BibliothecaSample.Biblion;
using PrimusSamples.BibliothecaSample.Service;

namespace PrimusSamples.BibliothecaSample
{
    public class Patron : MonoBehaviour
    {
        private int _frameCount;

        private void Awake()
        {
            _frameCount = 0;
        }

        private void Update()
        {
            if (_frameCount > 19) return;

            var myNewObject = YellowPages.Instance.Bibliotheca.CheckOut(SampleCatalog.CYLINDER);

            if (myNewObject != null)
            {
                myNewObject.transform.SetParent(transform);
                myNewObject.transform.localPosition = Vector3.zero;
                myNewObject.transform.Translate(Vector3.one * _frameCount);

                var myNewCylinder = myNewObject.GetComponent<BiblionCylinder>();
                if (myNewCylinder != null)
                    if (_frameCount % 2 == 0)
                        myNewCylinder.IsSpinning = true;
            }

            _frameCount++;
        }
    }
}