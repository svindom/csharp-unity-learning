using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        // If space key pressed down
        // print a mesaage

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space Key");
        }

        //if e key held down
        //print a message
        if(Input.GetKey(KeyCode.E))
        {
            Debug.Log("Holding E");
        }

        //if f key is lifted up
        // print f
        if (Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("Fff");
        }
    }
}
