using UnityEngine;

namespace Movers
{
    [RequireComponent(typeof(Collider))]
    public class MouseMover : MonoBehaviour
    {
        private Camera mainCamera;
        private float CameraZDistance;

        private void Start()
        {
            mainCamera = Camera.main;
            CameraZDistance =
                mainCamera.WorldToScreenPoint(transform.position).z; //z axis of the game object for screen view
        }

        private float counter = 0;

        private void Update()
        {
            /*var screenPosition =
                new Vector3(Input.mousePosition.x, Input.mousePosition.y, CameraZDistance); //z axis added to screen point 
            var newWorldPosition =
                mainCamera.ScreenToWorldPoint(screenPosition); //Screen point converted to world point

            transform.position = newWorldPosition;*/
        }
        void FixedUpdate()
        {
            var ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out var hit, 100,LayerMask.GetMask("Default")))
            {
                transform.position = hit.point;
            }
                
        }

    }
}