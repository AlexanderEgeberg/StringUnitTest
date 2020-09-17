using System;
using System.Reflection;
using System.Xml.Serialization;

namespace StringUtility
{
    public class StringUtility
    {
        public int CountOccurences(string stringToCheck, string stringToFind)
        {
            if (stringToCheck == null || stringToCheck == "")
            {
                return -1;
            }
            var stringToCheckLower = stringToCheck.ToLower();
            var stringAsCharArray = stringToCheckLower.ToCharArray();
            var stringToCheckForAsChar = stringToFind.ToCharArray()[0];
            var occuranceCount = 0;

            foreach (var c in stringAsCharArray)
            {
                if (c == stringToCheckForAsChar)
                {
                    occuranceCount++;
                }
            }

            return occuranceCount;
        }
        
    }
}
