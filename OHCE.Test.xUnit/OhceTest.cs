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

    [Fact(DisplayName =
       "QUAND on entre une chaine de caractère et que la période est indiqué " +
       "ALORS Bonjour est au revoir sont envoyé")]
    public void OuvertureTest()
    {
        // ETANT DONNE un utilisateur parlant une langue
        var ohce = new OhceBuilder().Build(Langue.Français, Period.Matin);

        // QUAND l'app démarre
        var sortie = ohce.Palindrome(string.Empty);

        // ALORS <auRevoir> dans cette langue est envoyé
        Assert.StartsWith("Bonjour", sortie);
    }

    [Fact(DisplayName =
       "QUAND on entre une chaine de caractère et que la période est indiqué " +
       "ALORS Bonjour est au revoir sont envoyé")]
    public void FermetureTest()
    {
        // ETANT DONNE un utilisateur parlant une langue
        var ohce = new OhceBuilder().Build(Langue.Français, Period.Matin);

        // QUAND l'app démarre
        var sortie = ohce.Palindrome(string.Empty);

        // ALORS <auRevoir> dans cette langue est envoyé
        Assert.EndsWith("Au revoir", sortie);
    }
}