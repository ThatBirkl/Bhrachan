using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Type = TypeEnums;

public class b_Character : MonoBehaviour
{
    public struct HealthStr
    {
        public int current;
        public int max;
    }

    ArrayList protectionMarkers;
    b_Inventory inventory;


    //stats
    string id;
    Dictionary<Type.PrimarySkill, Skill.PrimarySkill> primarySkills;
    Dictionary<Type.SecondarySkill, Skill.SecondarySkill> secondarySkills;
    HealthStr health;
    //stats end


    void Start()
    {
        ArrayList protectionMarkers = new ArrayList();
    }

    public void AddProtectionMarker(ProtectionMarker marker)
    {
        protectionMarkers.Add(marker);
    }

    private void Die()
    {

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
