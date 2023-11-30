using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTest
{
    public string nameObj;
    public int itemID;


    public static int itemCount;
    public ItemTest()
    {
        itemCount++;
    }

}

public class InstanceVsStaic : MonoBehaviour
{
    void Start()
    {
        ItemTest sword = new ItemTest();
        ItemTest bread = new ItemTest();
        ItemTest cape = new ItemTest();
        ItemTest fish = new ItemTest();
        Debug.Log($"Item count is: {ItemTest.itemCount}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
