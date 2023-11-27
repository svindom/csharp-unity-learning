using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnArray : MonoBehaviour
{
    public GameObject[] Players;

    void Start()
    {
        Players = GetAllPlayers();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Players = GetAllPlayers();
        }
    }

    GameObject[] GetAllPlayers()
    {
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");

        foreach (var player in allPlayers)
        {
            player.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }

        return allPlayers;
    }
}
