using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessMove : MonoBehaviour
{
    float _speed = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }
}
