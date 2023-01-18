using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session_07.StringParser;

namespace Session_07
{
    internal class ActionResolver
    {

        //Properties
        public MessageLogger Logger { get; set; }

        //Constructor
        public ActionResolver()
        {
            Logger = new MessageLogger();
        }

        //Methods
        public ActionResponse Execute(ActionRequest request)
        {
            ActionResponse response = new ActionResponse();
            response.ResponseID = Guid.NewGuid();
            response.RequestID = request.RequestID;

            Log("EXECUTION START");

            try
            {
                switch (request.Action)
                {
                    case ActionEnum.Convert:
                        Log("Convert");
                        response.Output = Convert(request.Input);
                        break;

                    case ActionEnum.Uppercase:
                        Log("Uppercase");
                        response.Output = Uppercase(request.Input);
                        break;

                    case ActionEnum.Reverse:
                        Log("Reverse");
                        response.Output = Reverse(request.Input);
                        break;

                    default:
                        Console.WriteLine("Please select another input");
                        break;
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
            finally
            {
                Log("EXECUTE END");
            }

            return response;
        }

        private void Log(string messageValue)
        {
            Logger.Write(new Message(messageValue));
            Message message = new Message(messageValue);
            Logger.Write(message);
        }

        public virtual string Convert(string input)
        {
            StringConvert convert = new StringConvert();
            convert.MessageValue = input;

            return convert.Manipulate();
        }
        public string Uppercase(string input)
        {
            //if (input.Contains(" "))
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
            return input.ToUpper();

        }
        public virtual string Reverse(string input)
        {
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

