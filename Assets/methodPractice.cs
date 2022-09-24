using UnityEngine;

public class methodPractice : MonoBehaviour
{
    [SerializeField] float number;
    [SerializeField] float absNumber;
    [SerializeField] float signNumber;

    private void OnValidate()
    {
        Debug.Log("hellomelo");
        absNumber = Mathf.Abs(number);
        signNumber = Mathf.Sign(number);
    }
}
