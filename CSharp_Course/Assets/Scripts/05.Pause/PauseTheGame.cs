using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTheGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0f;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 1f;
        }
    }
}
