using System.Collections;
using System.Collections.Generic;

public class Texts
{
    //DEFINITIONS
    public struct textURL
    {
        public string title;
        public string fileName;
        public bool multipaged;

        public textURL(string _title, string _fileName, bool _multipaged)
        {
            title = _title;
            fileName = System.IO.Path.Combine(path, _fileName);
            multipaged = _multipaged;

        }
    }
    
    private static string path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Assets/Resources/Texts");


    //URLS

    public static textURL TEST_MULTIPAGE = new textURL("Test text", "test_multipage.txt", true);
}
