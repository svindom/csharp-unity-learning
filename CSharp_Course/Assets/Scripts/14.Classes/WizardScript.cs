using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardScript : MonoBehaviour
{

    public SpellScript[] spells;

    public int level = 1;
    public int exp;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            foreach (SpellScript spell in spells) 
            {
                if (level == spell.levelRequired)
                {
                    spell.ToCast();
                    exp += spell.expGained;
                }
            }
        }
    }
}
