using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facing = Meta.World.Movement.Facing;

public class b_PlayerWorld : b_ActorWorldBase
{
    ArrayList interactibles;
    b_Character character;
    b_WorldTickManager worldTickManager;

    protected override void Start ()
    {
        base.Start();
        interactibles = new ArrayList();
        player = gameObject;
        character = new b_Character();

        character.GetInventory().Add(Util.MakeRation());
        character.GetInventory().Add(Util.MakeRation());
        character.GetInventory().Add(Util.MakeRation());
        character.GetInventory().Add(Util.MakeRation());
        character.GetInventory().Add(Util.MakeRation());
        worldTickManager = GetComponent<b_WorldTickManager>();
        worldTickManager.Begin(character);
    }
	
	
	protected override void Update ()
    {
        HandleInput();

        base.Update();
	}

    //-----------------------------------------------------------------------------//

    void HandleInput()
    {
        if (Input.GetAxis("Interact") != 0)
        {
            foreach (GameObject o in interactibles)
            {
                if (WorldHelper.FacingInteractible(this, o))
                {
                    print("Handle input");
                    o.GetComponent<b_InteractibleWorld>().Interact(gameObject);
                    break;
                }
            }
        }

        if (collided)
            return;

        float hor = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        if (Mathf.Abs(hor) > Mathf.Abs(vert))
        {
            vert = 0;
        }
        else if (Mathf.Abs(vert) > Mathf.Abs(hor))
        {
            hor = 0;
        }
        
        if (hor == 0 && vert == 0)
        {
            StopMoving();
        }
        else
        {
            if (hor != 0 && (int)(transform.position.y * 10000)%10000 == 0)
            {
                SetHorizontalMovement(hor);
            }
            if (vert != 0 && (int)(transform.position.x * 10000) % 10000 == 0)
            {
                SetVerticalMovement(vert);
            }
            
        }
    }

    public b_Inventory GetInventory()
    {
        return character.GetInventory();
    }

    //------------ COLLISION AND WORLD INTERACITON ----------------------------//

    protected override void OnTriggerEnter2D(Collider2D col)
    {
        base.OnTriggerEnter2D(col);
        if (col.CompareTag("Interactible"))
        {
            col.GetComponent<b_InteractibleWorld>().SetInRange(true);
            //col.GetComponent<b_InteractibleWorld>().SetPlayer(gameObject);
            interactibles.Add(col.gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Interactible"))
        {
            col.GetComponent<b_InteractibleWorld>().SetInRange(false);
            interactibles.Remove(col.gameObject);
        }
    }
}
