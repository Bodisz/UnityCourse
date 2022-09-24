using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] Vector3 velocity;
    [SerializeField] float angularSpeed = 360;
    [SerializeField] float speedMultiplier = 1.8f;
    void Update()
    {
        bool up = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        bool down = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.A);
        bool left = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.S);
        bool right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
        bool space = Input.GetKey(KeyCode.Space);
        bool shift = Input.GetKey(KeyCode.LeftShift);

        float x = 0, y = 0, z = 0, speed = 1, stepunit = 3;

        if (up) { z = stepunit; }
        if (down) { z -= stepunit; }
        if (right) { y = stepunit; }
        if (left) { y -= stepunit; }
        if (shift) { speed = speedMultiplier * stepunit; }

        velocity.Normalize();

        velocity.x = y * speed;
        velocity.z = z * speed;

        velocity *= Time.deltaTime;

        transform.position += velocity;

        //Forgatás
        //Quaternion rotation = transform.rotation;
        //Vector3 euler = rotation.eulerAngles;

        if (velocity != Vector3.zero) {
            transform.rotation = Quaternion.LookRotation(velocity); 
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(velocity), angularSpeed*Time.deltaTime);
        }
    }
}
