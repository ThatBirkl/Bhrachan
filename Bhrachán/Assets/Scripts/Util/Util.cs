using System.Collections;
using System.Collections.Generic;
using SkillName = TypeEnums.SkillName;
using PrimarySkill = TypeEnums.PrimarySkill;
using SecondarySkill = TypeEnums.SecondarySkill;
using AbilityE = TypeEnums.Ability;
using ItemType = TypeEnums.ItemType;
using WeaponType = TypeEnums.WeaponType;
using AbilityType = TypeEnums.AbilityType;
using ArmorType = TypeEnums.ArmorType;
using TraitName = TypeEnums.TraitName;
using Tier = TypeEnums.Tier;
using AP = TypeEnums.ActivePassive;
using AbilityWhenToCall = TypeEnums.AbilityWhenToCall;

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

    public static string EnumToString(ItemType e)
    {
        switch (e)
        {
            case TypeEnums.ItemType.weapon:
                return "weapon";
            case TypeEnums.ItemType.armor:
                return "armor";
            case TypeEnums.ItemType.consumable:
                return "consumable";
            case TypeEnums.ItemType.ressource:
                return "ressource";
        }

        return "";
    }

    public static string EnumToString(WeaponType e)
    {
        switch (e)
        {
            case WeaponType.sword:
                return "sword";
            case WeaponType.shield:
                return "shield";
            case WeaponType.staff:
                return "staff";
            case WeaponType.bow:
                return "bow";
            case WeaponType.mageStaff:
                return "mageStaff";
            case WeaponType.axe:
                return "axe";
        }

        return "";
    }

    public static string EnumToString(AbilityType e)
    {
        switch (e)
        {
            case AbilityType.spell:
                return "spell";
            case AbilityType.sword:
                return "sword";
            case AbilityType.shield:
                return "shield";
            case AbilityType.staff:
                return "staff";
            case AbilityType.bow:
                return "bow";
            case AbilityType.mageStaff:
                return "mageStaff";
            case AbilityType.axe:
                return "axe";
            case AbilityType.character:
                return "character";
        }

        return "";
    }

    public static string EnumToString(ArmorType e)
    {
        switch (e)
        {

        }

        return "";
    }

    public static string EnumToString(TraitName e)
    {
        switch (e)
        {

        }

        return "";
    }

    public static string EnumToString(SkillName e)
    {
        switch (e)
        {
            case SkillName.intelligence:
                return "intelligence";
            case SkillName.agility:
                return "agility";
            case SkillName.strength:
                return "strength";
            case SkillName.magicProwess:
                return "magicProwess";
            case SkillName.people:
                return "peopl";
            case SkillName.medical:
                return "medical";
            case SkillName.flora:
                return "flora";
            case SkillName.fauna:
                return "fauna";
            case SkillName.legends:
                return "legend";
            case SkillName.bow:
                return "bow";
            case SkillName.sword:
                return "sword";
            case SkillName.axe:
                return "axe";
            case SkillName.shield:
                return "shield";
            case SkillName.staff:
                return "staff";
            case SkillName.manipulation:
                return "manipulation";
            case SkillName.restoration:
                return "restoration";
            case SkillName.materialization:
                return "materialization";
            case SkillName.ritualMagic:
                return "ritualMagic";
            case SkillName.instantaniousMagic:
                return "instantaniousMagic";
        }

        return "";
    }

    public static string EnumToString(PrimarySkill e)
    {
        return EnumToString(Util.MapPrimarySkillToSkillname(e));
    }

    public static string EnumToString(SecondarySkill e)
    {
        return EnumToString(Util.MapSecondarySkillToSkillname(e));
    }

    public static string EnumToString(Tier e)
    {
        switch (e)
        {
            case Tier.common:
                return "common";
            case Tier.uncommon:
                return "uncommon";
            case Tier.rare:
                return "rare";
            case Tier.ultraRare:
                return "ultraRare";
            case Tier.epic:
                return "epic";
        }

        return "";
    }

    public static string EnumToString(AP e)
    {
        switch (e)
        {
            case AP.active:
                return "active";
            case AP.passive:
                return "passive";
        }

        return "";
    }

    public static string EnumToString(AbilityWhenToCall e)
    {
        switch (e)
        {

        }

        return "";
    }

    //TODO implement the rest of these enum to string methods

    public static Ability MakeAbility(AbilityE ability)
    {
        switch (ability)
        {
            case AbilityE.Parry:
                return new Abilities.Parry();
            case AbilityE.Strike:
                return new Abilities.Strike();
        }

        return null;
    }

    public static Item.Consumable MakeRation()
    {
        return new Item.Consumable(Ressources.Consumables.ration, 1, 1);
    }
}
