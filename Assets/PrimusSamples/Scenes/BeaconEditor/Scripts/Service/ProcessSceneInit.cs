using Primus.Core.Singleton;
using Primus.Toolbox.Service;

namespace PrimusSamples.BeaconEditor.Service
{
    public class ProcessSceneInit
        : BaseMonoSingleton<ProcessSceneInit>
        , IDaemonScene<SceneType>
    {
        private void Start()
        {
            // Chain-loading every scene.
            // Runs for the first singleton created only.
            if (Instance == this) InitialLoadNextScene();
        }

        public void InitialLoadNextScene() { Init.Service.ProcessSceneMain.Instance.InitialLoadNextScene(); }
    }
}