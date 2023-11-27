using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementSecondPart : MonoBehaviour
{
    public int _easyDifficulty = 0;
    public int _mediumDificulty = 1;
    public int _hardDificulty = 2;
    public int _currentDificulty;

    // Start is called before the first frame update
    void Start()
    {
        //_currentDificulty = _mediumDificulty;
    }

    // Update is called once per frame
    void Update()
    {
        if (_currentDificulty == _easyDifficulty)
        {
            Debug.Log("You selected easy level");
        }
        else if(_currentDificulty == _mediumDificulty)
        {
            Debug.Log("You selected medium level");
        }
        else if (_currentDificulty == _hardDificulty)
        {
            Debug.Log("You selected the hard level");
        }
        else
        {
            Debug.Log("Invalid input");
        }
    }
}
