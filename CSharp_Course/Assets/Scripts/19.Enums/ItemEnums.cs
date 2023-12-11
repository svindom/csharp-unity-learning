using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemEnums
{
    public string name;
    public int id;
    public Sprite icon;

    public enum ItemType
    {
        None,
        Weapon,
        Consumable
    }
    public ItemType itemType;

    public void Acting()
    {
        switch(itemType)
        {
            case ItemType.Weapon:
                Debug.Log("This is a " + itemType);
                break;
            case ItemType.Consumable:
                Debug.Log("This is a " + itemType);
                break;
        }
    }
}

