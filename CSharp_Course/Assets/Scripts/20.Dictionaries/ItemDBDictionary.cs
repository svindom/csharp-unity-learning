using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDBDictionary : MonoBehaviour
{
    public int keyItem;
    public Dictionary<int, ItemDictionary> itemDictionary = new Dictionary<int, ItemDictionary>(); 

    private void Start()
    {
        ItemDictionary sword = CreateNewItem (0, "Sword");
        ItemDictionary bread = CreateNewItem (1, "Bread");
        ItemDictionary cape = CreateNewItem (2, "Cape");

        itemDictionary.Add(0, sword);
        itemDictionary.Add(1, bread);
        itemDictionary.Add(2, cape);

        //PrintItemDictionary(itemDictionary);
        //PrintOnlyKeyFromDictionary(itemDictionary);
        //PrintOnlyNamesFromDictionary(itemDictionary);
        CheckIfKeyExist(keyItem);
    }



    // Methods:

    public ItemDictionary CreateNewItem(int id, string name)
    {
        ItemDictionary newItem = new ItemDictionary();
        newItem.name = name;
        newItem.id = id;
        return newItem;
    }

    public void PrintItemFromDictionary(Dictionary<int, ItemDictionary> itemDictionary)
    {
        foreach(KeyValuePair<int, ItemDictionary> item in itemDictionary)
        {
            Debug.Log("Key: " + item.Key);
            Debug.Log("Value: " + item.Value.name);
        }
        Debug.Log("-------------------------------------------------------------------------");
    }

    public void PrintOnlyKeyFromDictionary(Dictionary<int, ItemDictionary> itemDictionary)
    {
        foreach(int key in itemDictionary.Keys)
        {
            Debug.Log("Key of an item is: " + key);
        }
        Debug.Log("-------------------------------------------------------------------------");
    }

    public void PrintOnlyNamesFromDictionary(Dictionary<int, ItemDictionary> itemDictionary)
    {
        foreach(ItemDictionary item in itemDictionary.Values)
        {
            Debug.Log("Item name is: " + item.name);
        }
        Debug.Log("-------------------------------------------------------------------------");
    }

    public void CheckIfKeyExist(int key)
    {
        if (itemDictionary.ContainsKey(key))
        {
            Debug.Log("You found the key!");
            ItemDictionary randomItem = itemDictionary[key];
        }
        else
        {
            Debug.Log($"Key \'{key}\' does not exist!");
        }
    }
}
