using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO make this class abstract
public class b_InteractibleWorld : b_WorldObject
{
    bool inRange; //if in range and clicked on, counts as interaction
    //GameObject player;

    public virtual void Interact(GameObject interactor)
    {
        Weapon item = b_WeaponGenerator.GenerateCompletlyRandomWeapon();
        interactor.GetComponent<b_PlayerWorld>().GetInventory().Add(item, 1);
        Destroy(gameObject);
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

    public virtual void SetPlayer(GameObject _player)
    {
        player = _player;
    }
}
