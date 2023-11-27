using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysChallengeOne : MonoBehaviour
{
    public string[] kidsName;
    public int[] kidsAges;
    public string[] kidFavorCar;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            string result = DefineTheResult();
            Debug.Log(result);
        }
         
    }

    string DefineTheResult()
    {
        int randomName = Random.Range(0, kidsName.Length);
        int randomAge = Random.Range(0, kidsAges.Length);
        int randomCar = Random.Range(0, kidFavorCar.Length);

        return $"{kidsName[randomName]} is {kidsAges[randomAge]} years old and loves {kidFavorCar[randomCar]} car";
    }
}
