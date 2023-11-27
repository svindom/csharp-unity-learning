using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class SwitchStatement : MonoBehaviour
{
    public int _selectedLevel;

    const int _easy = 0;
    const int _medium = 1;
    const int _hard = 2;  

    void Start()
    {
        _selectedLevel = UnityEngine.Random.Range(0, 3);
    }

    
    void Update()
    {
        //if (_selectedLevel == _easy)
        //{
        //    Debug.Log("You selected the easy level");
        //}
        //else if (_selectedLevel == _medium)
        //{
        //    Debug.Log("You selected the medium level");
        //}
        //else if (_selectedLevel == _hard)
        //{
        //    Debug.Log("You selected the hard level");
        //}
        //else
        //{
        //    Debug.Log("Invalid Selection");
        //}
        switch (_selectedLevel)
        {
            case _easy:
                Debug.Log("You selected the easy level");
                break;
            case _medium:
                Debug.Log("You selected the medium level");
                break;
            case _hard:
                Debug.Log("You selected the hard level");
                break;
            default:
                Debug.Log("Invalid Selection");
                break;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            _selectedLevel = UnityEngine.Random.Range(0, 3);
        }
        if(Input.GetKeyDown(KeyCode.X)) 
        {
            _selectedLevel = 55;
        }
    }
}
