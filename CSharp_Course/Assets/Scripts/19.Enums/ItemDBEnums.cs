using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemDBEnums : MonoBehaviour
{
    public List<ItemEnums> itemDB = new List<ItemEnums>();

    private void Start()
    {
        itemDB[0].Acting();
    }
}

