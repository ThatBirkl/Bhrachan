using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_ActorCombat : b_WorldObject
{
    bool active;
    b_Character character;

    int secondsToWait;

    // Use this for initialization
    protected override void Start()
    {
        base.Start();
        active = false;
	}
	
	// Update is called once per frame
	protected override void Update ()
    {
        if (!active)
            return;


        base.Update();
	}

    //-------------------------------------------
    public virtual void SwitchToCombat(b_Character _character)
    {
        //saftey measure
        if (active)
            return;

        character = _character;
    }

    public virtual void SwitchToWorld()
    {
        //safety measure
        if (!active)
            return;

        active = false;
        GetComponent<b_ActorWorldBase>().SwitchToWorld(character);
    }

    public virtual void MakeTurn()
    {
        //other stuff
        CombatManager.AddActor(this, secondsToWait);
        CombatManager.NextTurn();
    }

    //------------------ GETTERS ---------------

    public int SecondsToWait
    {
        get { return secondsToWait; }
    }
}
