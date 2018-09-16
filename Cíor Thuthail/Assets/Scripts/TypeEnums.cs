using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeEnums
{
    public enum WeaponType
    {
        //added values so it's in synv with db
        sword = 1,
        shield = 2,
        staff = 3,
        bow = 4,
        mageStaff = 5,
        axe = 6
    }

    public enum TraitName
    {

    }

    public enum SkillName
    {
        //-- KNOWLEDGE
        //-- PHYSICAL
        //- COMBAT
        //- NON COMBAT
        //-- MAGIC
    }

    public enum Tier
    {
        common = 0,
        uncommon = 1,
        rare = 2,
        ultraRare = 3,
        epic = 4
    }

    public enum ActivePassive
    {
        active,
        passive
    }
}
