using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Type = TypeEnums;

public abstract class ActiveAbility : Ability
{
    protected int energyCost;
    protected int penaltySec;
    protected int maxNumTargets;

    protected ActiveAbility()
    {
        ap = Type.ActivePassive.active;
    }

    public virtual bool DisplayCondition()
    {
        return true;
    }

    public int EnergyCost
    {
        get { return energyCost; }
    }

    public int Penalty
    {
        get { return penaltySec; }
    }

    public int MaxNumTargets
    {
        get { return maxNumTargets; }
    }
}
