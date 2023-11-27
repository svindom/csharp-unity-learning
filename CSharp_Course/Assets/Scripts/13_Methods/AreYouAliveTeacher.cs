using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreYouAliveTeacher : MonoBehaviour
{
    
    public int Health = 100;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CheckIfDead() == false)
        {
            Damage(Random.Range(1, 11));
        }
    }

    public void Damage(int damageAmount)
    {
        Health -= damageAmount;

        if (CheckIfDead() == true)
        {
            Health = 0;
            Debug.Log("The Player has died");
        }
    }

    public bool CheckIfDead()
    {
        return Health < 1;
    }
}
