using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    
    public Item sword;   
    public Item axe;    
    public Item bread;

    void Start()
    {
        sword = new Item("Sword",1, "This is a legendary sword" );
        axe = new Item("Axe", 2, "This is an axe");

        // Calling the CreateItem method
        bread = CreateItem("Bread", 3, "It restores your health");
    }


    // A method that creats items
    private Item CreateItem (string name, int id, string description)
    {
        Item item = new Item(name,id,description);
        return item;
    }
    
}
