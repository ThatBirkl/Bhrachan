using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Type = TypeEnums;

public abstract class Weapon : Item.Equipment
{
    protected Type.WeaponType weaponType;
    protected int damage;

    protected Ability abilityActive1;
    protected Ability abilityActive2;
    protected Ability abilityActive3;
    protected Ability abilityActive4;
    protected Ability abilityPassive1;
    protected Ability abilityPassive2;


    /*
     * @return The active abilities in sorted order
     */
    public ArrayList GetActiveAbilities()
    {
        ArrayList ret = new ArrayList();
        ret.Add(abilityActive1);
        ret.Add(abilityActive2);
        ret.Add(abilityActive3);
        ret.Add(abilityActive4);

        return ret;
    }

    /*
     * @return The passive abilities in sorted order
     */
    public ArrayList GetPassiveAbilities()
    {
        ArrayList ret = new ArrayList();
        ret.Add(abilityPassive1);
        ret.Add(abilityPassive2);

        return ret;
    }

    //---------- SUB CLASSES -----------------//

    public class Sword : Weapon
    {
        public Sword()
        {
            weaponType = Type.WeaponType.sword;
            itemType = Type.ItemType.weapon;
            tier = Type.Tier.common;
            damage = 0;
            weight = 0f; 
        }

        public Sword(Type.Tier _tier, int _damage, float _weight, Ability[] activeAbilities, Ability[] passiveAbilities)
        {
            weaponType = Type.WeaponType.sword;
            itemType = Type.ItemType.weapon;
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
            weaponType = Type.WeaponType.axe;
            itemType = Type.ItemType.weapon;
            tier = Type.Tier.common;
            damage = 0;
            weight = 0f;
        }

        public Axe(Type.Tier _tier, int _damage, float _weight, Ability[] activeAbilities, Ability[] passiveAbilities)
        {
            weaponType = Type.WeaponType.axe;
            itemType = Type.ItemType.weapon;
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
            weaponType = Type.WeaponType.staff;
            itemType = Type.ItemType.weapon;
            tier = Type.Tier.common;
            damage = 0;
            weight = 0f;
        }

        public Staff(Type.Tier _tier, int _damage, float _weight, Ability[] activeAbilities, Ability[] passiveAbilities)
        {
            weaponType = Type.WeaponType.staff;
            itemType = Type.ItemType.weapon;
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
            weaponType = Type.WeaponType.mageStaff;
            itemType = Type.ItemType.weapon;
            tier = Type.Tier.common;
            damage = 0;
            weight = 0f;
        }

        public MageStaff(Type.Tier _tier, int _damage, float _weight, Ability[] activeAbilities, Ability[] passiveAbilities)
        {
            weaponType = Type.WeaponType.mageStaff;
            itemType = Type.ItemType.weapon;
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
            weaponType = Type.WeaponType.shield;
            itemType = Type.ItemType.weapon;
            tier = Type.Tier.common;
            damage = 0;
            weight = 0f;
        }

        public Shield(Type.Tier _tier, int _damage, float _weight, Ability[] activeAbilities, Ability[] passiveAbilities)
        {
            weaponType = Type.WeaponType.shield;
            itemType = Type.ItemType.weapon;
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
            weaponType = Type.WeaponType.bow;
            itemType = Type.ItemType.weapon;
            tier = Type.Tier.common;
            damage = 0;
            weight = 0f;
        }

        public Bow(Type.Tier _tier, int _damage, float _weight, Ability[] activeAbilities, Ability[] passiveAbilities)
        {
            weaponType = Type.WeaponType.bow;
            itemType = Type.ItemType.weapon;
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
