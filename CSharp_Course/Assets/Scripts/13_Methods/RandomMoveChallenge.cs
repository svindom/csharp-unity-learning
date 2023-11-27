using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMoveChallenge : MonoBehaviour
{
    public GameObject Cube;
    void Start()
    {
        if (Cube == null)
        {
            Cube = GameObject.Find("RandomMove");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeCubePositionRandom();
            ChangeColorRandom();
        }
    }

    public void ChangeCubePositionRandom()
    {
        Cube.transform.position = new Vector3(Random.Range(-4f, 4f), Random.Range(-4f, 4f), Random.Range(-4f, 4f));
    }
    public void ChangeColorRandom()
    {
        Cube.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
