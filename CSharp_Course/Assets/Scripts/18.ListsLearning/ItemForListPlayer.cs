using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemForListPlayer : MonoBehaviour
{
    public ItemForList[] inventory = new ItemForList[10];
    private ItemForListDatabase _itemDatabase;


    private void Start()
    {
        _itemDatabase = GameObject.Find("DataBase").GetComponent<ItemForListDatabase>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _itemDatabase.AddItem(0, this);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            _itemDatabase.RemoveItem(0, this);
        }
    }
}
