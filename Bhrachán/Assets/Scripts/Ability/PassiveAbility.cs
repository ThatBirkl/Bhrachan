using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Type = TypeEnums;

public abstract class PassiveAbility : Ability
{
    protected Type.AbilityWhenToCall whenToCall;
    protected int timeIntervalSec;

    protected PassiveAbility()
    {
        ap = Type.ActivePassive.passive;
        radius = 0;
    }

    public Type.AbilityWhenToCall WhenToCall
    {
        get { return whenToCall; }
    }

    public int TimeInterval
    {
        get { return timeIntervalSec; }
    }
}
