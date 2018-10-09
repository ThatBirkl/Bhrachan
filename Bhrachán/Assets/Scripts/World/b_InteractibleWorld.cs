using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO make this class abstract
public class b_InteractibleWorld : b_WorldObject
{
    bool inRange; //if in range and clicked on, counts as interaction
    bool active;
    float reactivateSeconds;

    protected override void Start()
    {
        base.Start();
        active = true;
    }

    public virtual bool Interact(GameObject interactor)
    {
        if (!active)
            return false;

        active = false;
        return true;
    }


    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (inRange && WorldHelper.CloseEnoughToInteract(player, gameObject))
                Interact(player);
        }
    }

    public virtual void SetInRange(bool val)
    {
        inRange = val;
    }

    //public virtual void SetPlayer(GameObject _player)
    //{
    //    player = _player;
    //}

    protected IEnumerator Reactivate()
    {
        yield return new WaitForSeconds(reactivateSeconds);
        active = true;
    }
}
