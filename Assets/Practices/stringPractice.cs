using UnityEngine;

public class stringPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string myFirstString = "Hello Vil�g";
        string myName = "Bodisz";
        float myHeight = 1.8f;
        string introduction = $"My name is {myName} and I am {myHeight}m high.";
        Debug.Log(introduction);

        string aaa = "Hello";
        string bbb = "Vil�g";
        string ccc = aaa + " " + bbb;
    }
}
