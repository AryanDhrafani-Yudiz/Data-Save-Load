using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private FixedJoystick fixedJoystick;

    void Update()
    {
        if (fixedJoystick.Horizontal > 0.1f) transform.position += new Vector3(fixedJoystick.Horizontal * speed * Time.deltaTime, 0, 0);
        else if (fixedJoystick.Horizontal < -0.1f) transform.position += new Vector3(fixedJoystick.Horizontal * speed * Time.deltaTime, 0, 0);
    }
}