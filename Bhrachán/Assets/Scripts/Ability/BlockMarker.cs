using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Type = TypeEnums;

public class BlockMarker : MonoBehaviour
{
    private Type.SkillName skill;
    private int damageReduction;
    private float chance;
    private int hits; //amount of hits this blocks

    public BlockMarker(Type.SkillName _skill, int _reduction, float _chance, int _hits)
    {
        skill = _skill;
        damageReduction = _reduction;
        chance = _chance;
        hits = _hits;
    }

    private int CalculateDamage(int attackDamage, b_Character damageReceiver)
    {
        //TODO
        //if chance for hit... and so on...
        //=>
        //calculate reduced damage through the skill and the damageReduction stat
        return 0;
    }
    
    public virtual void ExecuteDamage(int attackDamage, b_Character damageReceiver, b_Character attacker)
    {
        int damage = CalculateDamage(attackDamage, damageReceiver);
        damageReceiver.AddHealth(-damage);
    }

    //------------ GETTERS -------------------

    public int HitsLeft
    {
        get { return hits; }
    }
    
    //------------ SUBCLASSES ----------------
    
    public class ProtectionMarker : BlockMarker
    {
        private b_Character protector;

        public ProtectionMarker(b_Character _protector, Type.SkillName _skill, int _reduction, float _chance, int _hits) : base(_skill, _reduction, _chance, _hits)
        {
            protector = _protector; 
        }

        public override void ExecuteDamage(int attackDamage, b_Character damageReceiver, b_Character attacker)
        {
            int damage = CalculateDamage(attackDamage, protector);
            protector.AddHealth(-damage);
        }
    }

    public class ParryMarker : BlockMarker
    {
        Weapon weapon;
        public ParryMarker(Weapon _weapon, Type.SkillName _skill, int _reduction, float _chance, int _hits) : base(_skill, _reduction, _chance, _hits)
        {
            weapon = _weapon;
        }

        public override void ExecuteDamage(int attackDamage, b_Character damageReceiver, b_Character attacker)
        {
            int damage = CalculateDamage(attackDamage, damageReceiver);
            damageReceiver.AddHealth(-damage);
            damage = CalculateParry(weapon, attacker);
            attacker.AddHealth(-damage);
        }

        private int CalculateParry(Weapon _weapon, b_Character _attacker)
        {
            //TODO
            return 0;
        }
    }
}
