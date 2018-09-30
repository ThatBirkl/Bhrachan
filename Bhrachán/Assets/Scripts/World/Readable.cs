using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Readable : b_InteractibleWorld
{
    protected string content;
    protected string title;
    protected bool multiplePages;
    protected Font font;

    protected override void Start()
    {
        base.Start();
        Load();
    }

    public override bool Interact(GameObject interactor)
    {
        if(base.Interact(interactor))
            DisplayText();

        return true;
    }

    protected virtual void DisplayText()
    {
        if (!multiplePages)
            Camera.main.GetComponent<b_CameraDungeon>().UI.DisplaySimpleText(title, content, font);
        else
            Camera.main.GetComponent<b_CameraDungeon>().UI.DisplayMultiplePageText(title, content, font);
    }

    protected virtual void Load()
    {
        content = "This is a text to try something";
        title = "Test text";

        content = Util.Translate(content, TypeEnums.Language.Ancient);
        title = Util.Translate(title, TypeEnums.Language.Ancient);
        font = Language.AncientFont;
    }
}
