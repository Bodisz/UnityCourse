using UnityEngine;

public class WelcomePractice : MonoBehaviour
{
    [SerializeField] Vector2 myFirst2DVector;
    [SerializeField] Vector3 myFirst3DVector;
    [SerializeField] Vector3 sum, difference;
    [SerializeField] float length;
    private void OnValidate()
    {
        //Ctrl + KD (formázás) és CTRL + RR (válozó átírás)
        Vector2 v2a = new Vector2(); // (0,0)
        Vector2 v2b = new Vector2(2.33f, 3f); // (2.33,3)
        Vector3 v3a = new Vector3(2.33f, 3); // (2.33,3,0)
        Vector3 v3b = new Vector3(2.33f, 3, 2); // (2.33,3,2)
        Vector3 v3c = new Vector3(); // (0,0,0)

        Vector3 v3d = Vector3.up; //(0, 1, 0)
        Vector3 v3e = Vector3.back; // (0, -1, 0)

        Vector3 v3f = Vector3.zero; // (0, 0, 0)
        Vector3 v3g = Vector3.one; // (1, 1, 1)

        //Vektor mûveletek
        sum = new Vector2(1, 2) + v2b + v2b;
        difference = (Vector3)myFirst2DVector - myFirst3DVector;

        length = v3b.magnitude;
        Vector3 normalised = v3b.normalized;


    }
}
