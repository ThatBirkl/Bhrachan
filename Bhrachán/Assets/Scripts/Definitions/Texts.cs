using System.Collections;
using System.Collections.Generic;

public class Texts
{
    //DEFINITIONS
    public struct textURL
    {
        public string title,
        public string fileName,
        public bool multipaged
    }
    
    private static string path = "../../Assets/Resources/Texts/";

    
    //URLS
    
    //public static string TEST_MULTIPAGE = path + "text_multipage.txt";
    public static textURL TEXT_MULTIPAGE = { "Test text", path + "text_multipage.txt", true }
}
