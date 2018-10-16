using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Readable : b_InteractibleWorld
{
    protected string content;
    protected string title;
    protected bool multiPage;
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

        //Remove this again
        DungeonGenerator dg = new DungeonGenerator();
        dg.GenerateDungeon(new Vector3(100, 100, 1), new Biomes.Biome());

        return true;
    }

    protected virtual void DisplayText()
    {
        if (!multiPage)
            Camera.main.GetComponent<b_CameraDungeon>().UI.DisplaySimpleText(title, content, font);
        else
            Camera.main.GetComponent<b_CameraDungeon>().UI.DisplayMultiplePageText(title, content, font);
    }

    protected virtual void Load()
    {
        //TODO make this into something proper
        content = Util.LoadText(Texts.TEST_MULTIPAGE.fileName);
        title = Texts.TEST_MULTIPAGE.title;
        multiPage = Texts.TEST_MULTIPAGE.multipaged;

        
        //content = Util.Translate(content, TypeEnums.Language.Ancient);
        //title = Util.Translate(title, TypeEnums.Language.Ancient);
        //font = Language.AncientFont;
    }
}
