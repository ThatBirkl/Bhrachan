using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Type = TypeEnums;

public class b_Character //: MonoBehaviour
{
    public struct Stat
    {
        public int current;
        public int max;
    }

    ArrayList blockMarkers;
    b_Inventory inventory;


    //stats
    protected string id;
    protected Dictionary<Type.PrimarySkill, Skill.PrimarySkill> primarySkills;
    protected Dictionary<Type.SecondarySkill, Skill.SecondarySkill> secondarySkills;
    protected Dictionary<Type.TraitName, CharacterTrait> characterTraits;
    protected Stat health;
    protected Stat energy;
    protected string name;
    //stats end
    
    public b_Character()
    {
        inventory = new b_Inventory("");
    }


    void Start()
    {
        ArrayList protectionMarkers = new ArrayList();
    }

    public void AddBlockMarker(BlockMarker marker)
    {
        blockMarkers.Add(marker);
    }

    public void Die()
    {
        Debug.Log("is dead");
    }

    public void ReceiveHit(b_Character attacker, int damage)
    {
        //TODO Add activation of passive abilities with call on hit
        if (blockMarkers.Count > 0)
        {
            BlockMarker marker = ((BlockMarker)blockMarkers[0]);
            marker.ExecuteDamage(damage, this, attacker);
            if (marker.HitsLeft == 0)
            {
                blockMarkers.Remove(marker);
            }
        }
        else
        {
            AddHealth(-damage);
        }
    }

    public void AddHealth(int value)
    {
        health.current += value;

        if (health.current <= 0)
        {
            Die();
        }
        else if (health.current > health.max)
        {
            health.current = health.max;
        }
    }

    public void AddEnergy(int value)
    {
        energy.current += value;

        if (energy.current <= 0)
        {
            AddHealth(energy.current);
            energy.current = 0;
        }
        else if (energy.current > energy.max)
        {
            energy.current = energy.max;
        }
    }

    public bool RemoveRation(int amount)
    {
        return inventory.RemoveConsumable(Ressources.Consumables.ration, amount);
    }

    //----------------------- GETTERS || SETTERS -------------------------------//
    public int GetSkill(Type.PrimarySkill skill)
    {
        Skill.PrimarySkill s = primarySkills[skill];

        return s.GetLevel();
    }

    public int GetSkill(Type.SecondarySkill skill)
    {
        Skill.SecondarySkill s = secondarySkills[skill];

        return s.GetLevel();
    }

    public b_Inventory GetInventory()
    {
        return inventory;
    }

    public string Id
    {
        get { return id; }
    }

    public int Health
    {
        get { return health.current; }
    }
}
