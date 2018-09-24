using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    static List<b_ActorCombat> actors;

	// Use this for initialization
	void Start ()
    {
        actors = new List<b_ActorCombat>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public static void AddActor(b_ActorCombat _actor, int _sec)
    {
        bool added = false;

        if (actors.Count == 0)
        {
            actors.Add(_actor);
        }
        else
        {
            foreach (b_ActorCombat a in actors)
            {
                if (a.SecondsToWait > _sec)
                {
                    if (actors.IndexOf(a) == 0)
                    {
                        actors.Insert(0, _actor);
                    }
                    else
                    {
                        actors.Insert(actors.IndexOf(a) - 1, _actor);
                    }
                    added = true;
                    break;
                }
            }

            if (!added)
            {
                actors.Add(_actor);
            }
        }
    }

    public static void NextTurn()
    {
        actors[0].MakeTurn();

        actors.RemoveAt(0);
    }

    public static void EndCombat()
    {
        actors = null;
    }
}
