using UnityEngine;

public class ClickExplosion : MonoBehaviour
{
    [SerializeField] float range;
    [SerializeField] float maxExplosionForce;
    [SerializeField] ParticleSystem particleSys;
    [SerializeField] LayerMask raycastMask;
 
    Rigidbody[] rigidbodies;
    Vector3 lastHit;

    private void Start()
    {
        rigidbodies = FindObjectsOfType<Rigidbody>();
    }
    void Update()
    {
        Camera cam = Camera.main;

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        bool isHit = Physics.Raycast(ray, out RaycastHit hit, 100, raycastMask);

        if (isHit)
        {
           // Debug.Log($"HIT: {hit.collider.name} {hit.point}");
            lastHit = hit.point;

            if (Input.GetMouseButton(0))
            {
                Explosion(hit.point);
            }
        }
    }

    void Explosion(Vector3 point)
    {
        transform.position = point;
        particleSys.Play();

        for (int i = 0; i < rigidbodies.Length; i++)
        {
            Rigidbody rb = rigidbodies[i];
            ExplosineOne(rb, point);
        }
    }
    void ExplosineOne(Rigidbody rg, Vector3 p)
    {
        Vector3 direction = rg.transform.position - p;
        float distance = direction.magnitude;

        if (distance >= range) return;

        direction /= distance;
        float forceMultiplier = 1 - (distance / range);

        Vector3 force = forceMultiplier * maxExplosionForce * direction;
        rg.AddForce(force, ForceMode.Impulse);
    }

   void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(lastHit, 0.3f);
    }
}
