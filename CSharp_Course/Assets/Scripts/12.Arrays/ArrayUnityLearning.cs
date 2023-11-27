using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayUnityLearning : MonoBehaviour
{
    public string[] names;
    void Start()
    {
        names[0] = "Alex Niunko";
        Debug.Log(names[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
