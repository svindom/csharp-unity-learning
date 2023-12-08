using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerListsTeacher : MonoBehaviour
{
    public List<string> names = new List<string>();


    void Start()
    {
        foreach (string name in names)
        {
            Debug.Log(name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        string nameToRemove = names[Random.Range(0, names.Count)];

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //names.RemoveAt(Random.Range(0, names.Count)); 

            // Or we can do this using another way like:
            // names.Remove(names[Random.Range(0, names.Count)]);

            // but we actually will use this version
            names.Remove(nameToRemove);

            foreach (string name in names)
            {
                Debug.Log(name);
            }
            Debug.Log($"The {nameToRemove} has been removed!");
        }
    }
}
