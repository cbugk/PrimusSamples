using Primus.Core.Bibliotheca;
using UnityEngine;

namespace PrimusSamples.BibliothecaSample
{
    public class BiblionCube : BaseBiblion<SampleCatalog>
    {
        [field: SerializeField] public bool IsSpinning { get; set; }

        private void Awake()
        {
            BiblionTitle = SampleCatalog.CUBE;
        }

        private void Update()
        {
            if (IsSpinning) transform.Rotate(Vector3.up, 1.0f);
        }
    }
}