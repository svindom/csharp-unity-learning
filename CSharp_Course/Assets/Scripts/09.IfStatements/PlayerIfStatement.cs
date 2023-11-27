using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerIfStatement : MonoBehaviour
{
    // if I want keep it private but show it in unity
    // I can use [SerializeField] above a variable
    public int points = 0;
    private bool _hasSaidMessage = false;

    
    void Start()
    {
        

    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            points += 10;
            Debug.Log($"Your points is: {points}");
            
        }
        if(points > 50 && _hasSaidMessage == false)
        {
           Debug.Log("You are rock!");
           _hasSaidMessage = true;
        }
    }
}
