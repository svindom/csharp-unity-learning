using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapons : MonoBehaviour
{
    public int _weaponID;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(_weaponID)
        {
            case 0:
                Debug.Log("Sword");
                break;
            case 1:
                Debug.Log("Knife");
                break;
            case 2:
                Debug.Log("Dager");
                break;
            default:
                Debug.Log("Invalid input");
                break;
        }
    }
}
