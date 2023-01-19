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

var response1 = resolver.Execute(request1);
var response2 = resolver.Execute(request2);
var response3 = resolver.Execute(request3);


Console.WriteLine(response1.Output);
Console.WriteLine(response2.Output);
Console.WriteLine(response3.Output);

resolver.Logger.ReadAll();
Console.ReadLine();