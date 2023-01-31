using System;
using System.Collections.Generic;

namespace OHCE.Language
{
    public class AnglaisDict : ILanguageDict
    {
        public readonly Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                {"biendit", "Well said"},
                {"bonjour_am", "Hello"},
                {"bonjour_pm", "Hello"},
                {"bonjour_soir", "Hello"},
                {"bonjour_nuit", "Hello"},
                {"auRevoir_am", "Goodbye"},
                {"auRevoir_pm", "Goodbye"},
                {"auRevoir_soir", "Goodbye"},
                {"auRevoir_nuit", "Goodbye"}
            };
        public AnglaisDict()
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



