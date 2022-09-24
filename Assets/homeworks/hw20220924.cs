using UnityEngine;

public class hw20220924: MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] string pairity;

    private void OnValidate()
    {
        bool hasNoRemainder = number % 2 == 0;
        if (hasNoRemainder) pairity = "páros"; else pairity = "páratlan";
    }


}
