using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    protected string petName;



    protected virtual void Speak()
    {
       
        int i = 2;
        int b = 3;

        i = b;
        Debug.Log("Speak" + i);


    }

    private void Start()
    {
        Speak();
    }
}
