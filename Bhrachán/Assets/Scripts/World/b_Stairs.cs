using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_Stairs : b_WorldObject
{
    [SerializeField]
    int nextLvl;

    bool active;

    protected override void Update()
    {
        HandleVisibilityAndCollision();
        CheckActive();
    }


    public int GetNextLevel()
    {
        if (active)
            return nextLvl;
        else
            return Mathf.FloorToInt(player.gameObject.transform.position.z);
    }

    private void CheckActive()
    {
        if (!_col_)
        {
            //always active
            //only set to inactive once the player is on a different level
            if (active)
                active = false;
        }
        else
        {
            //remains active all the time
            //if inactive it is only activeated once the player steps off it
            if (player.transform.position != this.transform.position && !active)
                active = true;
        }
    }
}
