using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeIfStatement : MonoBehaviour
{
    private int[] _quizeArray = new int[5];
    private int _quizeAverage = 0;
    void Start()
    {        
        for (int i = 0; i<_quizeArray.Length; i++)
        {
            _quizeArray[i] = RandomQuizeValue();
            _quizeAverage += _quizeArray[i];
        }

        _quizeAverage /= _quizeArray.Length;



        if (_quizeAverage > 90)
        {
            Debug.Log("A " + _quizeAverage);
        }
        else if (_quizeAverage >= 80 && _quizeAverage <= 90)
        {
            Debug.Log("B " + _quizeAverage);
        }
        else if (_quizeAverage >= 70 && _quizeAverage <= 80)
        {
            Debug.Log("C " + _quizeAverage);
        }
        else if (_quizeAverage < 70)
        {
            Debug.Log("F " + _quizeAverage);
        }
    }

    
    void Update()
    {
        
    }

    int RandomQuizeValue()
    {
        int randomQuizeValue = Random.Range(0, 101);
        return (randomQuizeValue);
    }
}
