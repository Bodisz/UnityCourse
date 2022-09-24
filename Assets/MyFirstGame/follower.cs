using UnityEngine;

public class follower : MonoBehaviour
{

    [SerializeField] Transform target;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 velocity = target.position - transform.position;


        velocity.Normalize();
        velocity *= Time.deltaTime;

        transform.position += velocity * speed;
    }
}
