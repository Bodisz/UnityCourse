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
        else if (!isEven)
        {
            Debug.Log("Páratlan");
        }
        else
        { Debug.Log("Vége a világnak"); }


        int i = 1;
        while (i <= number+1)
        { 
            i++;
            Debug.Log(i);
        }

        for (int j = 0; j < number; j++)
        {
            Debug.Log(j);
        }
    }
}
