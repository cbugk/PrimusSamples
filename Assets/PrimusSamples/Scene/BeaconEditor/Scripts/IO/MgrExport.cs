using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Primus.Toolbox.Beacon;
using PrimusSamples.BeaconEditor.Beacon;

namespace PrimusSamples.BeaconEditor.IO
{
    public static class MgrExport
    {
        public static EditorState BeaconEditorState;
        public static void GenerateExport()
        {
            BeaconEditorState = new EditorState();
            List<GameObject> beaconInstances = MgrScene.Instance.BeaconInstances;

            BeaconEditorState.BeaconStates = new EditorState.BeaconState[beaconInstances.Count];
            for (int i = 0; i < beaconInstances.Count; i++)
            {
                BaseBeacon<BeaconType> beacon = beaconInstances[i].GetComponent<BaseBeacon<BeaconType>>();
                BeaconEditorState.BeaconStates[i] = new EditorState.BeaconState();
                BeaconEditorState.BeaconStates[i].Name = beaconInstances[i].name;
                BeaconEditorState.BeaconStates[i].Type = beacon.BiblionTitle.ToString();
                BeaconEditorState.BeaconStates[i].RotationAngle = beacon.RotationAngle;
                BeaconEditorState.BeaconStates[i].Position.Vector3 = beaconInstances[i].transform.position;
            }
        }
    }
}