using UnityEngine;
using Primus.Toolbox.Beacon;
using PrimusSamples.BeaconEditor.Beacon;

namespace PrimusSamples.BeaconEditor.IO
{
    public static class MgrImport
    {
        public static void Load(EditorState beaconEditorState)
        {
            MgrScene.Instance.ClearBeacons();
            foreach (var beaconState in beaconEditorState.BeaconStates)
            {
                ParseBeacon(beaconState.Type, beaconState.Name, beaconState.Position.Vector3, beaconState.RotationAngle = 0);
            }
            MgrScene.Instance.OnBeaconInstancesChanged();
        }

        static void ParseBeacon(string beaconTypeString, string name, Vector3 position, float rotationAngle)
        {
            BeaconType beaconType = (BeaconType)System.Enum.Parse(typeof(BeaconType), beaconTypeString);
            GameObject beaconInstance = MgrScene.Instance.Bibliotheca.CheckOut(beaconType);

            if (beaconInstance)
            {
                beaconInstance.name = name;
                beaconInstance.transform.position = position;
                beaconInstance.GetComponent<BaseBeacon<BeaconType>>().RotationAngle = rotationAngle;
                MgrScene.Instance.EnlistBeaconInstance(beaconInstance);
            }
        }
    }
}
