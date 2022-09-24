using UnityEngine;

public class rotator : MonoBehaviour
{
    [SerializeField] float angularSpeed = 360;
    void Update()
    {
        transform.Rotate(0, angularSpeed * Time.deltaTime, 0);
    }
}
