using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

namespace VirtualCast.SampleScripts
{
    public class StartUp : MonoBehaviour
    {
        private void Start()
        {
            var subsystems = new List<XRInputSubsystem>();
            SubsystemManager.GetInstances(subsystems);
            foreach (var subsystem in subsystems)
            {
                subsystem.TrySetTrackingOriginMode(TrackingOriginModeFlags.Device);
            }
        }
    }
}