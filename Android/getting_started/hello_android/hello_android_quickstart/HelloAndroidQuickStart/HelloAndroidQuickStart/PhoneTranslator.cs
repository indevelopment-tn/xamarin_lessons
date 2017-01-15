using System.Text;
using System;

namespace Core
{
    public static class PhonewordTranslator
    {
        public static string ToNumber(string raw)
        {
            //if the raw input string is null or contains only white space
            //return string will be empty
            if (string.IsNullOrWhiteSpace(raw))
                return "";
            else
                raw = raw.ToUpperInvariant();

            var newNumber = new StringBuilder();
            //------------------------------------------------------
            //read each character in the string
            //------------------------------------------------------
            foreach (var c in raw)
            {
                //if any character can be found in the numerical string
                //then append that numerical char to the string newNumber

                if (" -0123456789".Contains(c))
                    newNumber.Append(c);
                else
                {
                    //-------------------------------------------
                    // otherwise translate that char "c" to a 
                    // numerical equivalent and add it
                    //-------------------------------------------
                    var result = TranslateToNumber(c);
                    if (result != null)
                        newNumber.Append(result);
                }
                // otherwise we've skipped a non-numeric char
            }
            return newNumber.ToString();
        }
        static bool Contains(this string keyString, char c)
        {
            return keyString.IndexOf(c) >= 0;
        }
        //-------------------------------------------------------------
        //I want you you to show me another way to write this method
        // todo:    rewrite the method so that it is short with fewer
        //          if statements
        //          your solution may not require contains()
        // Note: what does "int?" mean
        //-----------------------------------------------------------//
        static int? TranslateToNumber(char c)
        {
            if ("ABC".Contains(c))
                return 2;
            else if ("DEF".Contains(c))
                return 3;
            else if ("GHI".Contains(c))
                return 4;
            else if ("JKL".Contains(c))
                return 5;
            else if ("MNO".Contains(c))
                return 6;
            else if ("PQRS".Contains(c))
                return 7;
            else if ("TUV".Contains(c))
                return 8;
            else if ("WXYZ".Contains(c))
                return 9;
            return null;
        }
    }
}