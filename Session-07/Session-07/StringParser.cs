using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class StringParser
    {
        public class StringManipulator
        {
            public string Text { get; set; }

            public virtual string Manipulate()
            {
                return string.Empty;
            }
        }

        public class StringConvert : StringManipulator
        {
            public override string Manipulate()
            {
                // “Convert” you must check if the Input is a decimal number and convert it to binary.
                if (decimal.TryParse(Text, out decimal number))
                {
                    return Convert.ToString(Convert.ToInt32(number), 2);
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public class StringUppercase : StringManipulator
        {
            public override string Manipulate()
            {
                //“Uppercase” you must check if the Input is a string and has more than
                //one words(separated by a space), then find the longest word in the
                //Input string and convert it to uppercase.   
                if (!string.IsNullOrWhiteSpace(Text) && Text.Contains(" "))
                {
                    string[] words = Text.Split(' ');
                    string longestWord = words.OrderByDescending(w => w.Length).First();
                    return longestWord.ToUpper();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public class StringReverse : StringManipulator
        {
            public override string Manipulate()
            {
                //“Reverse” you must check if the Input is a string and reverse it.

                if (!string.IsNullOrEmpty(Text))
                {
                    char[] charArray = Text.ToCharArray();
                    Array.Reverse(charArray);
                    return new string(charArray);
                }
                else
                {
                    return string.Empty;
                }
            }
        }


    }
}