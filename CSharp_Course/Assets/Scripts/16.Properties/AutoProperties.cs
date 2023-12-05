using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoProperties : MonoBehaviour
{
    public float Speed {get => 12.5f;}

    private string _starName = "Name";
    public string Name
    {
        get
        {
           return _starName;
        }
        set
        {
            _starName = value;  
        }
    }

    void Update()
    {       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Name = ReturnRandomName();
            Debug.Log($"The new name is {Name}\nThe speed is {Speed}");
        }
    }

    private string ReturnRandomName ()
    {
        List<string> names = new List<string> {"Luna", "Moon", "Star", "Galandriel", "Illuminate" };
        int index = UnityEngine.Random.Range(0, names.Count);
        return names[index];

    }
}
