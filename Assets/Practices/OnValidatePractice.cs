using UnityEngine;

class OnValidatePractice : MonoBehaviour
{

    [SerializeField, Tooltip("Minimum 100.")] int asd;
    [SerializeField, Min(0),] int intField;
    [SerializeField] float floatField;
    [SerializeField] string stringField;
    [SerializeField] bool boolField;
    [Space]
    [Header("Számok beállítása")]
    [SerializeField] int number;
    [SerializeField] bool isNumberEven; 
    
    private void OnValidate()
    {
        //Debug.Log(intField);
        if (number % 2 == 0) { isNumberEven = true; } else { isNumberEven = false; }
    }
}