using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class StringParser
    {
        public class StringManipulator
        {
            public string MessageValue { get; set; }

            public virtual string Manipulate(string input)
            {
                return string.Empty;
            }
        }

        public class StringConvert : StringManipulator
        {
            public override string Manipulate()
            {
                // “Convert” you must check if the Input is a decimal number and convert it to binary.

                return string.Empty;
            }
        }

        public class StringUppercase : StringManipulator
        {
            public override string Manipulate()
            {
                //“Uppercase” you must check if the Input is a string and has more than
                //one words(separated by a space), then find the longest word in the
                //Input string and convert it to                 //if (input.Contains(" "))
                //{
                //    string[] words = input.Split(' ');
                //    string longestWord = "";
                //    foreach (string word in words)
                //    {
                //        if (word.Length > longestWord.Length)
                //        {
                //            longestWord = word;
                //        }
                //    }
                //    return longestWord.ToUpper();
                //}
                //else
                //{
                //    return "Input must contain multiple words.";
                //}

                return string.Empty;
            }
        }

        public class StringReverse : StringManipulator
        {
            public override string Manipulate()
            {
                //“Reverse” you must check if the Input is a string and reverse it.

                //try
                //{
                //    if (input.Length > 0)
                //    {
                //        return input[input.Length - 1] + Reverse(input.Substring(0, input.Length - 1));
                //    }
                //    else
                //    {
                //        return input;
                //    }
                //}
                //catch (Exception ex)
                //{
                //    return null;

                //}
                return string.Empty;
            }
        }


    }
}