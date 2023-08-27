using UnityEngine;

namespace Movers
{
    [RequireComponent(typeof(Collider))]
    public class MouseMover : MonoBehaviour
    {
        private Camera mainCamera;

        private void Start()
        {
            mainCamera = Camera.main;
        }

        private void FixedUpdate()
        {
            var ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out var hit, 100,LayerMask.GetMask("Default")))
            {
                transform.position = hit.point;
            }
                
        }

    }
}