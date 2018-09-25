using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Language
{
    //ANCIENT
    public static Dictionary<string, string> Ancient
    {
        get
        {
            Dictionary<string, string> a = new Dictionary<string, string>();

            //FOUR GODS
            a.Add("mother", "ༀ");
            a.Add("creator", "ༀ");
            a.Add("chaos", "༺");
            a.Add("mad brother", "༺");
            a.Add("brother", "༺");
            a.Add("cosmos", "༻");
            a.Add("calm sister", "༻");
            a.Add("sister", "༻");
            a.Add("equilibrium", "༂");
            a.Add("eldest", "༂");

            //combinations
            a.Add("sch", "s");
            a.Add("ch", "c");

            //replacements
            a.Add("p", "b");
            a.Add("t", "d");
            a.Add("k", "c");
            a.Add("z", "s");

            //translation
            a.Add("a", "ཀ");
            a.Add("b", "ཁ");
            a.Add("c", "ག");
            a.Add("d", "གྷ");
            a.Add("e", "ང");
            a.Add("f", "ཅ");
            a.Add("g", "ཆ");
            a.Add("h", "ཇ");
            a.Add("i", "ཉ");
            a.Add("j", "ཊ");
            a.Add("l", "ཋ");
            a.Add("m", "ཌ");
            a.Add("n", "ཌྷ");
            a.Add("o", "ཎ");
            a.Add("q", "ཏ");
            a.Add("r", "ཐ");
            a.Add("s", "ད");
            a.Add("u", "དྷ");
            a.Add("v", "ན");
            a.Add("w", "པ");
            a.Add("x", "ཕ");

            //numbers
            a.Add("5", "10");
            a.Add("6", "11");
            a.Add("7", "12");
            a.Add("8", "13");
            a.Add("9", "14");
            a.Add("0", "༓");
            a.Add("1", "།");
            a.Add("2", "༎");
            a.Add("3", "༏");
            a.Add("4", "༐");

            //punctuation
            a.Add("-", " ");
            a.Add(".", "࿓");
            a.Add(",", "࿒");
            a.Add("(", "࿙");
            a.Add(")", "࿚");
            a.Add("!", "࿑");
            a.Add("?", "࿐");

            return a;
        }
    }

    public static Font AncientFont
    {
        get { return Resources.Load<Font>("Fonts/ancient"); }
    }

    //ELVEN
    public static Dictionary<string, string> Elven
    {
        get
        {
            Dictionary<string, string> elven = new Dictionary<string, string>();
            //replace single letters
            //ogham
            return elven;
        }
    }


    //FELINE
    public static Dictionary<string, string> Feline
    {
        //Lao
        //#0E81
        get
        {
            Dictionary<string, string> a = new Dictionary<string, string>();

            //combinations
            a.Add("sch", "s");
            a.Add("ch", "c");

            //replacements
            a.Add("p", "bb");
            a.Add("t", "dd");
            a.Add("k", "c");
            a.Add("z", "ts");

            //translation
            a.Add("a", "ກ");
            a.Add("b", "ຂ");
            a.Add("c", "ຄ");
            a.Add("d", "ງ");
            a.Add("e", "ຍ");
            a.Add("f", "ຖ");
            a.Add("g", "ນ");
            a.Add("h", "ມ");
            a.Add("i", "ຜ");
            a.Add("j", "ຝ");
            a.Add("l", "ຯ");
            a.Add("m", "ອ");
            a.Add("n", "ຫ");
            a.Add("o", "ສ");
            a.Add("q", "ຢ");
            a.Add("r", "ະ");
            a.Add("s", "ຈ");
            a.Add("u", "ນ");
            a.Add("v", "ໞ");
            a.Add("w", "ຣ");
            a.Add("x", "ຍ");

            //numbers
            a.Add("0", "໐");
            a.Add("1", "໑");
            a.Add("2", "໒");
            a.Add("3", "໓");
            a.Add("4", "໔");
            a.Add("5", "໕");
            a.Add("6", "໖");
            a.Add("7", "໗");
            a.Add("8", "໘");
            a.Add("9", "໙");

            //punctuation
            a.Add("-", " ");
            a.Add(".", "ແ");
            a.Add(",", "ເ");
            a.Add("(", "າ");
            a.Add(")", "ຳ");
            a.Add("!", "ໂ");
            a.Add("?", "ໃ");



            return a;
        }
    }

    public static Font FelineFont
    {
        get { return Resources.Load<Font>("Fonts/feline"); }
    }
}
