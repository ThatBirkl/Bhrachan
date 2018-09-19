using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : b_InteractibleWorld
{
    Dictionary<Item, int> contents;

	void Start ()
    {
        contents = new Dictionary<Item, int>();
    }

    private void GenerateContents()
    {
        //TODO
    }

    //----------- GETTERS -------------
    public Dictionary<Item, int> Contents
    {
        get { return contents; }
    }
}
