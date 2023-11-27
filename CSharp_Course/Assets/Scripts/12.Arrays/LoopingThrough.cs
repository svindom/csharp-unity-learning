using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemClass
{
    public int itemID;
    public string name;
    public string description;
}


public class LoopingThrough : MonoBehaviour
{
    public ItemClass[] myItems;
    void Start()
    {
        foreach (var item in myItems) 
        {
            Debug.Log(item.itemID);
        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomID = Random.Range(0, myItems.Length);

            //for (int i = 0; i < myItems.Length; i++)
            //{
            //    Debug.Log(myItems[randomID].name);
            //}

            Debug.Log(myItems[randomID].name);
        }
    }
}
