using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIEnums : MonoBehaviour
{
    public enum EnemyState
    {
        Patroling,
        Attacking,
        Chasing,
        Death
    }

    public EnemyState currentState;


    void Start()
    {
        currentState = EnemyState.Patroling;
    }


    void Update()
    {
        SwitchEnemyBehavior(currentState);
        AttackPlayerWithEnemy();
    }



    public void SwitchEnemyBehavior(EnemyState enemyState)
    {
        switch (enemyState)
        {
            case EnemyState.Patroling:
                Debug.Log("Patroling");
                if(Time.time > 5)
                {
                    currentState = EnemyState.Chasing;
                }
                break;
            case EnemyState.Attacking:
                Debug.Log("Attacking");
                break;
            case EnemyState.Chasing:
                Debug.Log("Chasing");
                break;
            case EnemyState.Death:
                Debug.Log("Death");
                break;
        }
    }

    public void AttackPlayerWithEnemy()
    {   
        if(Input.GetKeyDown(KeyCode.Space))
        {
            currentState = EnemyState.Attacking;
            SwitchEnemyBehavior(currentState);
        }
    }
}
