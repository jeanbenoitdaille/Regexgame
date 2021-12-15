    using System;
    using System.Text.RegularExpressions;
     
    namespace Coding.Exercise
    {
        public static class Exercise
        {
            public static string CleanPhoneNumber(string sentence)
            {
                string pattern = @"(0|\\+33|0033)[1-9][0-9]{8}";
                string CleanedString = Regex.Replace(sentence, pattern, "");
                return CleanedString;
            }
        }
    }