using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class SimplePlugin : MonoBehaviour
{
    [DllImport("SimplePlugin")]
    private static extern int PrintANumber();

    [DllImport("SimplePlugin")]
    private static extern int AddTwoIntegers(int i1, int i2);

    [DllImport("SimplePlugin")]
    private static extern float AddTwoFloats(float f1, float f2);

    [DllImport("SimplePlugin")]
    private static extern float SubTwoIntegers(int i1, int i2);

    [DllImport("SimplePlugin")]
    private static extern float DivideTwoIntegers(int i1, int i2);

    [DllImport("SimplePlugin")]
    private static extern float MultiplyTwoIntegers(int i1, int i2);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PrintANumber());
        Debug.Log(AddTwoIntegers(2, 2));
        Debug.Log(AddTwoFloats(2.5f, 4f));

        Debug.Log(SubTwoIntegers(5, 4));
        Debug.Log(DivideTwoIntegers(4, 2));
        Debug.Log(MultiplyTwoIntegers(2, 2));

    }

    private void Update()
    {

    }
}
