namespace TypeEnums
{
    public enum ItemType
    {
        weapon = 0,
        armor = 1,
        ressource = 2,
        consumable = 3
    }

    public enum WeaponType
    {
        //added values so it's in sync with db
        sword = 1,
        shield = 2,
        staff = 3,
        bow = 4,
        mageStaff = 5,
        axe = 6
    }

    public enum AbilityType
    {
        //added values so it's in sync with db
        spell = 0,
        sword = 1,
        shield = 2,
        staff = 3,
        bow = 4,
        mageStaff = 5,
        axe = 6
    }

    public enum ArmorType
    {

    }

    public enum TraitName
    {

    }

    public enum SkillName
    {
        // PRIMARY
        intelligence = 0,
        agility = 1,
        strength = 2,
        magicProwess = 3,
        //- missing skill
        //KNOWLEDGE
        people = 5,
        medical = 6,
        flora = 7,
        fauna = 8,
        legends = 9,
        //PHYSICAL COMBAT
        bow = 10,
        sword = 11,
        axe = 12,
        shield = 13,
        staff = 14,
        //PHYSICAL NON COMBAT
        //MAGIC
        manipulation = 20,
        restoration = 21,
        materialization = 22,
        ritualMagic = 23,
        instantaniousMagic = 24

    }

    public enum PrimarySkill
    {
        intelligence = 0,
        agility = 1,
        strength = 2,
        magicProwess = 3
    }

    public enum SecondarySkill
    {
        //KNOWLEDGE
        people = 0,
        medical = 1,
        flora = 2,
        fauna = 3,
        legends = 4,
        //PHYSICAL COMBAT
        bow = 5,
        sword = 6,
        axe = 7,
        shield = 8,
        staff = 9,
        //PHYSICAL NON COMBAT
        //MAGIC
        manipulation = 10,
        restoration = 11,
        materialization = 12,
        ritualMagic = 13,
        instantaniousMagic = 14
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
        active = 0,
        passive = 1
    }

    //public enum AbilityDisplayCondition
    //{
    //    always = 0,
    //    noWeapon = 1,
    //    noClothes = 2
    //}

    public enum AbilityWhenToCall
    {

    }

    public enum Ability
    {
        Parry = 0,
        Strike = 1
    }
}
