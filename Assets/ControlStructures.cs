using UnityEngine;

public class ControlStructures : MonoBehaviour
{
    [SerializeField] int number;
    // Start is called before the first frame update
    void Start()
    {
        bool isEven = number % 2 == 0;

        if (isEven)
        {
            Debug.Log("Páros");
        }

    }
}
