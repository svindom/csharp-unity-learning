using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStaticLearning : MonoBehaviour
{
    private UIManager _ui;
    public void OnEnable()
    {
        SpawnManagerStaticLesson.enemyCount++;
        _ui = GameObject.Find("UI Manager").GetComponent<UIManager>();
        _ui.UpdateEnemyCount();
        DestroyEnemy();
    }
    public void OnDisable()
    {
        SpawnManagerStaticLesson.enemyCount--;
        _ui.UpdateEnemyCount();
    }

    private void DestroyEnemy()
    {
        int timeRandom = Random.Range(2,6);
        Destroy(this.gameObject, timeRandom);
    }
}
