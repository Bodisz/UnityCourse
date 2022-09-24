using UnityEngine;

public class follower : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 velocity = target.position - transform.position;

        float targetDistance = velocity.magnitude;
        //float targetDistance2 = Vector3.Distance(target.position, transform.position);

        Vector3 direction = velocity.normalized;

        float stepLength = Time.deltaTime * speed;

        if (targetDistance < stepLength)
        {
            stepLength = targetDistance;
        }

        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * speed);

       transform.rotation = Quaternion.LookRotation(direction);

    }
}
