using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UI = UnityEngine.UI;

public class b_UI : MonoBehaviour
{
    public void DisplaySimpleText(string _title, string _text, Font _font)
    {
        GameObject p = Instantiate(Resources.Load<GameObject>("Prefabs/p_SimpleText"));

        //title
        UI.Text t = p.transform.GetChild(1).GetComponent<UI.Text>();
        t.text = _title;
        t.font = _font;

        //content
        t = p.transform.GetChild(2).GetComponent<UI.Text>();
        t.text = _text;
        t.font = _font;

        //done last so it's only displayed once everything is set
        p.transform.SetParent(transform, false);
    }

    public void DisplayMultiplePageText(string _title, string _text, Font _font)
    {
        GameObject p = Instantiate(Resources.Load<GameObject>("Prefabs/p_MultipageText"));

        ArrayList pages = Util.PageString(_text, Meta.Texts.CHAR_COUNT);
        
        p.GetComponent<b_UITextMultipage>().AddPages(pages);
        
        //UI.Text t = p.transform.GetChild(0).transform.GetChild(1).GetComponent<UI.Text>();

        //done last so it's only displayed once everything is set
        p.transform.SetParent(transform, false);
    }
}
