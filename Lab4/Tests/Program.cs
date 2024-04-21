using Chain_of_Reponsibility;
using Chain_of_Reponsibility.Levels;
using Strategy;
using Meditator;
using Memento;
using Observer;
using Observer.Events;
//Task 1
var level1 = new Level1SupportHandler();
var level2 = new Level2SupportHandler();
var level3 = new Level3SupportHandler();
var level4 = new Level4SupportHandler();
level1.SetNextHandler(level2);
level2.SetNextHandler(level3);
level3.SetNextHandler(level4);
Exception? ex = null;
int number;

do
{
    try
    {
        ex = null;
        int.TryParse(Menu(), out number);
        level1.Handle(number);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        ex = e;
    }
} while (ex != null);

static string Menu()
{
    Console.WriteLine("Welcome to the User Support System!");
    Console.WriteLine("Please choose your issue:");

    Console.WriteLine("1. I cannot access my account.");
    Console.WriteLine("2. I have a billing issue.");
    Console.WriteLine("3. I have a technical issue.");
    Console.WriteLine("4. I need general assistance.");

    Console.Write("Enter your choice: ");
    string? choice = Console.ReadLine();
    return choice;
}
//Task 2
Console.WriteLine("----------------------------------------------------------------------------");
var runway1 = new Runway();
var runway2 = new Runway();
var aircraft1 = new AirCraft("Boeing 747", 1);
var aircraft2 = new AirCraft("Airbus A320", 1);
var commandCentre = new CommandCentre([runway1, runway2], [aircraft1, aircraft2]);
Console.WriteLine($"Is runway {runway1.Id} active: {commandCentre.CheckIsActiveRunway(0)}"); 
commandCentre.CanLand(0);
commandCentre.CanLand(1);
Console.WriteLine($"Is runway {runway1.Id} active: {commandCentre.CheckIsActiveRunway(0)}");
Console.WriteLine($"Is runway {runway2.Id} active: {commandCentre.CheckIsActiveRunway(1)}");
commandCentre.AirCraftTakeOff(0);
Console.WriteLine($"Is runway {runway1.Id} active: {commandCentre.CheckIsActiveRunway(0)}");
Console.WriteLine($"Is runway {runway2.Id} active: {commandCentre.CheckIsActiveRunway(1)}");
Console.WriteLine("----------------------------------------------------------------------------");
//Task 3
LightElementNode div = new LightElementNode("div", "block", "closed", new List<string> { "container" });
div.AddChild(new LightTextNode("Hello"));
var p = new LightElementNode("p", "block", "closed", new List<string> { "paragraph" });
div.AddChild(p);
p.AddChild(new LightTextNode("Molly"));
p.Subscribe(new Click());
p.InvokeEvents();
p.Subscribe(new Mouseover());
p.InvokeEvents();
div.InvokeEvents();
Console.WriteLine("----------------------------------------------------------------------------");
//Task 4
var catImg = new Image();
catImg.LoadImg("http://google.com/OliviaCat.jpg");
catImg.LoadImg("BenjaminCat.png");
Console.WriteLine("----------------------------------------------------------------------------");
//Task 5
var TextDocument = new TextDocument("I love cats");
var TextEditor = new TextEditor(TextDocument);
TextEditor.Save();
TextDocument.AddContent(" and dogs");
TextEditor.Save();
TextDocument.AddContent(" and ducks");
TextEditor.Save();
TextEditor.DocumentHistory();
Console.WriteLine($"{TextDocument}");
TextEditor.Undo();
TextEditor.Undo();
TextEditor.DocumentHistory();
Console.WriteLine($"{TextDocument}");
TextEditor.Undo();
Console.WriteLine($"{TextDocument}");
