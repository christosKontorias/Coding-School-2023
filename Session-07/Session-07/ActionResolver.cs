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
            ActionResponse response = new ActionResponse();
            response.ResponseID = Guid.NewGuid();
            response.RequestID = request.RequestID;

            MessageLogger logger = new MessageLogger();

            logger.Write(new Message("EXECUTION START"));

            //Message message = new Message("EXECUTION START");
            //logger.Messages[0] = message;

            try {
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
            }
            catch(Exception ex) {
                Message message2 = new Message(ex.Message);
                logger.Messages[1] = message2;
            }
            finally
            {
                Message message3 = new Message("EXECUTION END");
                logger.Messages[0] = message3;
            }

            return response;
        }
        //Constructor
        public ActionResolver()
        {
            Logger = new MessageLogger();
        }

        public virtual string DecimalToBinary(string input)
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
        public virtual string Reverse(string input)
        {
            try
            {
                if (input.Length > 0)
                {
                    return input[input.Length - 1] + Reverse(input.Substring(0, input.Length - 1));
                }
                else
                {
                    return input;
                }
            }
            catch (Exception ex)
            {
                return null;

            }
        }
    }
}

