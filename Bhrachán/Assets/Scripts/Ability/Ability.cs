using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Type = TypeEnums;

public abstract class Ability
{
    protected string abilityId;
    protected Type.ActivePassive ap;
    protected Type.AbilityType type;
    protected string name;
    protected int healthBalance; //mostly needed for damage or healing abilities
    protected int radius; //radius around the caster in which the ability can be used | 0 means only the caster
    protected int aoe; //area of effect around the target of the ability
    protected int damageReduction; //for parry abilities or passives with damage reducing properties
    protected Type.PrimarySkill primarySkill;
    protected Type.SecondarySkill secondarySkill;
    protected Type.Tier tier;
    protected string desc;


    public Ability() { }

    public virtual void Execute(b_Character caster, b_Character[] targets)
    {
        //code for executing ability resides in here
        //different for every ability
    }

    public string Id
    {
        get { return abilityId; }
    }

    public Type.ActivePassive ActivePassive
    {
        get { return ap; }
    }

    public Type.AbilityType AbilityType
    {
        get { return type; }
    }

    public string Name
    {
        get { return name; }
    }

    public int HealthBalance
    {
        get { return healthBalance; }
    }

    public int Radius
    {
        get { return radius; }
    }

    public int AOE
    {
        get { return aoe; }
    }

    public float DamageReduction
    {
        get { return damageReduction; }
    }

    public Type.PrimarySkill PrimarySkill
    {
        get { return primarySkill; }
    }

    public Type.SecondarySkill SecondarySkill
    {
        get { return secondarySkill; }
    }

    public Type.Tier Tier
    {
        get { return tier; }
    }

    public string Descrpition
    {
        get { return desc; }
    }
}
