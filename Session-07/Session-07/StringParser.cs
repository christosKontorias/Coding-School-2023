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
                // ...


                return string.Empty;
            }
        }

        public class StringReverse : StringManipulator
        {

            public override string Manipulate()
            {

                return string.Empty;
            }

        }

        public class StringUppercase : StringManipulator
        {

            public override string Manipulate()
            {

                return string.Empty;
            }
        }
    }
}