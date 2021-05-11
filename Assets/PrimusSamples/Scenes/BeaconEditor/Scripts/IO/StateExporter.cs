using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Primus.Toolbox.Beacon;
using PrimusSamples.BeaconEditor.Beacon;
using PrimusSamples.BeaconEditor.Service;

namespace PrimusSamples.BeaconEditor.IO
{
    public static class StateExporter
    {
        public static State.BeaconEditor StateEditor;
        public static void GenerateExport()
        {
            StateEditor = new State.BeaconEditor();
            List<GameObject> beaconInstances = YellowPages.Instance.MngrBcn.BeaconInstances;

            StateEditor.BeaconStates = new State.Beacon[beaconInstances.Count];
            for (int i = 0; i < beaconInstances.Count; i++)
            {
                BaseBeacon<TypeBcn> beacon = beaconInstances[i].GetComponent<BaseBeacon<TypeBcn>>();
                StateEditor.BeaconStates[i] = new State.Beacon();
                StateEditor.BeaconStates[i].Name = beaconInstances[i].name;
                StateEditor.BeaconStates[i].Type = beacon.BiblionTitle.ToString();
                StateEditor.BeaconStates[i].RotationAngle = beacon.RotationAngle;
                StateEditor.BeaconStates[i].Position.Vector3 = beaconInstances[i].transform.position;
            }
        }
    }
}