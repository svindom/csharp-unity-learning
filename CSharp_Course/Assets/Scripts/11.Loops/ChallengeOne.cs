using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeOne : MonoBehaviour
{
    
    void Start()
    {
        for(int i = 0; i <30; i++)
        {
            if (i < 10 )
            {
                
                Debug.Log($"Numbers are: {i}");
            }
            if (i > 9 && i < 21)
            {
                if(i % 2 == 0)
                {
                   
                    Debug.Log($"Even numbers are: {i}");
                }
            }
            else if (i > 20 && i < 31)
            {
                if (i % 2 != 0)
                {
                    Debug.Log($"Odd numbers are: {i}");
                }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
