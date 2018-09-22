using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_WorldTickManager : MonoBehaviour
{
    b_Character character;
    float tickSeconds;
    bool tick;

    /*
     * Called in the Start() method of the controller class of the world actor
     */
    public void Begin(b_Character _character)
    {
        character = _character;
        tick = true;
        tickSeconds = Meta.World.Automation.TICK;
        StartCoroutine(Tick());
    }

    private IEnumerator Tick()
    {
        while (tick)
        {
            yield return new WaitForSeconds(tickSeconds);

            bool removed = character.RemoveRation(1);
            //could not remove any rations since there are none left
            if (!removed)
            {
                tick = false;
                character.Die();
            }  
        }       
    }

    public void SetTick(bool status)
    {
        tick = status;
    }
}
