using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreYouAlive : MonoBehaviour
{

    public int PlayerHealth = 100;

    void Update()
    {
        IsPlayerDead();
        AtackPlayer();
    }

    private void AtackPlayer()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           
            PlayerHealth -= RandomAtack();
        }  
    }

    public int RandomAtack()
    {
        return Random.Range(0, 11);  
    }

    public bool IsPlayerDead()
    {
        if (PlayerHealth <= 0) 
        {
            PlayerHealth = 0;
            Debug.Log("Player is dead");
            return true;
        }
        return false;
    }
}
