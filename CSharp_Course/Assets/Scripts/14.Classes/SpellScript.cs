using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpellScript
{
    public string name;
    public int levelRequired;
    public int itemIDRequired;
    public int expGained;

    public SpellScript (string name, int levelRequired, int itemIDRequired, int expGained)
    {
        this.name = name;
        this.levelRequired = levelRequired;
        this.itemIDRequired = itemIDRequired;
        this.expGained = expGained;
    }

    public void ToCast()
    {
        Debug.Log($"Casting: {this.name}");
    }
}
