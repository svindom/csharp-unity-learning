using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge2 : MonoBehaviour
{
    public GameObject _cube;
    public int _score = 0;

    private void Awake()
    {
        
        _cube.GetComponent<Renderer>().material.color = Color.red;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            _score+= 15;
            MakeCubeGreen();
        }
    }
    void MakeCubeGreen() 
    {
        if (_score >= 50)
        {
            _cube.GetComponent<Renderer>().material.color= Color.green;
        }
    }
}
