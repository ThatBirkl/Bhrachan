using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_InteractibleWorld : MonoBehaviour
{
    bool inRange; //if in range and clicked on, counts as interaction
    GameObject player;

	void Start ()
    {
		
	}

	void Update ()
    {
		
	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (inRange && WorldHelper.CloseEnoughToInteract(player, gameObject))
                Interact(player);
        }
    }

    public virtual void Interact(GameObject interactor)
    {
        Destroy(gameObject);
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
