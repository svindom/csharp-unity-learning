using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerStaticLesson : MonoBehaviour
{
    public GameObject enemyPrefab;
    public static int enemyCount;


    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
    }

    public void SpawnEnemy()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(enemyPrefab);
        }
    }
}
