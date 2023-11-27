using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchColorCube : MonoBehaviour
{
    public GameObject _cube;
    private int _nextColor = 0;
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _nextColor = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _nextColor = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _nextColor = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _nextColor = 3;
        }
        NextColor();
    }

    void NextColor()
    {
        switch (_nextColor)
        {
            case 0:
                _cube.GetComponent<Renderer>().material.color = Color.blue; 
                break;
            case 1:
                _cube.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                _cube.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 3:
                _cube.GetComponent<Renderer>().material.color = Color.yellow;
                break;
            default:
                Debug.Log("Invalid Selection");
                break;

        }
    }
}
