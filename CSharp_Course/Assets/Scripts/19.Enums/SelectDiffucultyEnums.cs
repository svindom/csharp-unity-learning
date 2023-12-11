using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDiffucultyEnums : MonoBehaviour
{
    public enum LevelSelector
    {
        Easy,
        Normal,
        Hard,
        Expert
    }

    public LevelSelector currentLevel;

    private void Start()
    {
        SwitchLevel(currentLevel);
    }

    public void SwitchLevel(LevelSelector levelSelector)
    {
        switch (levelSelector) 
        {
            case LevelSelector.Easy:
                break;
            case LevelSelector.Normal:
                break; 
            case LevelSelector.Hard:
                break;
            case LevelSelector.Expert:
                break;
        }
    }

}
