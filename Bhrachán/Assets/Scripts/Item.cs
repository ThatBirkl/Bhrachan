using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Type = TypeEnums;

public abstract class Item
{
    protected float weight;
    protected int value;
    protected Type.ItemType itemType;


    public Item(float _weight, int _value)
    {
        weight = _weight;
        value = _value;
    }

    public float GetWeight()
    {
        return weight;
    }

    public float GetValue()
    {
        return value;
    }

    public Type.ItemType GetItemType()
    {
        return itemType;
    }

    //-------------------- SUB CLASSES -----------------//

    public abstract class Equipment : Item
    {
        public Type.Tier tier;

        public Equipment(float _weight, int _value) : base (_weight, _value)
        {
            
        }
    }

    public abstract class StackableItem : Item
    {
        public StackableItem(float _weight, int _value) : base(_weight, _value)
        {

        }
    }

    public class Ressource : StackableItem
    {
        protected Ressources.Ressources name;

        public Ressource(Ressources.Ressources _name, float _weight, int _value) : base(_weight, _value)
        {
            itemType = Type.ItemType.ressource;
            name = _name;
        }

        public Ressources.Ressources GetName()
        {
            return name;
        }
    }

    public class Consumable : StackableItem
    {
        protected Ressources.Consumables name;

        public Consumable(Ressources.Consumables _name, float _weight, int _value) : base(_weight, _value)
        {
            itemType = Type.ItemType.consumable;
            name = _name;
        }

        public Ressources.Consumables GetName()
        {
            return name;
        }
    }
}
