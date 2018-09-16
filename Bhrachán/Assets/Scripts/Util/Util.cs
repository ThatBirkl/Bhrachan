using System.Collections;
using System.Collections.Generic;
using SkillName = TypeEnums.SkillName;
using PrimarySkill = TypeEnums.PrimarySkill;
using SecondarySkill = TypeEnums.SecondarySkill;

public class Util
{
    public static SkillName MapPrimarySkillToSkillname(PrimarySkill skill)
    {
        switch (skill)
        {
            case PrimarySkill.agility:
                return SkillName.agility;
            case PrimarySkill.intelligence:
                return SkillName.intelligence;
            case PrimarySkill.magicProwess:
                return SkillName.magicProwess;
            case PrimarySkill.strength:
                return SkillName.strength;
        }

        return 0;
    }

    public static SkillName MapSecondarySkillToSkillname(SecondarySkill skill)
    {
        switch (skill)
        {
            case SecondarySkill.axe:
                return SkillName.axe;
            case SecondarySkill.bow:
                return SkillName.bow;
            case SecondarySkill.fauna:
                return SkillName.fauna;
            case SecondarySkill.flora:
                return SkillName.flora;
            case SecondarySkill.instantaniousMagic:
                return SkillName.instantaniousMagic;
            case SecondarySkill.legends:
                return SkillName.legends;
            case SecondarySkill.manipulation:
                return SkillName.manipulation;
            case SecondarySkill.materialization:
                return SkillName.materialization;
            case SecondarySkill.medical:
                return SkillName.medical;
            case SecondarySkill.people:
                return SkillName.people;
            case SecondarySkill.restoration:
                return SkillName.restoration;
            case SecondarySkill.ritualMagic:
                return SkillName.ritualMagic;
            case SecondarySkill.shield:
                return SkillName.shield;
            case SecondarySkill.staff:
                return SkillName.staff;
            case SecondarySkill.sword:
                return SkillName.sword;
        }

        return 0;
    }

    public static PrimarySkill MapSkillnameToPrimarySkill(SkillName skill)
    {
        switch (skill)
        {
            case SkillName.agility:
                return PrimarySkill.agility;
            case SkillName.intelligence:
                return PrimarySkill.intelligence;
            case SkillName.magicProwess:
                return PrimarySkill.magicProwess;
            case SkillName.strength:
                return PrimarySkill.strength;
        }

        return 0;
    }

    public static SecondarySkill MapSkillnameToSecondarySkill(SkillName skill)
    {
        switch (skill)
        {
            case SkillName.axe:
                return SecondarySkill.axe;
            case SkillName.bow:
                return SecondarySkill.bow;
            case SkillName.fauna:
                return SecondarySkill.fauna;
            case SkillName.flora:
                return SecondarySkill.flora;
            case SkillName.instantaniousMagic:
                return SecondarySkill.instantaniousMagic;
            case SkillName.legends:
                return SecondarySkill.legends;
            case SkillName.manipulation:
                return SecondarySkill.manipulation;
            case SkillName.materialization:
                return SecondarySkill.materialization;
            case SkillName.medical:
                return SecondarySkill.medical;
            case SkillName.people:
                return SecondarySkill.people;
            case SkillName.restoration:
                return SecondarySkill.restoration;
            case SkillName.ritualMagic:
                return SecondarySkill.ritualMagic;
            case SkillName.shield:
                return SecondarySkill.shield;
            case SkillName.staff:
                return SecondarySkill.staff;
            case SkillName.sword:
                return SecondarySkill.sword;
        }

        return 0;
    }
}
