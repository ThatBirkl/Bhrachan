using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Readable : b_InteractibleWorld
{
    private string content;

    public override void Interact(GameObject interactor)
    {
        DisplayText();
    }

    protected virtual void DisplayText()
    {

    }
}
