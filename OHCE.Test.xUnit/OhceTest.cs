using OHCE;
using OHCE.Test.xUnit.Builder;
using Xunit;

namespace OHCE.Test.xUnit;

public class OhceTest
{
    [Fact(DisplayName =
        "QUAND on entre une chaîne de caractères " +
        "ALORS elle est renvoyée en miroir")]
    public void MiroirTest()
    {
        var ohce = OhceBuilder.Default;

        // QUAND on entre une chaîne de caractère
        var sortie = ohce.Palindrome("toto");

        // ALORS elle est renvoyée en miroir
        Assert.Contains("otot", sortie);
    }

    [Fact(DisplayName =
        "QUAND on entre un palindrome " +
        "ALORS elle est renvoyée en miroir et Bien dit est renvoyé")]
    public void PalindromeTest()
    {
        var ohce = new OhceBuilder().Build(Langue.Français, Period.Defaut);


        // QUAND on entre une chaîne de caractère
        var sortie = ohce.Palindrome("kayak");

        // ALORS elle est renvoyée en miroir
        Assert.Contains("kayak Bien dit !", sortie);
    }
}