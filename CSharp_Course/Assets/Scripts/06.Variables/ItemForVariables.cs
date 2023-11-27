using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemForVariables : MonoBehaviour
{
    public string _itemName;
    public string _itemDescription;
    public Sprite _itemIcon;
    public float _attackStrength;

    void Start()
    {
        Debug.Log("Name: " + _itemName);
        Debug.Log("Description: " + _itemDescription);
        Debug.Log("Atteck: " + _attackStrength);
    }

    
}
