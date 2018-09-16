using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Type = TypeEnums;
using DAMAGE = Meta.Weapon.Damage;

public class b_WeaponGenerator : MonoBehaviour
{
    public static Weapon GenerateCompletlyRandomWeapon()
    {
        Type.WeaponType type = (Type.WeaponType)Random.Range(0, 4);

        switch (type)
        {
            case Type.WeaponType.sword:
                return GenerateRandomSword();
            default:
                return GenerateRandomSword();
        }
    }

    //--------------------------------SWORD-------------------------------//
    public static Weapon.Sword GenerateRandomSword()
    {
        Type.Tier tier = (Type.Tier)Random.Range(0, 4);

        return GenerateSword(tier);
    }

    public static Weapon.Sword GenerateSword(Type.Tier _tier)
    {
        int damage = 0;

        switch (_tier)
        {
            case Type.Tier.common:
                damage = Random.Range(DAMAGE.COMMON_MIN, DAMAGE.COMMON_MAX);
                break;
            case Type.Tier.uncommon:
                damage = Random.Range(DAMAGE.UNCOMMON_MIN, DAMAGE.UNCOMMON_MAX);
                break;
            case Type.Tier.rare:
                damage = Random.Range(DAMAGE.RARE_MIN, DAMAGE.RARE_MAX);
                break;
            case Type.Tier.ultraRare:
                damage = Random.Range(DAMAGE.ULTRARARE_MIN, DAMAGE.ULTRARARE_MAX);
                break;
            case Type.Tier.epic:
                damage = Random.Range(DAMAGE.EPIC_MIN, DAMAGE.EPIC_MAX);
                break;
        }
        float weight = Random.Range(0f, 20f);

        return GenerateSword(_tier, damage, weight);
    }

    public static Weapon.Sword GenerateSword(Type.Tier _tier, int _damage, float _weight)
    {
        Ability[] abilitiesActive = new Ability[4];
        Ability[] abilitiesPassive = new Ability[2];
        string sqlStr = "select * from SYS_ABILITY where TYPE = " 
            + ((int)Type.WeaponType.sword) 
            + " and ACTIVE_PASSIVE = " 
            + ((int)Type.ActivePassive.active)
            + " and TIER <= "
            + ((int)_tier);
        DataTable res = DB.Select(sqlStr);

        for (int i = 0; i < abilitiesActive.Length; i++)
        {

        }

        for (int i = 0; i < abilitiesPassive.Length; i++)
        {

        }

        return new Weapon.Sword(_tier, _damage, _weight, abilitiesActive, abilitiesPassive);
    }
}
