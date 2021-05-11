using UnityEngine;
using Primus.Core.Singleton;

namespace PrimusSamples.Init
{
    [CreateAssetMenu(menuName = "ScriptableObjects/NewSingleton")]
    public class NewSingleton : BaseScriptableSingleton<NewSingleton>
    {
        protected override void OnEnable()
        {
            base.OnEnable();
            //Debug.LogWarning("Yello Yorld!");
        }
    }
}