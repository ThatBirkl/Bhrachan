using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Movement = Meta.World.Movement;

public class b_CameraDungeon : MonoBehaviour
{
    [SerializeField]
    b_PlayerWorld player;

    void Start()
    {
        GetComponent<Camera>().orthographicSize = Meta.World.Movement.CAMERA_ORTHIGRAPHIC_SIZE;
    }

	void Update ()
    {
        Vector3 target = player.gameObject.transform.position;

        target.z = target.z + Movement.CAMERA_DISTANCE;
    
        float step = Time.deltaTime * Movement.CAMERA_SPEED;

        gameObject.transform.position = Vector3.MoveTowards(transform.position,
            target, step);
	}
}
