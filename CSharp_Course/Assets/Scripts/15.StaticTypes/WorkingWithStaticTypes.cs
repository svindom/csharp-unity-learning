using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkingWithStaticTypes : MonoBehaviour
{
    void Start()
    {
        
    }
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CubeScore.score += 10;
            Debug.Log($"Current score is {CubeScore.score}");
        }
        if(Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("It works");
        }    
    }
}

