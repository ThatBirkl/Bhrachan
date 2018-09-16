using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Type = TypeEnums;

public class b_Inventory
{
    Dictionary<Item, int> inventory; //Item and amount
    string characterId; //owner of this inventory
    float capacity; //probably derived from player stat
    float weight;

    public b_Inventory(string id)
    {
        characterId = id;
        Load();
    }

    void Start ()
    {
        Load();	
	}

	void Update ()
    {
		
	}

    //-----------------------------------------------------------------------//

    /*
     * Loads all the inventory entries from the database;
     * Orderd by the sorting number in the db;
     * This sorting order is saved everytime the inventory is closed
     */
    void Load()
    {
        inventory = new Dictionary<Item, int>();

        //All itemtypes have to be in the same db table for this to work;
        //a lot of ressource columns will be null for weapons and vice versa
    }

    /*
     * Adds one or more items of a type to the inventory
     * 
     * @param item The item that should be added
     * @param amount The number of these items that should be added
     * 
     * @return Returns if the item was added or not
     */
    public bool Add(Item item, int amount)
    {
        if (weight + (item.GetWeight() * amount) > capacity)
        {
            return false;
        }

        if (item.GetItemType() == Type.ItemType.weapon
            || item.GetItemType() == Type.ItemType.armor)
        {
            inventory.Add(item, 1);
            weight += item.GetWeight();
        }
        else
        {
            bool added = false;
            if (item.GetItemType() == Type.ItemType.consumable)
            {
                Item.Consumable c = (Item.Consumable)item;
                
                foreach (var entry in inventory)
                {
                    try
                    {
                        Item.Consumable ic = (Item.Consumable)entry.Key;
                        if (ic.GetName() == c.GetName())
                        {
                            inventory[ic] = entry.Value + amount;
                            added = true;
                            return true;
                        }
                    }
                    catch (System.InvalidCastException e){}
                }  
            }
            else
            {
                Item.Ressource r = (Item.Ressource)item;

                foreach (var entry in inventory)
                {
                    try
                    {
                        Item.Ressource ir = (Item.Ressource)entry.Key;
                        if (ir.GetName() == r.GetName())
                        {
                            inventory[ir] = entry.Value + amount;
                            added = true;
                            return true;
                        }
                    }
                    catch (System.InvalidCastException e) { }
                }
            }

            if (!added)
            {
                inventory.Add(item, amount);
            }
        }

        return false;
    }

    /*
     * Adds one item of a type to the inventory
     * 
     * @param item The item that should be added
     * 
     * @return Returns if the item was added or not
     */
    public bool Add(Item item)
    {
        return Add(item, 1);
    }
}
