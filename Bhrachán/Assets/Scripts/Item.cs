using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Type = TypeEnums;

public abstract class Item
{
    protected float weight;
    protected int value;
    protected Type.ItemType itemType;

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
    }

    public abstract class StackableItem : Item
    {

    }

    public class Ressource : StackableItem
    {
        protected Ressources.Ressources name;

        public Ressources.Ressources GetName()
        {
            return name;
        }
    }

    public class Consumable : StackableItem
    {
        protected Ressources.Consumables name;

        public Ressources.Consumables GetName()
        {
            return name;
        }
    }
}
