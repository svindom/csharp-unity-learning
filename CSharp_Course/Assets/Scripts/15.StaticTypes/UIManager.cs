using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI activeEnemyText;

    public void UpdateEnemyCount()
    {
        activeEnemyText.text = "Active Enemies: " + SpawnManagerStaticLesson.enemyCount;
    }
}
