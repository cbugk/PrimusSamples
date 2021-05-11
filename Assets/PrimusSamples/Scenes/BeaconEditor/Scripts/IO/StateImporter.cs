using UnityEngine;
using Primus.Toolbox.Beacon;
using PrimusSamples.BeaconEditor.Beacon;
using PrimusSamples.BeaconEditor.State;
using PrimusSamples.BeaconEditor.Service;

namespace PrimusSamples.BeaconEditor.IO
{
    public static class StateImporter
    {
        public static void Load(State.BeaconEditor beaconEditorState)
        {
            YellowPages.Instance.MngrBcn.ClearBeacons();
            foreach (var beaconState in beaconEditorState.BeaconStates)
            {
                ParseBeacon(beaconState.Type, beaconState.Name, beaconState.Position.Vector3, beaconState.RotationAngle = 0);
            }
            YellowPages.Instance.MngrBcn.OnBeaconInstancesChanged();
        }

        static void ParseBeacon(string beaconTypeString, string name, Vector3 position, float rotationAngle)
        {
            TypeBcn beaconType = (TypeBcn)System.Enum.Parse(typeof(TypeBcn), beaconTypeString);
            GameObject beaconInstance = YellowPages.Instance.Bibliotheca.CheckOut(beaconType);

            if (beaconInstance)
            {
                beaconInstance.name = name;
                beaconInstance.transform.position = position;
                beaconInstance.GetComponent<BaseBeacon<TypeBcn>>().RotationAngle = rotationAngle;
                YellowPages.Instance.MngrBcn.EnlistBeaconInstance(beaconInstance);
            }
        }
    }
}
