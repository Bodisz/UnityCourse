using UnityEngine;

public class fenymozgas : MonoBehaviour
{
    Vector3 velocity;
    // Start is called before the first frame update
    void Update()
    {
        float x = 0.5f, y = 0.5f, z = 0.5f;

        velocity.x += x;
        velocity.z += z;
        if (velocity.x >= 15) { velocity.x = -15; } 
        if (velocity.z >= 15) { velocity.z = -15; } 

        velocity *= Time.deltaTime;
        transform.position += velocity;

    }
}
