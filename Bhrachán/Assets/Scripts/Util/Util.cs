using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
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

    public static string Translate(string _text, TypeEnums.Language _language)
    {
        Dictionary<string, string> language;

        _text = _text.ToLower();

        switch (_language)
        {
            case TypeEnums.Language.Ancient:
                language = Language.Ancient;
                break;
            case TypeEnums.Language.Elven:
                language = Language.Elven;
                break;
            case TypeEnums.Language.Feline:
                language = Language.Feline;
                break;
            default:
                language = Language.Ancient;
                break;
        }

        foreach (KeyValuePair<string, string> e in language)
        {
            _text = _text.Replace(e.Key, e.Value);
        }

        return _text;
    }

    public static Font GetFont(TypeEnums.Language _language)
    {
        Font f = new Font();

        switch (_language)
        {
            case TypeEnums.Language.Ancient:
                f = Language.AncientFont;
                break;
            case TypeEnums.Language.Elven:
                
                break;
            case TypeEnums.Language.Feline:
                f = Language.FelineFont;
                break;
            default:
                f = Language.AncientFont;
                break;
        }

        return f;
    }

    public static string LoadText(string path)
    {
        return System.IO.File.ReadAllText(path);
    }

    public static ArrayList PageText(string _text, int _charCount)
    {
        ArrayList list = new ArrayList();

        string tempTxt = _text;
        while(tempTxt.Length > _charCount)
        {
            int spacePointer = 0;
            for(spacePointer = _charCount; spacePointer > 0; spacePointer--)
            {
                if (char.IsWhiteSpace(_text[spacePointer]))
                {
                    break;
                }
            }
            string tempTxtArr = tempTxt.Substring(0, spacePointer);

            list.Add(tempTxt.Substring(0, spacePointer));
            tempTxt = tempTxt.Substring(spacePointer);
        }

        list.Add(tempTxt);

        return list;
    }

    public static string UUID()
    {
        long dtl = System.DateTime.Now.ToBinary();
        dtl += Random.Range(int.MinValue, int.MaxValue);
        dtl = dtl ^ System.DateTime.Now.ToBinary();
        dtl = System.Math.Abs(dtl);
        return dtl.ToString();
    }

    /*
    * Returns true if the the two points are within a 3x3x3 cube of each other
    */
    public static bool NextToEachOther(Vector3 a, Vector3 b)
    {
        if((a.x >= b.x - 1 && a.x <= b.x + 1) && 
            (a.y >= b.y - 1 && a.y <= b.y + 1) &&
            (a.z >= b.z - 1 && a.z <= b.z + 1))
            return true;

        return false;
    }

    public static bool NextToEachOther(Vector2 a, Vector2 b)
    {
        return NextToEachOther(new Vector3(a.x, a.y, 0), new Vector3(b.x, b.y, 0));
    }

    /*
    * @return 0 if a is close; 1 if b is close; 2 if both have the same distance
    */
    public static int CloserTo(int _a, int _b, int _compare)
    {
        int distA = Mathf.Abs(_a - _compare);
        int distB = Mathf.Abs(_b - _compare);

        if(distA < distB)
        {
            return 0;
        }
        else if(distA > distB)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }

    public static float Distance(Vector3 a, Vector3 b)
    {
        Vector3 dist = b - a;

        return Mathf.Sqrt(Mathf.Pow(dist.x, 2) + Mathf.Pow(dist.y, 2) + Mathf.Pow(dist.z, 2));
    }

    public static float Distance(Vector2 a, Vector2 b)
    {
        return Distance(new Vector3(a.x, a.y, 0), new Vector3(b.x, b.y, 0));
    }
}
