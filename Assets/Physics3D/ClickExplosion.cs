using UnityEngine;

public class ClickExplosion : MonoBehaviour
{
    Vector3 lastHit;
    void Update()
    {
        Camera cam = Camera.main;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        bool isHit = Physics.Raycast(ray, out RaycastHit hit);

        if (isHit)
        {
            Debug.Log($"HIT: {hit.collider.name} {hit.point}");
            lastHit = hit.point;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(lastHit, 0.3f);
    }
}
