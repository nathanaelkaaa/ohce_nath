using OHCE;
using OHCE.Test.xUnit.Builder;
using Xunit;

namespace OHCE.Test.xUnit;

public class LanguageTest
{

    [Theory]
    [InlineData(Langue.Français ,Period.Soir, Expressions.Français.Bonsoir)]
    [InlineData(Langue.Français ,Period.Matin, Expressions.Français.Bonjour)]
    [InlineData(Langue.Français, Period.Soir, Expressions.Français.Bonsoir)]
    [InlineData(Langue.Français, Period.Matin, Expressions.Français.Bonjour)]
    public void DireBonjourTest(Langue langue, Period période, string salutationAttendue)
    {
        var ohce = new OhceBuilder().Build(Langue.Français, période);
        var salutation = ohce.DireBonjour();

        // ALORS on me répond <salutationAttendue>
        Assert.Equal(salutationAttendue, salutation);
    }

    [Theory]
    [InlineData(Period.Soir, Expressions.Français.Bonsoir)]
    [InlineData(Period.Matin, Expressions.Français.Bonjour)]
    public void DireAuRevoirTest(Period période, string salutationAttendue)
    {
        var ohce = new OhceBuilder().Build(Langue.Français, période);
        var salutation = ohce.DireAuRevoir();

        // ALORS on me répond <salutationAttendue>
        Assert.Equal(salutationAttendue, salutation);
    }



}