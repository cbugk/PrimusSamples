using Primus.Core.Singleton;
using Primus.Toolbox.Service;

namespace PrimusSamples.BiblionShowcase.Service
{
    public class ProcessScene
        : BaseMonoSingleton<ProcessScene>
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
