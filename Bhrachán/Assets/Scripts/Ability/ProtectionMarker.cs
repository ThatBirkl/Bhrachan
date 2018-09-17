using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Type = TypeEnums;

public class ProtectionMarker : MonoBehaviour
{
    private Type.SkillName skill;
    private int damageReduction;
    private float chance;
    private int hits; //amount of hits this blocks

    public ProtectionMarker(Type.SkillName _skill, int _reduction, float _chance, int _hits)
    {
        skill = _skill;
        damageReduction = _reduction;
        chance = _chance;
        hits = _hits;
    }

    public int CalculateDamage(int attackDamage, b_Character damageReceiver)
    {
        //if chance for hit... and so on...
        //=>
        //calculate reduced damage through the skill and the damageReduction stat
        return 0;
    }
}
