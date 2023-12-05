using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerProperties : MonoBehaviour
{
    private bool isGameOver;

    public bool IsGameOver
    {
        get
        {
            return isGameOver;
        }
        set
        {
            if (value == true)
            {
                Debug.Log("The Game is over!");
            }
            isGameOver = value;
        }
    }

    void Start()
    {
        isGameOver = false;

    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsGameOver = true;
        }
    }

}
