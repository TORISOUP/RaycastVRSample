using UnityEngine;
using UnityEngine.EventSystems;

namespace VirtualCast.SampleScripts
{
    public class LaserPointerStandaloneInputModule : StandaloneInputModule
    {
        [SerializeField] private LaserPointerInput _laserPointerInput;
        
        private void Start()
        {
            base.inputOverride = _laserPointerInput;
        }
    }
}
