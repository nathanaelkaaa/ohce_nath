using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Test.xUnit.Builder
{
    internal class OhceBuilder
    {

        public static Ohce Default => new OhceBuilder().Build(Langue.Français,Period.Defaut);

        public Ohce Build(Langue langue, Period périodeJournée) => new Ohce(langue,périodeJournée);

 
    }
}
