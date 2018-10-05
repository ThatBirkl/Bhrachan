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

    public void AddPages(ArrayList _pages)
    {
        text = _pages;
        if(text.Count % 2 != 0)
            text.Add("");
    }

    private void SwitchPage()
    {
        bool forward = false;
        bool gotInput = false;

        if (Input.GetAxis("Horizontal") > 0)
        {
            gotInput = true;
            forward = true;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            gotInput = true;
        }

        //check input
        if (!gotInput)
            return;


        if (forward)
        {
            if (text.Count - 1 > displayPointer + 2)
            {
                displayPointer += 2;
            }
        }
        else
        {
            if (0 < displayPointer - 2)
            {
                displayPointer -= 2;
            }
        }

        //left page
        transform.GetChild(0).transform.GetChild(1).GetComponent<UnityEngine.UI.Text>().text = (string)text[displayPointer];
        //right page
        transform.GetChild(1).transform.GetChild(1).GetComponent<UnityEngine.UI.Text>().text = (string)text[displayPointer + 1];
    }
}
