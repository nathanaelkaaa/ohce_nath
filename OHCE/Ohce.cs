using System.Text;
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

    public Ohce()
    {
        var sys_time = DateTime.Now.Hour;
        _périodeJournée = GetSysPeriod();
        _langue = GetSysLangue();

        switch (_langue)
        {
            case Langue.Français:
                _dict = new FrançaisDict();
                break;
            case Langue.Anglais:
                _dict = new AnglaisDict();
                break;
        }

 
    }
    public string Palindrome()
    {
        Console.WriteLine("Entrez un mot :");
        string input = Console.ReadLine();
        return Palindrome(input);
    }
    public string Palindrome(string input)
    {
        
        var stringBuilder =
            new StringBuilder(this.DireBonjour());

        var reversed = new string(
            input.Reverse().ToArray()
        );

        stringBuilder.Append(" "+reversed+" ");


        if (reversed.Equals(input) && !reversed.Equals(""))
            stringBuilder.Append(this.DireBienDit()+" ");

        stringBuilder.Append(this.DireAuRevoir());

        return stringBuilder.ToString();
    }

    public Langue GetSysLangue()
    {
        var sys_langue = System.Globalization.CultureInfo.InstalledUICulture.NativeName;
        Langue langue = Langue.Français;
        if (sys_langue.StartsWith("français")||sys_langue.StartsWith("Français"))
        {
            langue = Langue.Français;
        }
        else
        if (sys_langue.StartsWith("english")||sys_langue.StartsWith("English"))
        {
            langue = Langue.Anglais;
        }
        return langue;
    }

    public Period GetSysPeriod()
    {
        Period period = Period.Defaut;
        var sys_time = DateTime.Now.Hour;

        switch (sys_time)
        {
            case 0:
                period = Period.Nuit;
                break;
            case 1:
                period = Period.Nuit;
                break;
            case 2:
                period = Period.Nuit;
                break;
            case 3:
                period = Period.Nuit;
                break;
            case 4:
                period = Period.Nuit;
                break;
            case 5:
                period = Period.Nuit;
                break;
            case 6:
                period = Period.Matin;
                break;
            case 7:
                period = Period.Matin;
                break;
            case 8:
                period = Period.Matin;
                break;
            case 9:
                period = Period.Matin;
                break;
            case 10:
                period = Period.Matin;
                break;
            case 11:
                period = Period.Matin;
                break;
            case 12:
                period = Period.AprèsMidi;
                break;
            case 13:
                period = Period.AprèsMidi;
                break;
            case 14:
                period = Period.AprèsMidi;
                break;
            case 15:
                period = Period.AprèsMidi;
                break;
            case 16:
                period = Period.AprèsMidi;
                break;
            case 17:
                period = Period.AprèsMidi;
                break;
            case 18:
                period = Period.AprèsMidi;
                break;
            case 19:
                period = Period.Soir;
                break;
            case 20:
                period = Period.Soir;
                break;
            case 21:
                period = Period.Soir;
                break;
            case 22:
                period = Period.Soir;
                break;
            case 23:
                period = Period.Soir;
                break;
        }
        return period;
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