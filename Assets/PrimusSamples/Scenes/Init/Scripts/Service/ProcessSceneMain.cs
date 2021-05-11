using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using Primus.Core.Singleton;
using Primus.Toolbox.View;
using Primus.Toolbox.Service;

namespace PrimusSamples.Init.Service
{

    public class ProcessSceneMain
        : BaseMonoSingleton<ProcessSceneMain>
        , IDaemonSceneMain<SceneType>
    {
        // Public, internal, and/or Serialized.
        protected readonly SceneType SceneTypeSelf = SceneType.INIT;
        public bool isInitialized { get; private set; }
        public SceneType SceneTypeActive { get; private set; }
        public int NumberOfScenes { get; private set; }

        // Private and/or protected

        private void Start()
        {
            SetDefaults();

            isInitialized = true;

            // Chain-loading every scene.
            // Runs for the first singleton created only.
            if (Instance == this) InitialLoadNextScene();
        }

        private void SetDefaults()
        {
            isInitialized = false;
            NumberOfScenes = Enum.GetValues(typeof(SceneType)).Length;
            SceneTypeActive = SceneTypeSelf;
        }

        public void InitialLoadNextScene()
        {
            int indexBuild = SceneManager.GetActiveScene().buildIndex;

            int indexNext = -1;
            // If not the last, increment. If the last wrap back to start.
            indexNext = (indexBuild + 1 < NumberOfScenes) ? (indexBuild + 1) : 0;

            Debug.Log($"current: {indexBuild}, {SceneTypeActive}; next: {indexNext}, {SceneTypeFromInt(indexNext)}");

            SetManagerActive(SceneTypeFromInt(indexBuild), false);

            SceneTypeActive = SceneTypeFromInt(indexNext);
            SceneManager.LoadScene(indexNext, LoadSceneMode.Single);
        }

        public void SwitchTo(SceneType type)
        {
            // If same scene, do not act.
            if (Enum.Equals(type, SceneTypeActive)) { return; }

            // Disables current manager unless INIT
            SetManagerActive(SceneTypeActive, false);

            // Enables desired scene's manager.
            SetManagerActive(type, true);
            SceneTypeActive = type;
            SceneManager.LoadScene(IntFromSceneType(type), LoadSceneMode.Single);
        }

        public void SetManagerActive(SceneType type, bool value)
        {
            switch (type)
            {
                case SceneType.INIT:
                    // DaemonScene cannot be deactivated for INIT.
                    break;
                case SceneType.BEACON_EDITOR:
                    //BeaconEditor.Service.ProcessSceneInit.Instance.gameObject.SetActive(value);
                    break;
                case SceneType.BIBLION_SHOWCASE:
                    //BiblionShowcase.Service.ProcessScene.Instance.gameObject.SetActive(value);
                    break;
                case SceneType.BIBLIOTHECA_SAMPLE:
                    //BibliothecaSample.Service.ProcessScene.Instance.gameObject.SetActive(value);
                    break;
            }
        }

        private bool ValidateIndex(int index)
        {
            if (0 <= index || index < NumberOfScenes) { return true; }
            return false;
        }

        public int IntFromSceneType(SceneType sceneType) => (int)sceneType;

        public SceneType SceneTypeFromInt(int sceneIndex) => (SceneType)sceneIndex;
    }
}