using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_Camera : MonoBehaviour
{
    [SerializeField]
    protected Canvas ui;

    public b_UI UI
    {
        get{ return ui.GetComponent<b_UI>(); }
    }
}
