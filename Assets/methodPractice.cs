using UnityEngine;

public class methodPractice : MonoBehaviour
{
    [SerializeField] float number1, number2;
    [SerializeField] float absNumber;
    [SerializeField] float signNumber;
    [SerializeField] float min, max;

    private void OnValidate()
    {
        Debug.Log("hellomelo");
        absNumber = Abs(number1);
        signNumber = Mathf.Sign(number1);

        min = Mathf.Min(number1, number2);
        max = Mathf.Max(number1, number2);
    }

    float Abs(float n)
    {
        if (n < 0) n *= -1;
        return n;
    }

    float Sign(float n)
    {
        if (n <= 0) n = -1; else n = 1;
        return n;
    }

    float Min(float a, float b)
    {
        if (a <= b) return a;  return b;
    }
}
