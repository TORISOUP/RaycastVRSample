using UnityEngine;
using UnityEngine.EventSystems;

namespace VirtualCast.SampleScripts
{
    public class LaserPointerInput : BaseInput
    {
        public override Vector2 mousePosition => _currentPosition;

        private Vector3 _currentPosition = Vector2.zero;

        public void OnEnter(Vector2 screenPosition)
        {
            _currentPosition = screenPosition;
        }

        public void OnExit()
        {
            _currentPosition = Vector3.zero;
        }
    }
}