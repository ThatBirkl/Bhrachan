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
        //if chance for hit... and so on...
        //=>
        //calculate reduced damage through the skill and the damageReduction stat
        return 0;
    }
    
    public virtual void ExecuteDamage(int attackDamage, b_Character damageReceiver)
    {
     //put all the damage calculation and who receives the damage in here
    }
    
    //------------ SUBCLASSES ----------------
    
    public class ProtectionMarker : BlockMarker
    {
        private b_Character protector;
        
        public ProtectionMarker(b_Character _protector, Type.SkillName _skill, int _reduction, float _chance, int _hits)
        {
              base.BlockMarker(_skill, _reduction, _chance, _hits);
              protector = _protector;
        }
    }
}
