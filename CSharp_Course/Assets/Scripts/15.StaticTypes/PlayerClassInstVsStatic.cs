using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1
{
    public int id;
    public string name;

    public static int connectionCount;

    public Player1()
    {
        connectionCount++;
    }
}

public class PlayerClassInstVsStatic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var player1 = new Player1();
        var player2 = new Player1();
        var player3 = new Player1();
        var player4 = new Player1();
        var player5 = new Player1();

        Debug.Log($"Connection count is: {Player1.connectionCount}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
