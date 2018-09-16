using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facing = Meta.World.Movement.Facing;

public class WorldHelper : MonoBehaviour
{
    public static bool FacingInteractible(b_PlayerWorld player, GameObject interactible)
    {
        bool above = (player.GetFacing() == Facing.up &&
            interactible.transform.position.y > player.gameObject.transform.position.y &&
            (interactible.transform.position.x >= player.transform.position.x - 1 &&
            interactible.transform.position.x <= player.transform.position.x + 1));
        bool below = (player.GetFacing() == Facing.down &&
            interactible.transform.position.y < player.gameObject.transform.position.y &&
            (interactible.transform.position.x >= player.transform.position.x - 1 &&
            interactible.transform.position.x <= player.transform.position.x + 1));
        bool right = (player.GetFacing() == Facing.right &&
            interactible.transform.position.x > player.gameObject.transform.position.x &&
            (interactible.transform.position.y >= player.transform.position.y - 1 &&
            interactible.transform.position.y <= player.transform.position.y + 1));
        bool left = (player.GetFacing() == Facing.left &&
            interactible.transform.position.x < player.gameObject.transform.position.x &&
            (interactible.transform.position.y >= player.transform.position.y - 1 &&
            interactible.transform.position.y <= player.transform.position.y + 1));

        return (above || below || right ||left);
    }

    public static bool CloseEnoughToInteract(GameObject player, GameObject interactible)
    {
        bool lo = (player.transform.position.x >= interactible.transform.position.x + 2 &&
                player.transform.position.y <= interactible.transform.position.y - 2);
        bool ro = (player.transform.position.x <= interactible.transform.position.x - 2 &&
                player.transform.position.y <= interactible.transform.position.y - 2);
        bool lu = (player.transform.position.x >= interactible.transform.position.x + 2 &&
                player.transform.position.y >= interactible.transform.position.y + 2);
        bool ru = (player.transform.position.x <= interactible.transform.position.x - 2 &&
                player.transform.position.y >= interactible.transform.position.y + 2);

        return !(lo || ro || lu || ru);
    }
}
