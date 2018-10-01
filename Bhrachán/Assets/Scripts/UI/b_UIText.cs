using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_UIText : MonoBehaviour
{
	protected virtual void Update ()
    {
        Close();	
	}

    private void Close()
    {
        if (Input.GetAxis("Cancel") != 0)
        {
            Destroy(gameObject);
        }       
    }
}