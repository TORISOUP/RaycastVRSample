using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace VirtualCast.SampleScripts
{
    public class LaserPointer : MonoBehaviour
    {
        [SerializeField] private LayerMask _layerMask;
        [SerializeField] private Camera _camera;
        [SerializeField] private LaserPointerInput _laserPointerInput;

        private Vector3 _origin;
        private Vector3 _direction;
        private bool _isHit;
        private RaycastHit _raycastHit;


        private void FixedUpdate()
        {
            _origin = transform.position;
            _direction = transform.up;
            _isHit = Physics.Raycast(_origin, _direction, out _raycastHit, 10, _layerMask,
                QueryTriggerInteraction.Ignore);

            if (_isHit)
            {
                OnRaycastHit(_raycastHit);
            }
            else
            {
                _laserPointerInput.OnExit();
            }
        }

        private void OnRaycastHit(RaycastHit hit)
        {
            var screenPosition = _camera.WorldToScreenPoint(hit.point);
            
            _laserPointerInput.OnEnter(screenPosition);
        }

        private void OnDrawGizmos()
        {
            if (_isHit)
            {
                Debug.DrawLine(_origin, _raycastHit.point, Color.green);
            }
            else
            {
                Debug.DrawLine(_origin, _origin + _direction * 10, Color.red);
            }
        }
    }
}