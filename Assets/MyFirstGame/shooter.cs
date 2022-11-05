using UnityEngine;

public class shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrototype;
    [SerializeField] KeyCode button;
    void Update()
    {
        if(Input.GetKeyDown(button))
        {
            // GameObject newGameObject = new GameObject();
            GameObject newGameObject = Instantiate(projectilePrototype, transform.position, transform.rotation);
           // newGameObject.transform.position = transform.position;
           // newGameObject.transform.rotation = transform.rotation;
        }
    }
}
