using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMoveArray : MonoBehaviour
{
    public Vector3[] positions;
    private int _randomIndex;

    void Start()
    {
        _randomIndex = GetRandom();
        Debug.Log($"Random idex {_randomIndex}");

        transform.position = GetPosition(_randomIndex);
    }

    void Update()
    {
        
    }

    int GetRandom()
    {
        return Random.Range(0, positions.Length);
    }

    Vector3 GetPosition(int index)
    {
        return positions[index];
    }
}
