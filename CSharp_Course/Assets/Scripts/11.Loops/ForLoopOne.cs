using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopOne : MonoBehaviour
{
    public int apples = 0;
    void Start()
    {
        StartCoroutine(AddApplesRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AddApplesRoutine()
    {
        for (int i = 0; i < 100; i++)
        {
            apples++;
            yield return new WaitForSeconds(0.5f);
        }
        
    }
}
