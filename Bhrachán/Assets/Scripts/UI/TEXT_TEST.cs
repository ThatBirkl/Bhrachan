using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEXT_TEST : MonoBehaviour
{
    void Start()
    {
        gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().font =
            Util.GetFont(TypeEnums.Language.Feline);

        gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = "TEST";
            //Util.Translate("This is just a test.", TypeEnums.Language.Feline);

        Debug.Log(gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text);
    }
}
