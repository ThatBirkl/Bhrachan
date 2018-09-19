using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facing = Meta.World.Movement.Facing;

public class b_ActorWorldBase : b_WorldObject
{
    protected Vector3 targetPosition;
    protected float speed;
    Facing facing;
    Collider2D collider;
    protected bool collided;

	protected override void Start ()
    {
        base.Start();
        targetPosition = gameObject.transform.position;
        collider = gameObject.GetComponent<Collider2D>();
        //Maybe read this from some property from the character or the mob or whatever
        speed = Meta.World.Movement.SPEED;
        facing = Facing.up;
    }

    protected override void Update()
    {
        base.Update();
    }

	void FixedUpdate ()
    {
        Debug.DrawLine(transform.position, targetPosition);
        Move();
	}

    //-----------------------------------------------------------//
    protected void SetHorizontalMovement(float amount)
    {
        //Set vertical target back to current so diagonal movement is not possible
        float x = targetPosition.x;
        if (gameObject.transform.position.x + amount > gameObject.transform.position.x)
        {
            x = Mathf.Ceil(gameObject.transform.position.x + amount);
        }
        else if (gameObject.transform.position.x + amount < gameObject.transform.position.x)
        {
            x = Mathf.Floor(gameObject.transform.position.x + amount);
        }

        targetPosition = new Vector3(
            x,
            gameObject.transform.position.y,
            targetPosition.z
            );
    }

    protected void SetVerticalMovement(float amount)
    {
        float y = targetPosition.y;
        if (gameObject.transform.position.y + amount > gameObject.transform.position.y)
        {
            y = Mathf.Ceil(gameObject.transform.position.y + amount);
        }
        else if (gameObject.transform.position.y + amount < gameObject.transform.position.y)
        {
            y = Mathf.Floor(gameObject.transform.position.y + amount);
        }
        //Set horizontal target back to current so diagonal movement is not possible
        targetPosition = new Vector3(
            gameObject.transform.position.x,
            y,
            targetPosition.z
            );
    }

    void Move()
    {
        ////TODO check collision
        if (targetPosition == transform.position && collided)
        {
            //targetPosition = transform.position;
            collided = false;
        }
        //prevPosition = transform.position;

        float step = speed * Time.deltaTime;
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPosition, step);

        Rotate();
    }

    void Rotate()
    {
        if (collided)
            return;

        if (targetPosition.x > transform.position.x) //man bewegt sich nach rechts
        {
            if (facing != Facing.right)
            {
                facing = Facing.right;
                transform.SetPositionAndRotation(transform.position,
                    Quaternion.Euler(0, 0, -90));
            }
        }
        if (targetPosition.x < transform.position.x) //man bewegt sich nach links
        {
            if (facing != Facing.left)
            {
                facing = Facing.left;
                transform.SetPositionAndRotation(transform.position,
                    Quaternion.Euler(0, 0, 90));
            }
        }
        if (targetPosition.y > transform.position.y) //man bewegt sich nach oben
        {
            if (facing != Facing.up)
            {
                facing = Facing.up;
                transform.SetPositionAndRotation(transform.position,
                    Quaternion.Euler(0, 0, 0));
            }
        }
        if (targetPosition.y < transform.position.y) //man bewegt sich nach unten
        {
            if (facing != Facing.down)
            {
                facing = Facing.down;
                transform.SetPositionAndRotation(transform.position,
                    Quaternion.Euler(0, 0, 180));
            }
        }
    }

    /*
     * Rounds the targetPosition to the next full grid position.
     * Mainly used for player input but I haven't thought about other actors
     * so it might be useful in here, too
     */
    protected void StopMoving()
    {
        float x = targetPosition.x;
        float y = targetPosition.y;
        float z = targetPosition.z;
    
        if (gameObject.transform.position.x < targetPosition.x)
        {
            x = Mathf.Ceil(gameObject.transform.position.x);
        }
        else if(gameObject.transform.position.x > targetPosition.x)
        {
            x = Mathf.Floor(gameObject.transform.position.x);
        }
        
        if (gameObject.transform.position.y < targetPosition.y)
        {
            y = Mathf.Ceil(gameObject.transform.position.y);
        }
        else if(gameObject.transform.position.y > targetPosition.y)
        {
            y = Mathf.Floor(gameObject.transform.position.y);
        }

        if (gameObject.transform.position.z < targetPosition.z)
        {
            z = Mathf.Ceil(gameObject.transform.position.z);
        }
        else if(gameObject.transform.position.z > targetPosition.z)
        {
            z = Mathf.Floor(gameObject.transform.position.z);
        }

        targetPosition = new Vector3(x, y, z);
    }

    /*
     * Rounds the targetPosition to the next full previous position.
     * Mainly used for player input but I haven't thought about other actors
     * so it might be useful in here, too
     */
    protected void StopMovingNegative()
    {
        float x = targetPosition.x;
        float y = targetPosition.y;
        float z = targetPosition.z;

        switch (facing)
        {
            case Facing.up:
                if (gameObject.transform.position.y < targetPosition.y)
                {
                    y = Mathf.Floor(gameObject.transform.position.y + 0.1f);
                }
                break;
            case Facing.down:
                if (gameObject.transform.position.y > targetPosition.y)
                {
                    y = Mathf.Ceil(gameObject.transform.position.y - 0.1f);
                }
                break;
            case Facing.right:
                if (gameObject.transform.position.x < targetPosition.x)
                {
                    x = Mathf.Floor(gameObject.transform.position.x + 0.1f);
                }
                break;
            case Facing.left:
                if (gameObject.transform.position.x > targetPosition.x)
                {
                    x = Mathf.Ceil(gameObject.transform.position.x - 0.1f);
                }
                break;
        }

        targetPosition = new Vector3(x, y, z);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (!collided)
        {
            StopMovingNegative();
            collided = true;
            //Physics2D.IgnoreCollision(collision.collider, col);
        }



        //TODO if collision with satirs get nextLvlZ
        //set targetPosition.z to nextLvlZ
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        //collided = false;
        //TODO if collision with satirs get nextLvlZ
        //set targetPosition.z to nextLvlZ
    }

    public Facing GetFacing()
    {
        return facing;
    }
}
