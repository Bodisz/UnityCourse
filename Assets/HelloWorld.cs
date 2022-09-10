using UnityEngine;

class HelloWorld : MonoBehaviour
{
    void Start() 
        {
            Debug.Log("Hello World");
            Debug.Log("Hello World 2.0"); 
            Debug.Log($"My name is {name}"); 
            Debug.Log("My name is " + this.name); 
        }
}
