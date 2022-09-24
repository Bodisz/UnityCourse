using UnityEngine;

public class pathmover : MonoBehaviour
{
    [SerializeField] Vector3 pointA, pointB;
    [SerializeField, Range(0, 1)] float StartPosition;
    [SerializeField] float speed;

    bool toA = false;
    private void OnValidate()
    {
        //transform.position = (pointA + pointB) / 2;
        transform.position = Vector3.Lerp(pointA, pointB, StartPosition);
    }
    void Update()
    {
        Vector3 target = toA ? pointA : pointB;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (transform.position == target) { toA = !toA; }
    }



    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(pointA, 0.1f);
        Gizmos.DrawWireSphere(pointB, 0.1f);
        Gizmos.DrawLine(pointA, pointB);
    }
}
