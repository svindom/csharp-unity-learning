using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemForListDatabase : MonoBehaviour
{
    public List<ItemForList> itemDatabase = new List<ItemForList>();



    public void AddItem(int itemID, ItemForListPlayer player)
    {
        foreach (ItemForList item in itemDatabase) 
        {
            if (item.id == itemID)
            {
                Debug.Log("We have a match");
                player.inventory[0] = item;
                return;
            }
        }
        Debug.Log("The item does not exist!");
    }
    public void RemoveItem(int itemID, ItemForListPlayer player) 
    {
        foreach (ItemForList item in itemDatabase)
        {
            if(item.id == itemID)
            {
                Debug.Log("Item removed!");
                player.inventory[0] = null;
            }
        }
    }
}
