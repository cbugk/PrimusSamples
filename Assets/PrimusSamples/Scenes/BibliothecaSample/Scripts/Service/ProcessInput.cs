using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Primus.Toolbox.Input;
using PrimusSamples.Init;

namespace PrimusSamples.BibliothecaSample.Service
{
    public class ProcessInput
        : MonoBehaviour
        , IDaemonInput<SceneType, ProcessScene>
    {
        public Input InputActions;// { get => Init.Service.ProcessInputMain.Instance.InputActions; }
    }
}