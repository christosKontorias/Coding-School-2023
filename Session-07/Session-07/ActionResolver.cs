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

        public virtual string Convertc(string input)
        {
            StringConvert convert = new StringConvert();
            convert.Text = input;

            return convert.Manipulate();
        }
        public string Uppercase(string input)
        {
            StringUppercase uppercase = new StringUppercase();
            uppercase.Text = input;

            return uppercase.Manipulate();

        }
        public virtual string Reverse(string input)
        {
            StringReverse reverse = new StringReverse();
            reverse.Text = input;

            return reverse.Manipulate();
        }
    }
}

