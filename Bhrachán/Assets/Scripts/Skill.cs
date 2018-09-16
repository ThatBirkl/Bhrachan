using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Type = TypeEnums;

public abstract class Skill
{
    protected int currentLvl;
    protected float currentXp;
    protected float maxXp;
    Type.SkillName name;

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

    //-------------- SUB CLASSES -----------//

    public class PrimarySkill : Skill
    {
        public PrimarySkill(int curLvl, Type.PrimarySkill _name)
        {
            currentLvl = curLvl;
            currentXp = 0f;
            maxXp = CalculateNextXp(currentLvl);
            name = Util.MapPrimarySkillToSkillname(_name);
        }
    }

    public class SecondarySkill : Skill
    {
        public SecondarySkill(int curLvl, Type.SecondarySkill _name)
        {
            currentLvl = curLvl;
            currentXp = 0f;
            maxXp = CalculateNextXp(currentLvl);
            name = Util.MapSecondarySkillToSkillname(_name);
        }
    }
}
