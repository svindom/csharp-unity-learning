using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerLists : MonoBehaviour
{
    // Lists declaration
    public List<string> names = new List<string> { "Alica", "Kuzya", "Vasya", "Markiza"};

    void Start()
    {
        PrintNames(names);
        
    }

    void Update()
    {
        RemoveName();
    }

    private void PrintNames(List<string> names)
    {
        foreach (string name in names) 
        {
            Debug.Log($"Here is a list of the names: {name}");
        }
    }

    private void RemoveRandomName(List<string> names)
    {
        string nameFromList = names[Random.Range(0, names.Count)];
        if (names.Count > 0)
        {
            names.Remove(nameFromList);
        }
        Debug.Log($"{nameFromList} went to sleep after a lunch");
    }
    private void RemoveName()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (names.Count > 0)
            {
                RemoveRandomName(names);
                string remainingName = string.Join(", ", names);
                if (names.Count > 0) 
                {
                    Debug.Log($"There is a list of pets who still eating: {remainingName}");
                }
            }
            else
            {
                Debug.Log("All pets went to sleep");
            }
        }
    }
}
