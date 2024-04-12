using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 velocity;
    [SerializeField] private float dampTime;
    [SerializeField] private Transform target;

    private void Awake()
    {
        Application.targetFrameRate = 120;
    }
    private void LateUpdate()
    {
        if (target)
        {
            Vector3 pointInScreen = Camera.main.WorldToViewportPoint(target.position);
            Vector3 delta = target.position - Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, pointInScreen.z));
            Vector3 destination = transform.position + delta;
            destination.y += 3;

            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }
    }
}