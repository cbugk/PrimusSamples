using Primus.Core.Bibliotheca;
using UnityEngine;

namespace PrimusSamples.BibliothecaSample.Biblion
{
    public class BiblionCylinder : BaseBiblion<SampleCatalog>
    {
        [field: SerializeField] public bool IsSpinning { get; set; }

        private void Awake()
        {
            BiblionTitle = SampleCatalog.CYLINDER;
        }

        private void Update()
        {
            if (IsSpinning) transform.Rotate(Vector3.right, 1.0f);
        }
    }
}