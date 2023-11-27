using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge3 : MonoBehaviour
{
    public float _speed = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpeedUp();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            SpeedDown();
        }
    }

    void SpeedUp()
    {
        _speed += 5;
        if (_speed > 20)
        {
            Debug.Log("Slow down!");
        }
    }

    void SpeedDown()
    {
        _speed -= 5;
        if (_speed < 0)
        {
            Debug.Log("You can't go below 0!");
            _speed = 0;
        }
        else if (_speed < 20)
        {
            Debug.Log("Speed up!");
        }
    }

}
