using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubePosition : MonoBehaviour
{
    public Vector3 _startPosition;
    
    void Start()
    {
        // grab the current pos and asign to a new position using new Vector3();
        // transform.position = new Vector3(0, 0, 0);

        transform.position = _startPosition;
    }

    
    void Update()
    {
        
    }
}
