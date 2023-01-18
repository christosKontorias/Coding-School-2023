// See https://aka.ms/new-console-template for more information
using Session_07;


ActionRequest request = new ActionRequest();
ActionResponse response = new ActionResponse();
ActionResolver resolver = new ActionResolver();


var request1 = new ActionRequest()
{
    Input = "4",
    Action = ActionEnum.Convert
};

var request2 = new ActionRequest()
{
    Input = "Hello World",
    Action = ActionEnum.Uppercase
};

var request3 = new ActionRequest()
{
    Input = "Christos",
    Action = ActionEnum.Reverse
};

response = resolver.Execute(request1);
response = resolver.Execute(request2);
response = resolver.Execute(request3);

//Console.Write(resolver.Logger.ReadAll());

//Console.ReadLine();
//Console.WriteLine(resolver.Logger.ReadAll());

foreach (Message message in resolver.Logger.Messages)
{
    if (message != null) {     
    Console.WriteLine(message.MessageValue);
    }

}