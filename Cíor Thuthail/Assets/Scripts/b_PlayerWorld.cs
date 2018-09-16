﻿using System.Collections;
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
}
