using UnityEngine;

public class VariablePractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int myFirstVariable;
        int ElsõVáltozóm;

        myFirstVariable = 5;
        myFirstVariable += 34;
        Debug.Log(myFirstVariable);
        string szovegem = myFirstVariable.ToString();
        Debug.Log(szovegem);

        int a = 3 + 5;
        int b = a - 11;
        int c = a * b;
        int d = a / 3;
        int maradek = a % 3;

        float f1 = 45.76f;
        float f2, f3 = 11.3f, f4 = 8;

        f2 = 22.44f;

        float sum = f1 + f2;
        float difference = f1 - f2;
        float product = f1 * f2;
        float rate = f1 / f2;

        float converted = sum + difference / product + rate;
        int tesztconv = (int)converted;
        Debug.Log(tesztconv);

        //Casting

        float f5 = 5;
        int i5 = (int) 5.5f;

        a = a + 5;
        a += 5;
        a++;

    }
}