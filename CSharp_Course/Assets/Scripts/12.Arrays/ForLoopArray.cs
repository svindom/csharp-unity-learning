using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopArray : MonoBehaviour
{
    public int[] itemID;
    public string[] itemName;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < itemName.Length; i++)
            {
                if (itemID[i] == 7)
                {
                    Debug.Log($"Item Name is: {itemName[7]}");
                }
            }
        }
    }
}
