using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Readable : b_InteractibleWorld
{
    protected string content;
    protected string title;
    protected bool multiplePages;

    public override bool Interact(GameObject interactor)
    {
        if(base.Interact(interactor))
            DisplayText();

        return true;
    }

    protected virtual void DisplayText()
    {
        if (!multiplePages)
            Camera.main.GetComponent<b_CameraDungeon>().UI.DisplaySimpleText(title, content);
        else
            Camera.main.GetComponent<b_CameraDungeon>().UI.DisplayMultiplePageText(title, content);
    }
}
