using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class MainDictionary : MonoBehaviour
{
    public Dictionary<int, PlayerDictionary> playerDictionary = new Dictionary<int, PlayerDictionary>();
    public int playerID;
    

    private void Start()
    {
        AddPlayerToDictionary(1, "Jimmy");
        AddPlayerToDictionary(200, "Kyle");
        AddPlayerToDictionary(9, "Johan");
    }

    private void Update()
    {
        PrintPlayerName(playerID);
    }

    
    //---------------------------------------------------------------------------------------------------------------------------------------------------------

    public void AddPlayerToDictionary(int playerID, string playerName)
    {
        if (playerID > 0)
        {
            PlayerDictionary newPlayer = new PlayerDictionary(playerID);
            newPlayer.name = playerName;
            playerDictionary.Add(playerID, newPlayer);
        }
        else
        {
            Debug.Log("Invalid ID. It should containe a positive number.");
        }
    }

    public void AddPlayerName(PlayerDictionary player, string playerName)
    {
        player.name = playerName;
    }


    public Dictionary<int, PlayerDictionary> CreateDictionaryOfPlayers(int playerID, PlayerDictionary player)
    {
        Dictionary<int, PlayerDictionary> playerDictionary = new Dictionary<int, PlayerDictionary>();
        playerDictionary.Add(playerID, player);
        return playerDictionary;

    }

    public void PrintPlayerName(int playerID)
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(playerDictionary.TryGetValue(playerID, out PlayerDictionary player))
            {
                Debug.Log($"Player name: {player.name}");
            }
            else 
            {
                Debug.Log($"No player found with ID: {playerID}");
            }
        }
    }
}
