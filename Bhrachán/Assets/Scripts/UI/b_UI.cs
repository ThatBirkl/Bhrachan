using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_UI : MonoBehaviour
{
    public void DisplaySimpleText(string _title, string _text)
    {
        GameObject p = Resources.Load<GameObject>("Prefabs/p_SimpleText");

        Instantiate(p);

        p.transform.SetParent(transform, false);
    }

    public void DisplayMultiplePageText(string _title, string _text)
    {
        gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().font =
            Util.GetFont(TypeEnums.Language.Feline);

        gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "TEST";
    }
}
