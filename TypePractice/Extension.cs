using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TypePractice
{
    public static class Extension
    {
        public static string Capitalize(this string text)
        {
            var characters = text.ToCharArray();
            characters[0] = char.ToUpper(characters[0]);
            return new string(characters);
        }
    }
}
