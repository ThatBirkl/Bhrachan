using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Type = TypeEnums;

public class CharacterTrait
{


    int currentLvl;
    float currentXp;
    float maxXp;
    Type.TraitName name;

    public CharacterTrait(int curLvl, Type.TraitName _name)
    {
        currentLvl = curLvl;
        currentXp = 0f;
        maxXp = CalculateNextXp(currentLvl);
        name = _name;
    }

    private float CalculateNextXp(int curLvl)
    {
        return Mathf.Pow(Mathf.Abs(curLvl), 2) * 100f;
    }

    /** 
     * Can also be negative
     * Character traits can lvlUp or lvl down
    */
    public void AddXp(float amount)
    {
        if (currentXp + amount >= maxXp)
        {
            currentXp = currentXp + amount - maxXp;
            currentLvl++;
            maxXp = CalculateNextXp(currentLvl);
        }
        if (currentXp + amount <= 0)
        {
            currentLvl--;
            maxXp = CalculateNextXp(currentLvl);
            currentXp = maxXp + (currentXp + amount);
        }
        else
        {
            currentXp += amount;
        }
    }
}
