using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] Vector3 velocity;
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
        if (shift) { speed = 2 * stepunit; }

        velocity.Normalize();

        velocity.x = y * speed;
        velocity.z = z * speed;

        velocity *= Time.deltaTime;

        transform.position += velocity;
        
    }
}
