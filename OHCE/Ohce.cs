﻿using System.Text;
using OHCE.Language;
namespace OHCE;

public class Ohce
{
    private readonly Langue _langue;
    private readonly Period _périodeJournée;
    private ILanguageDict _dict;
    public Ohce(Langue langue, Period périodeJournée)
    {
        _langue = langue;
        _périodeJournée = périodeJournée;
        switch (langue)
        {
            case Langue.Français:
                _dict = new FrançaisDict();
                break;
            case Langue.Anglais:
                _dict = new AnglaisDict();
                break;
            default:
                _dict = new FrançaisDict();
                break;
        }
    }

    public string Palindrome(string input)
    {
        
        var stringBuilder =
            new StringBuilder(this.DireBonjour()+" ");

        var reversed = new string(
            input.Reverse().ToArray()
        );

        stringBuilder.Append(" "+reversed+" ");


        if (reversed.Equals(input) && !reversed.Equals(""))
            stringBuilder.Append(this.DireBienDit()+" ");

        stringBuilder.Append(this.DireAuRevoir());

        return stringBuilder.ToString();
    }




    public string DireBonjour()
    {
        string sentence;


        switch (_périodeJournée)
        {
            case Period.Matin:
                sentence = _dict.GetDictionary("bonjour_am");
                break;
            case Period.AprèsMidi:
                sentence = _dict.GetDictionary("bonjour_pm");
                break;
            case Period.Soir:
                sentence = _dict.GetDictionary("bonjour_soir");
                break;
            case Period.Nuit:
                sentence = _dict.GetDictionary("bonjour_nuit");
                break;
            default:
                sentence = null;
                break;

        }
        return sentence;
    }


    public string DireAuRevoir()
    {
        string sentence;

        switch (_périodeJournée)
        {
            case Period.Matin:
                sentence = _dict.GetDictionary("auRevoir_am");
                break;
            case Period.AprèsMidi:
                sentence = _dict.GetDictionary("auRevoir_pm");
                break;
            case Period.Soir:
                sentence = _dict.GetDictionary("auRevoir_soir");
                break;
            case Period.Nuit:
                sentence = _dict.GetDictionary("auRevoir_nuit");
                break;
            default:
                sentence = null;
                break;

        }
        return sentence;
    }

    public string DireBienDit()
    {
 
        return _dict.GetDictionary("biendit"); ;
    }
}