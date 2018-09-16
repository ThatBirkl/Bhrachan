using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Type = TypeEnums;

public abstract class Weapon
{
    Type.WeaponType type;
    Type.Tier tier;
    int damage;
    float weight;

    Ability abilityActive1;
    Ability abilityActive2;
    Ability abilityActive3;
    Ability abilityActive4;
    Ability abilityPassive1;
    Ability abilityPassive2;

    public class Sword : Weapon
    {
        public Sword()
        {
            type = Type.WeaponType.sword;
            tier = Type.Tier.common;
            damage = 0;
            weight = 0f;
        }

        public Sword(Type.Tier _tier, int _damage, float _weight, Ability[] activeAbilities, Ability[] passiveAbilities)
        {
            type = Type.WeaponType.sword;
            tier = _tier;
            damage = _damage;
            weight = _weight;
            abilityActive1 = activeAbilities[0];
            abilityActive2 = activeAbilities[1];
            abilityActive3 = activeAbilities[2];
            abilityActive4 = activeAbilities[3];
            abilityPassive1 = passiveAbilities[0];
            abilityPassive2 = passiveAbilities[1];
        }
    }

    public class Axe : Weapon
    {
        public Axe()
        {
            type = Type.WeaponType.axe;
            tier = Type.Tier.common;
            damage = 0;
            weight = 0f;
        }

        public Axe(Type.Tier _tier, int _damage, float _weight, Ability[] activeAbilities, Ability[] passiveAbilities)
        {
            type = Type.WeaponType.axe;
            tier = _tier;
            damage = _damage;
            weight = _weight;
            abilityActive1 = activeAbilities[0];
            abilityActive2 = activeAbilities[1];
            abilityActive3 = activeAbilities[2];
            abilityActive4 = activeAbilities[3];
            abilityPassive1 = passiveAbilities[0];
            abilityPassive2 = passiveAbilities[1];
        }
    }

    public class Staff : Weapon
    {
        public Staff()
        {
            type = Type.WeaponType.staff;
            tier = Type.Tier.common;
            damage = 0;
            weight = 0f;
        }

        public Staff(Type.Tier _tier, int _damage, float _weight, Ability[] activeAbilities, Ability[] passiveAbilities)
        {
            type = Type.WeaponType.staff;
            tier = _tier;
            damage = _damage;
            weight = _weight;
            abilityActive1 = activeAbilities[0];
            abilityActive2 = activeAbilities[1];
            abilityActive3 = activeAbilities[2];
            abilityActive4 = activeAbilities[3];
            abilityPassive1 = passiveAbilities[0];
            abilityPassive2 = passiveAbilities[1];
        }
    }

    public class MageStaff : Weapon
    {
        public MageStaff()
        {
            type = Type.WeaponType.mageStaff;
            tier = Type.Tier.common;
            damage = 0;
            weight = 0f;
        }

        public MageStaff(Type.Tier _tier, int _damage, float _weight, Ability[] activeAbilities, Ability[] passiveAbilities)
        {
            type = Type.WeaponType.mageStaff;
            tier = _tier;
            damage = _damage;
            weight = _weight;
            abilityActive1 = activeAbilities[0];
            abilityActive2 = activeAbilities[1];
            abilityActive3 = activeAbilities[2];
            abilityActive4 = activeAbilities[3];
            abilityPassive1 = passiveAbilities[0];
            abilityPassive2 = passiveAbilities[1];
        }
    }

    public class Shield : Weapon
    {
        public Shield()
        {
            type = Type.WeaponType.shield;
            tier = Type.Tier.common;
            damage = 0;
            weight = 0f;
        }

        public Shield(Type.Tier _tier, int _damage, float _weight, Ability[] activeAbilities, Ability[] passiveAbilities)
        {
            type = Type.WeaponType.shield;
            tier = _tier;
            damage = _damage;
            weight = _weight;
            abilityActive1 = activeAbilities[0];
            abilityActive2 = activeAbilities[1];
            abilityActive3 = activeAbilities[2];
            abilityActive4 = activeAbilities[3];
            abilityPassive1 = passiveAbilities[0];
            abilityPassive2 = passiveAbilities[1];
        }
    }

    public class Bow : Weapon
    {
        public Bow()
        {
            type = Type.WeaponType.bow;
            tier = Type.Tier.common;
            damage = 0;
            weight = 0f;
        }

        public Bow(Type.Tier _tier, int _damage, float _weight, Ability[] activeAbilities, Ability[] passiveAbilities)
        {
            type = Type.WeaponType.bow;
            tier = _tier;
            damage = _damage;
            weight = _weight;
            abilityActive1 = activeAbilities[0];
            abilityActive2 = activeAbilities[1];
            abilityActive3 = activeAbilities[2];
            abilityActive4 = activeAbilities[3];
            abilityPassive1 = passiveAbilities[0];
            abilityPassive2 = passiveAbilities[1];
        }
    }
}
