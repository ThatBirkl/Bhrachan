using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_UITextMultipage : b_UIText
{
    ArrayList text;
    int displayPointer;

    void Start()
    {
        displayPointer = 0;
    }

    protected override void Update()
    {
        base.Update();
        SwitchPage();
    }

    public void AddText(string _text)
    {
        if (text == null)
        {
            text.Add(_text);
            text.Add("");
        }
        else
        {
            if (text[text.Count - 1].Equals(""))
            {
                text[text.Count - 1] = _text;
            }
            else
            {
                text.Add(_text);
                text.Add("");
            }
        }
    }

    private void SwitchPage()
    {
        bool forward = false;

        //check input

        if (forward)
        {
            if (text.Count - 1 != displayPointer + 2)
            {
                displayPointer += 2;
            }
        }
        else
        {
            if (0 != displayPointer - 2)
            {
                displayPointer -= 2;
            }
        }
    }
}
