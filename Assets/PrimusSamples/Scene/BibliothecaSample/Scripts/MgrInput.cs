using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Primus.Toolbox.Input;
using PrimusSamples.Main;

namespace PrimusSamples.BibliothecaSample
{
    public class MgrInput
        : MonoBehaviour
        , IMgrInput<SceneType, Input, MgrScene>
    {
        public Input InputActions { get => Main.MgrInput.Instance.InputActions; }
    }
}