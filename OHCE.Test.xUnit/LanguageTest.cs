using OHCE;
using OHCE.Test.xUnit.Builder;
using Xunit;

namespace OHCE.Test.xUnit;

public class LanguageTest
{

    [Theory]
    [InlineData(Langue.Français ,Period.Soir, Expressions.Français.Bonsoir)]
    [InlineData(Langue.Français ,Period.Matin, Expressions.Français.Bonjour)]
    [InlineData(Langue.Anglais ,Period.Matin, Expressions.English.Bonjour)]
    public void DireBonjourTest(Langue langue, Period période, string salutationAttendue)
    {
        var ohce = new OhceBuilder().Build(langue, période);
        var salutation = ohce.DireBonjour();

        // ALORS on me répond <salutationAttendue>
        Assert.Equal(salutationAttendue, salutation);
    }

    [Theory]
    [InlineData(Langue.Français, Period.Soir, Expressions.Français.AuRevoir)]
    [InlineData(Langue.Français, Period.Matin, Expressions.Français.AuRevoir)]
    [InlineData(Langue.Anglais, Period.Soir, Expressions.English.AuRevoir)]
    [InlineData(Langue.Anglais, Period.Matin, Expressions.English.AuRevoir)]

    public void DireAuRevoirTest(Langue langue, Period période, string salutationAttendue)
    {
        var ohce = new OhceBuilder().Build(langue, période);
        var salutation = ohce.DireAuRevoir();

        // ALORS on me répond <salutationAttendue>
        Assert.Equal(salutationAttendue, salutation);
    }

    [Theory]
    [InlineData(Langue.Français, Expressions.Français.BienDit)]
    [InlineData(Langue.Anglais, Expressions.English.BienDit)]

    public void DireBienDitTest(Langue langue, string salutationAttendue)
    {
        var ohce = new OhceBuilder().Build(langue, Period.Defaut);
        var salutation = ohce.DireBienDit();

        // ALORS on me répond <salutationAttendue>
        Assert.Equal(salutationAttendue, salutation);
    }



}