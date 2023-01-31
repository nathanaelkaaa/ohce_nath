using System;
using System.Collections.Generic;

namespace OHCE.Language
{
    public class FrançaisDict : ILanguageDict
    {
        public readonly Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                {"biendit", "Bien dit !"},
                {"bonjour_am", "Bonjour"},
                {"bonjour_pm", "Bonne aprèm"},
                {"bonjour_soir", "Bonsoir"},
                {"bonjour_nuit", "Bonne nuit"},
                {"auRevoir_am", "Au revoir"},
                {"auRevoir_pm", "Au revoir"},
                {"auRevoir_soir", "Au revoir"},
                {"auRevoir_nuit", "Au revoir"}
            };
        public FrançaisDict()
        {
        }

        public string GetDictionary(string key)
        {
            if (dictionary.ContainsKey(key))
            {
                return dictionary[key];
            }
            return null;
            
        }
        

    }
}



