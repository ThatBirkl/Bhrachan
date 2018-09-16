using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facing = Meta.World.Movement.Facing;

public class b_PlayerWorld : b_ActorWorldBase
{	
	protected override void Start ()
    {
        base.Start();
	}
	
	
	protected override void Update ()
    {
        HandleInput();

        base.Update();
	}

    //-----------------------------------------------------------------------------//

    void HandleInput()
    {
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

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Interactible"))
        {
            if (Input.GetAxis("Interact") != 0)
            {
                if (WorldHelper.FacingInteractible(this, col.gameObject))
                {
                    col.gameObject.GetComponent<b_InteractibleWorld>().Interact(gameObject);
                }
            }  
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Interactible"))
        {
            col.GetComponent<b_InteractibleWorld>().SetInRange(true);
            col.GetComponent<b_InteractibleWorld>().SetPlayer(gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Interactible"))
        {
            col.GetComponent<b_InteractibleWorld>().SetInRange(false);
        }
    }
}
