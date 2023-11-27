using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeTwo : MonoBehaviour
{
    public int _speed = 0;
    void Start()
    {
        StartCoroutine(AddSpeed());
    }

    void Update()
    {
        
    }
    int RandomNumber()
    {
        int random = Random.Range(50, 121);
        return random;
    }
    IEnumerator AddSpeed() 
    {
        int maxSpeed = RandomNumber();
        while (_speed < maxSpeed)
        {
            _speed += 5;
            Debug.Log($"The speed is {_speed}, the max speed is {maxSpeed}");
            yield return new WaitForSeconds(0.5f);
        }
    }

}
