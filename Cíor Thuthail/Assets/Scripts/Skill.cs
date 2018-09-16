using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Type = TypeEnums;

public class Skill
{
    int currentLvl;
    float currentXp;
    float maxXp;
    Type.SkillName name;

    public Skill(int curLvl, Type.SkillName _name)
    {
        currentLvl = curLvl;
        currentXp = 0f;
        maxXp = CalculateNextXp(currentLvl);
        name = _name;
    }

    private float CalculateNextXp(int curLvl)
    {
        return Mathf.Pow(curLvl, 2) * 100f;
    }

    public void AddXp(float amount)
    {
        if (currentXp + amount >= maxXp)
        {
            currentXp = currentXp + amount - maxXp;
            currentLvl++;
            maxXp = CalculateNextXp(currentLvl);
        }
        else
        {
            currentXp += amount;
        }
    }
}
