using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float duration;
   
    Camera cam;
    float lifetime = 0;

    void Start()
    {
        if (cam == null)
        {
            cam = Camera.main;
        }
    }
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        float distance = Vector3.Distance(cam.transform.position, transform.position);
        if (cam.farClipPlane < distance)
        {
            Destroy(gameObject);
        }

        lifetime += Time.deltaTime;
        if (lifetime >= duration)
        {
            Destroy(gameObject);
        }
    }
}