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

                return string.Empty;
            }
        }

        public class StringUppercase : StringManipulator
        {
            public override string Manipulate()
            {
                //“Uppercase” you must check if the Input is a string and has more than
                //one words(separated by a space), then find the longest word in the
                //Input string and convert it to uppercase.

                return string.Empty;
            }
        }

        public class StringReverse : StringManipulator
        {
            public override string Manipulate()
            {
                //“Reverse” you must check if the Input is a string and reverse it.

                return string.Empty;
            }
        }


    }
}