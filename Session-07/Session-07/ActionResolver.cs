using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class ActionResolver
    {

        //Properties
        public MessageLogger Logger { get; set; }

        //Methods
        public ActionResponse Execute(ActionRequest request)
        {
            var response = new ActionResponse();
            response.RequestID = request.RequestID; 

            switch (request.Action)
            {
                case ActionEnum.Convert:
                    response.Output = DecimalToBinary(request.Input);
                    break;

                case ActionEnum.Uppercase:
                    response.Output = Uppercase(request.Input);
                    break;

                case ActionEnum.Reverse:
                    response.Output = Reverse(request.Input);
                    break;

                default:
                    Console.WriteLine("Please select another input");
                    break;
            }

            return response;
        }
        //Constructor
        public ActionResolver()
        {

        }

        public string DecimalToBinary(string input)
        {
            if (decimal.TryParse(input.ToString(), out decimal result))
            {
                return Convert.ToString((int)result, 2);
            }
            else
            {
                return "Input is not a decimal number.";
            }
        }
        public string Uppercase(string input)
        {

            if (input.Contains(" "))
            {
                string[] words = input.Split(' ');
                string longestWord = "";
                foreach (string word in words)
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }
                return longestWord.ToUpper();
            }
            else
            {
                return "Input must contain multiple words.";
            }
        }
        public string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            return Reverse(input.Substring(1)) + input[0];
        }
    }
}
